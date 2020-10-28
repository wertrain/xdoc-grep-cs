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
        /// 
        /// </summary>
        private class WorkerResultParam
        {
            /// <summary>
            /// 
            /// </summary>
            public class Result
            {
                /// <summary>
                /// 
                /// </summary>
                public string SearchedAroundText { get; set; }

                /// <summary>
                /// 
                /// </summary>
                public string FilePath { get; set; }
            }

            /// <summary>
            /// 
            /// </summary>
            public List<Result> Results { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int FileCount { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public WorkerResultParam()
            {
                Results = new List<Result>();
            }
        }

        /// <summary>
        /// 設定情報
        /// </summary>
        private Settings _settings;

        /// <summary>
        /// 
        /// </summary>
        private Caches _caches;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _settings = Settings.Load();
            Size = _settings.FormSize;

            _caches = Caches.Load();

            comboBoxTarget.Items.AddRange(_settings.TargetHistory.ToArray<string>());
            comboBoxExtensions.Items.AddRange(_settings.ExtensionsHistory.ToArray<string>());
            comboBoxSearchText.Items.AddRange(_settings.SearchTextHistory.ToArray<string>());
            if (_settings.TargetHistory.Count > 0) comboBoxTarget.Text = _settings.TargetHistory[0];
            if (_settings.ExtensionsHistory.Count > 0) comboBoxExtensions.Text = _settings.ExtensionsHistory[0];
            if (_settings.SearchTextHistory.Count > 0) comboBoxSearchText.Text = _settings.SearchTextHistory[0];

            buttonSearch.Visible = true;
            buttonSearch.Enabled = comboBoxSearchText.Text.Length > 0 && comboBoxTarget.Text.Length > 0;
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
            Caches.Save(_caches);
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
                if (string.IsNullOrWhiteSpace(comboBoxExtensions.Text))
                {
                    comboBoxExtensions.Text = "*.*";
                }

                var args = new List<string>();
                args.Add(comboBoxTarget.Text);
                args.Add(comboBoxExtensions.Text);
                args.Add(comboBoxSearchText.Text);
                backgroundWorkerSearch.RunWorkerAsync(args);

                _settings.TargetHistory.Remove(comboBoxTarget.Text);
                _settings.TargetHistory.Insert(0, comboBoxTarget.Text);
                _settings.ExtensionsHistory.Remove(comboBoxExtensions.Text);
                _settings.ExtensionsHistory.Insert(0, comboBoxExtensions.Text);
                _settings.SearchTextHistory.Remove(comboBoxSearchText.Text);
                _settings.SearchTextHistory.Insert(0, comboBoxSearchText.Text);

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
            var args = e.Argument as List<string>;
            var targetPath = args[0];
            var extensions = args[1];
            var searchText = args[2];

            var files = new List<string>();
            if (Directory.Exists(targetPath))
            {
                var caches = _caches.HasCache(targetPath);

                if (caches == null)
                {
                    foreach (var extension in extensions.Split())
                    {
                        var param = new WorkerProgressParam();
                        foreach (var file in Directory.EnumerateFiles(targetPath, extension, SearchOption.AllDirectories))
                        {
                            files.Add(file);
                            if (backgroundWorkerSearch.CancellationPending)
                            {
                                param.Mode = WorkerProgressParam.WorkerMode.ModeCanceled;
                                backgroundWorkerSearch.ReportProgress(0, param);
                                break;
                            }

                            param.Mode = WorkerProgressParam.WorkerMode.ModeSearchingFiles;
                            param.FileCount = files.Count;
                            backgroundWorkerSearch.ReportProgress(0, param);
                        }
                    }
                }
                else
                {
                    files.AddRange(caches);
                }

                _caches.UpdateCache(targetPath, files);
            }
            else
            {
                files.Add(targetPath);
            }

            int count = 0;
            var resultParam = new WorkerResultParam();
            resultParam.FileCount = files.Count;
            foreach (var file in files)
            {
                var param = new WorkerProgressParam();
                param.Mode = WorkerProgressParam.WorkerMode.ModeCheckFile;
                param.FileCount = ++count;
                param.FilePath = file;
                backgroundWorkerSearch.ReportProgress((int)(((double)count / (double)files.Count) * 100.0), param);

                string extractedText = string.Empty;
                XDoc2TxtManager.Extract(file, ref extractedText);

                int index = 0;
                const int aroundTextLength = 20;
                while((index = extractedText.IndexOf(searchText, index)) != -1 && !backgroundWorkerSearch.CancellationPending)
                {
                    var result = new WorkerResultParam.Result();
                    int startIndex = Math.Max(0, index - aroundTextLength);
                    result.SearchedAroundText = extractedText.Substring(startIndex, aroundTextLength * 2 + searchText.Length);
                    result.FilePath = file;
                    resultParam.Results.Add(result);

                    index = index + 1;
                }

                if (backgroundWorkerSearch.CancellationPending)
                {
                    param.Mode = WorkerProgressParam.WorkerMode.ModeCanceled;
                    backgroundWorkerSearch.ReportProgress(0, param);
                    break;
                }
            }
            e.Result = resultParam;
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
                    toolStripProgressBarSearchProgress.Style = ProgressBarStyle.Blocks;
                    toolStripProgressBarSearchProgress.Available = true;
                    toolStripStatusLabelSearchState.Text = "Checking file".Localize() + " : " + param.FilePath;
                    break;
            }

            toolStripStatusLabelSearchState.Invalidate();

            // 即時更新されないため、以下のハックを使う
            // https://stackoverflow.com/questions/7462978/progress-bar-value-is-not-synchronized-with-what-gets-rendered-in-windows-7
            // マイナスの場合には即時にアニメーションが反映されるらしい
            int max = toolStripProgressBarSearchProgress.Maximum;
            toolStripProgressBarSearchProgress.Maximum = int.MaxValue;
            toolStripProgressBarSearchProgress.Value = int.MaxValue;
            toolStripProgressBarSearchProgress.Maximum = max;
            toolStripProgressBarSearchProgress.Value = e.ProgressPercentage;
            Application.DoEvents();
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

            var resultParam = e.Result as WorkerResultParam;
            if (resultParam.Results.Count == 0)
            {
                MessageBox.Show(resultParam.FileCount == 0 ?
                    "File not found".Localize() : "Text not found".Localize(), Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (var form = new FormSearchResult())
                {
                    var searchResults = new List<FormSearchResult.SearchResult>();
                    foreach (var result in resultParam.Results)
                    {
                        var searchResult = new FormSearchResult.SearchResult();
                        searchResult.Text = result.SearchedAroundText;
                        searchResult.FilePath = result.FilePath;
                        searchResults.Add(searchResult);
                    }
                    form.SetResults(searchResults);
                    form.ShowDialog();
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCommon_TextUpdate(object sender, EventArgs e)
        {
            buttonSearch.Enabled = comboBoxSearchText.Text.Length > 0 && comboBoxTarget.Text.Length > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemToolClearCaches_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to clear the cache?".Localize(), 
                "Clearing Cache".Localize(),
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _caches = Caches.Default();
                Caches.Save(_caches);
            }
        }
    }
}
