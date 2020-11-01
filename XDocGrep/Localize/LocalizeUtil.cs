using System.Windows.Forms;

namespace XDocGrep.Localize
{
    public class LocalizeUtil
    {
        /// <summary>
        /// コントロールとその子をローカライズする
        /// </summary>
        /// <param name="control"></param>
        public static void Localized (Control control)
        {
            control.Text = control.Text.Localize();
            foreach (var child in control.Controls)
            {
                if (child is Control)
                {
                    var childControl = child as Control;
                    Localized(childControl);
                }

                if (child is Label)
                {
                    var childLabel = child as Label;
                    childLabel.Text = childLabel.Text.Localize();
                }

                if (child is MenuStrip)
                {
                    var childMenuStrip = child as MenuStrip;
                    foreach (var item in childMenuStrip.Items)
                    {
                        if (item is ToolStripMenuItem)
                        {
                            var menuItem = item as ToolStripMenuItem;
                            menuItem.Text = menuItem.Text.Localize();

                            foreach (var childItem in menuItem.DropDownItems)
                            {
                                if (childItem is ToolStripMenuItem)
                                {
                                    var dropDownItem = childItem as ToolStripMenuItem;
                                    dropDownItem.Text = dropDownItem.Text.Localize();
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// コントロールとその子をローカライズする
        /// </summary>
        /// <param name="control"></param>
        public static void Localized(ContextMenuStrip contextMenuStrip)
        {
            foreach (var item in contextMenuStrip.Items)
            {
                if (item is ToolStripMenuItem)
                {
                    var menuItem = item as ToolStripMenuItem;
                    menuItem.Text = menuItem.Text.Localize();
                }
            }
        }
    }
}
