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
            public string FileName { get; set; }
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
                item.SubItems.Add(result.FileName);
                listViewSearchResult.Items.Add(item);
            }
        }
    }
}
