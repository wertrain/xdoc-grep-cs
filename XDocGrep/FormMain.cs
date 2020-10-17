using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            LocalizeUtil.Localized(this);
            LocalizeUtil.Localized(contextMenuStripTargetSelect);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _settings.FormSize = Size;
            Settings.Save(_settings);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

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
    }
}
