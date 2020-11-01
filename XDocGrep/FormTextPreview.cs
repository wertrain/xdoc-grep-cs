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
        /// <summary>
        /// 
        /// </summary>
        private int CurrentWordIndex { get; set; } = -1;

        /// <summary>
        /// 
        /// </summary>
        private int MaxWordIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FormTextPreview()
        {
            InitializeComponent();

            Localize.LocalizeUtil.Localized(this);
            Localize.LocalizeUtil.Localized(toolStripPreviewControl);
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
        public void SetText(string text, string searchedWord)
        {
            SetText(text);
            HighlightText(searchedWord);

            richTextBoxFilePreview.Select(0, 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonPrev_Click(object sender, EventArgs e)
        {
            if (CurrentWordIndex - 1 < 0)
                return;
            --CurrentWordIndex;

            int pos = 0, wordCount = 0;
            while ((pos = richTextBoxFilePreview.Find(toolStripTextBoxSearchedWord.Text, pos, RichTextBoxFinds.None)) > -1)
            {
                if (wordCount++ == CurrentWordIndex)
                {
                    richTextBoxFilePreview.SelectionStart = richTextBoxFilePreview.Find(toolStripTextBoxSearchedWord.Text, pos, RichTextBoxFinds.None);
                    richTextBoxFilePreview.ScrollToCaret();
                    break;
                }
                ++pos;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {
           if (CurrentWordIndex + 1 >= MaxWordIndex)
                return;
            ++CurrentWordIndex;

            int pos = 0, wordCount = 0;
            while ((pos = richTextBoxFilePreview.Find(toolStripTextBoxSearchedWord.Text, pos, RichTextBoxFinds.None)) > -1)
            {
                if (wordCount++ == CurrentWordIndex)
                {
                    richTextBoxFilePreview.SelectionStart = richTextBoxFilePreview.Find(toolStripTextBoxSearchedWord.Text, pos, RichTextBoxFinds.None);
                    richTextBoxFilePreview.ScrollToCaret();
                    break;
                }
                ++pos;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetText"></param>
        private void HighlightText(string targetText)
        {
            toolStripTextBoxSearchedWord.Text = targetText;
            richTextBoxFilePreview.Text = richTextBoxFilePreview.Text.ToString();

            int pos = 0, wordCount = 0;
            while ((pos = richTextBoxFilePreview.Find(toolStripTextBoxSearchedWord.Text, pos, RichTextBoxFinds.None)) > -1)
            {
                ++wordCount;
                richTextBoxFilePreview.Select(pos, toolStripTextBoxSearchedWord.Text.Length);
                richTextBoxFilePreview.SelectionBackColor = Color.Red;
                richTextBoxFilePreview.SelectionFont = new Font(richTextBoxFilePreview.Font, FontStyle.Bold);
                ++pos;
            }
            MaxWordIndex = wordCount;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBoxSearchedWord_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as ToolStripTextBox;

            HighlightText(textbox.Text);
        }
    }
}
