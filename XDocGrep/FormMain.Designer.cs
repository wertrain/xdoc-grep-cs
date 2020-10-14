namespace XDocGrep
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSearchTextOpenFile = new System.Windows.Forms.Button();
            this.buttonTargetOpenFile = new System.Windows.Forms.Button();
            this.comboBoxSearchText = new System.Windows.Forms.ComboBox();
            this.comboBoxExtensions = new System.Windows.Forms.ComboBox();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.labelSearchText = new System.Windows.Forms.Label();
            this.labelExtensions = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolTToolStripMenuItem
            // 
            this.toolTToolStripMenuItem.Name = "toolTToolStripMenuItem";
            this.toolTToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.toolTToolStripMenuItem.Text = "Tool(&T)";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelMain, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.statusStrip1, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(899, 148);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.buttonSearch);
            this.panelMain.Controls.Add(this.buttonSearchTextOpenFile);
            this.panelMain.Controls.Add(this.buttonTargetOpenFile);
            this.panelMain.Controls.Add(this.comboBoxSearchText);
            this.panelMain.Controls.Add(this.comboBoxExtensions);
            this.panelMain.Controls.Add(this.comboBoxTarget);
            this.panelMain.Controls.Add(this.labelSearchText);
            this.panelMain.Controls.Add(this.labelExtensions);
            this.panelMain.Controls.Add(this.labelTarget);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(893, 120);
            this.panelMain.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(752, 88);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(131, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search (&F)";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonSearchTextOpenFile
            // 
            this.buttonSearchTextOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchTextOpenFile.Location = new System.Drawing.Point(846, 59);
            this.buttonSearchTextOpenFile.Name = "buttonSearchTextOpenFile";
            this.buttonSearchTextOpenFile.Size = new System.Drawing.Size(37, 23);
            this.buttonSearchTextOpenFile.TabIndex = 7;
            this.buttonSearchTextOpenFile.Text = "...";
            this.buttonSearchTextOpenFile.UseVisualStyleBackColor = true;
            // 
            // buttonTargetOpenFile
            // 
            this.buttonTargetOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTargetOpenFile.Location = new System.Drawing.Point(846, 9);
            this.buttonTargetOpenFile.Name = "buttonTargetOpenFile";
            this.buttonTargetOpenFile.Size = new System.Drawing.Size(37, 23);
            this.buttonTargetOpenFile.TabIndex = 6;
            this.buttonTargetOpenFile.Text = "...";
            this.buttonTargetOpenFile.UseVisualStyleBackColor = true;
            // 
            // comboBoxSearchText
            // 
            this.comboBoxSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchText.FormattingEnabled = true;
            this.comboBoxSearchText.Location = new System.Drawing.Point(158, 61);
            this.comboBoxSearchText.Name = "comboBoxSearchText";
            this.comboBoxSearchText.Size = new System.Drawing.Size(682, 20);
            this.comboBoxSearchText.TabIndex = 5;
            // 
            // comboBoxExtensions
            // 
            this.comboBoxExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxExtensions.FormattingEnabled = true;
            this.comboBoxExtensions.Location = new System.Drawing.Point(158, 36);
            this.comboBoxExtensions.Name = "comboBoxExtensions";
            this.comboBoxExtensions.Size = new System.Drawing.Size(682, 20);
            this.comboBoxExtensions.TabIndex = 4;
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Location = new System.Drawing.Point(158, 11);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(682, 20);
            this.comboBoxTarget.TabIndex = 3;
            // 
            // labelSearchText
            // 
            this.labelSearchText.AutoSize = true;
            this.labelSearchText.Location = new System.Drawing.Point(8, 64);
            this.labelSearchText.Name = "labelSearchText";
            this.labelSearchText.Size = new System.Drawing.Size(86, 12);
            this.labelSearchText.TabIndex = 2;
            this.labelSearchText.Text = "Search Text (&S)";
            // 
            // labelExtensions
            // 
            this.labelExtensions.AutoSize = true;
            this.labelExtensions.Location = new System.Drawing.Point(8, 39);
            this.labelExtensions.Name = "labelExtensions";
            this.labelExtensions.Size = new System.Drawing.Size(117, 12);
            this.labelExtensions.TabIndex = 1;
            this.labelExtensions.Text = "Target Extensions (&E)";
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(8, 14);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(144, 12);
            this.labelTarget.TabIndex = 0;
            this.labelTarget.Text = "Search File / Directory (&A)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 126);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(899, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStripMain";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 172);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "XGrepper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolTToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSearchTextOpenFile;
        private System.Windows.Forms.Button buttonTargetOpenFile;
        private System.Windows.Forms.ComboBox comboBoxSearchText;
        private System.Windows.Forms.ComboBox comboBoxExtensions;
        private System.Windows.Forms.ComboBox comboBoxTarget;
        private System.Windows.Forms.Label labelSearchText;
        private System.Windows.Forms.Label labelExtensions;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

