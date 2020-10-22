using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using XDocGrep.Localize;

namespace XDocGrep
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private class WorkerProgressParam
        {
            /// <summary>
            /// 
            /// </summary>
            public enum WorkerMode
            {
                /// <summary>
                /// 
                /// </summary>
                ModeSearchingFiles,

                /// <summary>
                /// 
                /// </summary>
                ModeCheckFile,

                /// <summary>
                /// 
                /// </summary>
                ModeCanceled
            }

            /// <summary>
            /// 
            /// </summary>
            public WorkerMode Mode { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int FileCount { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string FilePath { get; set; }
        }


        /// <summary>
        /// 設定情報
        /// </summary>
        private Settings _settings;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _settings = Settings.Load();
            Size = _settings.FormSize;

            comboBoxTarget.Items.AddRange(_settings.TargetHistory.ToArray<string>());
            comboBoxExtensions.Items.AddRange(_settings.ExtensionsHistory.ToArray<string>());
            comboBoxSearchText.Items.AddRange(_settings.SearchTextHistory.ToArray<string>());

            buttonSearch.Visible = true;
            buttonCancel.Visible = false;
            toolStripProgressBarSearchProgress.Available = false;

            LocalizeUtil.Localized(this);
            LocalizeUtil.Localized(contextMenuStripTargetSelect);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _settings.FormSize = Size;
            Settings.Save(_settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!backgroundWorkerSearch.IsBusy)
            {
                var args = new List<string>();
                args.Add(comboBoxTarget.Text);
                backgroundWorkerSearch.RunWorkerAsync(args);

                _settings.TargetHistory.Remove(comboBoxTarget.Text);
                _settings.TargetHistory.Add(comboBoxTarget.Text);
                _settings.ExtensionsHistory.Remove(comboBoxExtensions.Text);
                _settings.ExtensionsHistory.Add(comboBoxExtensions.Text);
                _settings.SearchTextHistory.Remove(comboBoxSearchText.Text);
                _settings.SearchTextHistory.Add(comboBoxSearchText.Text);

                buttonSearch.Visible = false;
                buttonCancel.Visible = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerSearch.IsBusy)
            {
                backgroundWorkerSearch.CancelAsync();
                buttonSearch.Visible = true;
                buttonCancel.Visible = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTargetOpenFile_Click(object sender, EventArgs e)
        {
            Point screenPoint = buttonTargetOpenFile.PointToScreen(new Point(buttonTargetOpenFile.Left, buttonTargetOpenFile.Bottom));

            if (screenPoint.Y + contextMenuStripTargetSelect.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                contextMenuStripTargetSelect.Show(buttonTargetOpenFile, new Point(0, -contextMenuStripTargetSelect.Size.Height));
            }
            else
            {
                contextMenuStripTargetSelect.Show(buttonTargetOpenFile, new Point(0, buttonTargetOpenFile.Height));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemSelectFile_Click(object sender, EventArgs e)
        {
            using (var cfd = new CommonOpenFileDialog())
            {
                cfd.RestoreDirectory = true;
                cfd.IsFolderPicker = false;

                if (cfd.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    comboBoxTarget.Text = cfd.FileName;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemSelectDirectory_Click(object sender, EventArgs e)
        {
            using (var cfd = new CommonOpenFileDialog())
            {
                cfd.RestoreDirectory = true;
                cfd.IsFolderPicker = true;

                if (cfd.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    comboBoxTarget.Text = cfd.FileName;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            int fileCount = 0;

            var args = e.Argument as List<string>;
            var targetPath = args[0];

            var param = new WorkerProgressParam();
            foreach (var file in Directory.EnumerateFiles(targetPath, "*", SearchOption.AllDirectories))
            {
                ++fileCount;
                if (backgroundWorkerSearch.CancellationPending)
                {
                    param.Mode = WorkerProgressParam.WorkerMode.ModeCanceled;
                    backgroundWorkerSearch.ReportProgress(0, param);
                    break;
                }

                param.Mode = WorkerProgressParam.WorkerMode.ModeSearchingFiles;
                param.FileCount = fileCount;
                backgroundWorkerSearch.ReportProgress(0, param);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var param = e.UserState as WorkerProgressParam;

            switch(param.Mode)
            {
                case WorkerProgressParam.WorkerMode.ModeSearchingFiles:
                    toolStripProgressBarSearchProgress.Style = ProgressBarStyle.Marquee;
                    toolStripProgressBarSearchProgress.Available = true;
                    toolStripStatusLabelSearchState.Text = "Searching for a files".Localize() + " : " + param.FileCount;
                    break;

                case WorkerProgressParam.WorkerMode.ModeCheckFile:
                    toolStripStatusLabelSearchState.Text = "Checking file".Localize() + " : " + param.FilePath;
                    break;
            }

            toolStripProgressBarSearchProgress.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonSearch.Visible = true;
            buttonCancel.Visible = false;
            toolStripStatusLabelSearchState.Text = string.Empty;
            toolStripProgressBarSearchProgress.Available = false;
        }
    }
}
