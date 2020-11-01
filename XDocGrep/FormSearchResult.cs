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
using XDocGrep.Localize;

namespace XDocGrep
{
    public partial class FormSearchResult : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public class SearchResult
        {
            /// <summary>
            /// 
            /// </summary>
            public string Text { get; set; }
            
            /// <summary>
            /// 
            /// </summary>
            public string FilePath { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string SearchedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FormSearchResult()
        {
            InitializeComponent();

            Localize.LocalizeUtil.Localized(this);
            Localize.LocalizeUtil.Localized(contextMenuStripMain);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="results"></param>
        public void SetResults(string searchText, List<SearchResult> results)
        {
            SearchedText = searchText;

            foreach (var result in results)
            {
                var item = new ListViewItem();
                item.Text = result.Text;
                item.Tag = result.FilePath;
                item.SubItems.Add(Path.GetFileName(result.FilePath));
                listViewSearchResult.Items.Add(item);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemOpenInExplorer_Click(object sender, EventArgs e)
        {
            var listView = listViewSearchResult;

            foreach (ListViewItem item in listView.SelectedItems)
            {
                var directory = Path.GetDirectoryName(item.Tag as string);
                System.Diagnostics.Process.Start(directory);
                break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemCopyFilePath_Click(object sender, EventArgs e)
        {
            var listView = listViewSearchResult;

            foreach (ListViewItem item in listView.SelectedItems)
            {
                Clipboard.SetText(item.Tag as string);
                break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemExportText_Click(object sender, EventArgs e)
        {
            var listView = listViewSearchResult;

            foreach (ListViewItem item in listView.SelectedItems)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    var filePath = item.Tag as string;
                    sfd.FileName = Path.GetFileNameWithoutExtension(filePath) + ".txt";
                    sfd.InitialDirectory = Path.GetDirectoryName(filePath);
                    sfd.Filter = "Text File (*.txt)|*.txt".Localize();

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string extractedText = string.Empty;
                        XDoc2TxtManager.Extract(filePath, ref extractedText);
                        try
                        {
                            File.WriteAllText(sfd.FileName, extractedText);
                        }
                        catch(Exception)
                        {
                            MessageBox.Show(
                                "Failed to save the file".Localize(), "Error".Localize(),
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                            );
                        }
                    }
                }
                break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewSearchResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var listView = listViewSearchResult;

            foreach (ListViewItem item in listView.SelectedItems)
            {
                using (var previewWindow = new FormTextPreview())
                {
                    var filePath = item.Tag as string;
                    string extractedText = string.Empty;
                    if (XDoc2TxtManager.Extract(filePath, ref extractedText) > 0)
                    {
                        previewWindow.SetText(extractedText, SearchedText);
                        previewWindow.ShowDialog();
                    }
                }
                break;
            }
        }
    }
}
