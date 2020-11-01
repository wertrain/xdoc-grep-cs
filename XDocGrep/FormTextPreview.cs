using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDocGrep
{
    public partial class FormTextPreview : Form
    {
        public FormTextPreview()
        {
            InitializeComponent();

            Localize.LocalizeUtil.Localized(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public void SetText(string text)
        {
            richTextBoxFilePreview.Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="strongWord"></param>
        public void SetText(string text, string strongWord)
        {
            SetText(text);

            int pos = 0;
            while ((pos = richTextBoxFilePreview.Find(strongWord, pos, RichTextBoxFinds.None)) > -1)
            {
                richTextBoxFilePreview.Select(pos, strongWord.Length);
                richTextBoxFilePreview.SelectionBackColor = Color.Red;
                richTextBoxFilePreview.SelectionFont = new Font(richTextBoxFilePreview.Font, FontStyle.Bold);
                ++pos;
            }
            richTextBoxFilePreview.Select(0, 0);
        }
    }
}
