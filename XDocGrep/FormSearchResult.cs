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

namespace XDocGrep
{
    public partial class FormSearchResult : Form
    {
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

        public FormSearchResult()
        {
            InitializeComponent();

            Localize.LocalizeUtil.Localized(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="results"></param>
        public void SetResults(List<SearchResult> results)
        {
            foreach (var result in results)
            {
                var item = new ListViewItem();
                item.Text = result.Text;
                item.Tag = result.FilePath;
                item.SubItems.Add(Path.GetFileName(result.FilePath));
                listViewSearchResult.Items.Add(item);
            }
        }
    }
}
