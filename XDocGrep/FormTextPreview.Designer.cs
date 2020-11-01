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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripPreviewControl = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrev = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxSearchedWord = new System.Windows.Forms.ToolStripTextBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.toolStripPreviewControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxFilePreview
            // 
            this.richTextBoxFilePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxFilePreview.Location = new System.Drawing.Point(3, 28);
            this.richTextBoxFilePreview.Name = "richTextBoxFilePreview";
            this.richTextBoxFilePreview.Size = new System.Drawing.Size(794, 419);
            this.richTextBoxFilePreview.TabIndex = 0;
            this.richTextBoxFilePreview.Text = "";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.toolStripPreviewControl, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.richTextBoxFilePreview, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // toolStripPreviewControl
            // 
            this.toolStripPreviewControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSearchedWord,
            this.toolStripButtonPrev,
            this.toolStripButtonNext});
            this.toolStripPreviewControl.Location = new System.Drawing.Point(0, 0);
            this.toolStripPreviewControl.Name = "toolStripPreviewControl";
            this.toolStripPreviewControl.Size = new System.Drawing.Size(800, 25);
            this.toolStripPreviewControl.TabIndex = 0;
            this.toolStripPreviewControl.Text = "toolStrip1";
            // 
            // toolStripButtonPrev
            // 
            this.toolStripButtonPrev.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrev.Image")));
            this.toolStripButtonPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrev.Name = "toolStripButtonPrev";
            this.toolStripButtonPrev.Size = new System.Drawing.Size(90, 22);
            this.toolStripButtonPrev.Text = "Previous (&P)";
            this.toolStripButtonPrev.Click += new System.EventHandler(this.toolStripButtonPrev_Click);
            // 
            // toolStripButtonNext
            // 
            this.toolStripButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNext.Image")));
            this.toolStripButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNext.Name = "toolStripButtonNext";
            this.toolStripButtonNext.Size = new System.Drawing.Size(72, 22);
            this.toolStripButtonNext.Text = "Next (&N)";
            this.toolStripButtonNext.Click += new System.EventHandler(this.toolStripButtonNext_Click);
            // 
            // toolStripTextBoxSearchedWord
            // 
            this.toolStripTextBoxSearchedWord.Name = "toolStripTextBoxSearchedWord";
            this.toolStripTextBoxSearchedWord.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxSearchedWord.TextChanged += new System.EventHandler(this.toolStripTextBoxSearchedWord_TextChanged);
            // 
            // FormTextPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTextPreview";
            this.Text = "File Preview";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.toolStripPreviewControl.ResumeLayout(false);
            this.toolStripPreviewControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxFilePreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.ToolStrip toolStripPreviewControl;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrev;
        private System.Windows.Forms.ToolStripButton toolStripButtonNext;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearchedWord;
    }
}