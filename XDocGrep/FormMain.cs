using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XDocGrep.Localize;

namespace XDocGrep
{
    public partial class FormMain : Form
    {
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
        /// 設定情報
        /// </summary>
        private Settings _settings;
    }
}
