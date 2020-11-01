namespace XDocGrep
{
    partial class FormTextPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTextPreview));
            this.richTextBoxFilePreview = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxFilePreview
            // 
            this.richTextBoxFilePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxFilePreview.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxFilePreview.Name = "richTextBoxFilePreview";
            this.richTextBoxFilePreview.Size = new System.Drawing.Size(800, 450);
            this.richTextBoxFilePreview.TabIndex = 0;
            this.richTextBoxFilePreview.Text = "";
            // 
            // FormTextPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxFilePreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTextPreview";
            this.Text = "File Preview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxFilePreview;
    }
}