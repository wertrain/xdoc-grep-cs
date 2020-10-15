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
            }
        }
    }
}
