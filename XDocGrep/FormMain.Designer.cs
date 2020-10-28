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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSearchTextOpenFile = new System.Windows.Forms.Button();
            this.buttonTargetOpenFile = new System.Windows.Forms.Button();
            this.comboBoxSearchText = new System.Windows.Forms.ComboBox();
            this.comboBoxExtensions = new System.Windows.Forms.ComboBox();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.labelSearchText = new System.Windows.Forms.Label();
            this.labelExtensions = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarSearchProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelSearchState = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripTargetSelect = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSelectFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSelectDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.toolStripMenuItemToolClearCaches = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.contextMenuStripTargetSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTool});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(564, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemTool
            // 
            this.toolStripMenuItemTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemToolClearCaches});
            this.toolStripMenuItemTool.Name = "toolStripMenuItemTool";
            this.toolStripMenuItemTool.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItemTool.Text = "Tool(&T)";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelMain);
            this.tableLayoutPanelMain.Controls.Add(this.statusStripMain);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(564, 147);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.buttonCancel);
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
            this.panelMain.Size = new System.Drawing.Size(558, 119);
            this.panelMain.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(417, 88);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(131, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel (&F)";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(417, 88);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(131, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search (&F)";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSearchTextOpenFile
            // 
            this.buttonSearchTextOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchTextOpenFile.Location = new System.Drawing.Point(511, 59);
            this.buttonSearchTextOpenFile.Name = "buttonSearchTextOpenFile";
            this.buttonSearchTextOpenFile.Size = new System.Drawing.Size(37, 23);
            this.buttonSearchTextOpenFile.TabIndex = 7;
            this.buttonSearchTextOpenFile.Text = "...";
            this.buttonSearchTextOpenFile.UseVisualStyleBackColor = true;
            this.buttonSearchTextOpenFile.Visible = false;
            // 
            // buttonTargetOpenFile
            // 
            this.buttonTargetOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTargetOpenFile.Location = new System.Drawing.Point(511, 9);
            this.buttonTargetOpenFile.Name = "buttonTargetOpenFile";
            this.buttonTargetOpenFile.Size = new System.Drawing.Size(37, 23);
            this.buttonTargetOpenFile.TabIndex = 6;
            this.buttonTargetOpenFile.Text = "...";
            this.buttonTargetOpenFile.UseVisualStyleBackColor = true;
            this.buttonTargetOpenFile.Click += new System.EventHandler(this.buttonTargetOpenFile_Click);
            // 
            // comboBoxSearchText
            // 
            this.comboBoxSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchText.FormattingEnabled = true;
            this.comboBoxSearchText.Location = new System.Drawing.Point(158, 61);
            this.comboBoxSearchText.Name = "comboBoxSearchText";
            this.comboBoxSearchText.Size = new System.Drawing.Size(347, 20);
            this.comboBoxSearchText.TabIndex = 5;
            this.comboBoxSearchText.TextUpdate += new System.EventHandler(this.comboBoxCommon_TextUpdate);
            this.comboBoxSearchText.TextChanged += new System.EventHandler(this.comboBoxCommon_TextUpdate);
            // 
            // comboBoxExtensions
            // 
            this.comboBoxExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxExtensions.FormattingEnabled = true;
            this.comboBoxExtensions.Location = new System.Drawing.Point(158, 36);
            this.comboBoxExtensions.Name = "comboBoxExtensions";
            this.comboBoxExtensions.Size = new System.Drawing.Size(347, 20);
            this.comboBoxExtensions.TabIndex = 3;
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Location = new System.Drawing.Point(158, 11);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(347, 20);
            this.comboBoxTarget.TabIndex = 1;
            this.comboBoxTarget.TextUpdate += new System.EventHandler(this.comboBoxCommon_TextUpdate);
            this.comboBoxTarget.TextChanged += new System.EventHandler(this.comboBoxCommon_TextUpdate);
            // 
            // labelSearchText
            // 
            this.labelSearchText.AutoSize = true;
            this.labelSearchText.Location = new System.Drawing.Point(8, 64);
            this.labelSearchText.Name = "labelSearchText";
            this.labelSearchText.Size = new System.Drawing.Size(86, 12);
            this.labelSearchText.TabIndex = 4;
            this.labelSearchText.Text = "Search Text (&S)";
            // 
            // labelExtensions
            // 
            this.labelExtensions.AutoSize = true;
            this.labelExtensions.Location = new System.Drawing.Point(8, 39);
            this.labelExtensions.Name = "labelExtensions";
            this.labelExtensions.Size = new System.Drawing.Size(117, 12);
            this.labelExtensions.TabIndex = 2;
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
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarSearchProgress,
            this.toolStripStatusLabelSearchState});
            this.statusStripMain.Location = new System.Drawing.Point(0, 125);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(564, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // toolStripProgressBarSearchProgress
            // 
            this.toolStripProgressBarSearchProgress.Name = "toolStripProgressBarSearchProgress";
            this.toolStripProgressBarSearchProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabelSearchState
            // 
            this.toolStripStatusLabelSearchState.Name = "toolStripStatusLabelSearchState";
            this.toolStripStatusLabelSearchState.Size = new System.Drawing.Size(0, 17);
            // 
            // contextMenuStripTargetSelect
            // 
            this.contextMenuStripTargetSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSelectFile,
            this.toolStripMenuItemSelectDirectory});
            this.contextMenuStripTargetSelect.Name = "contextMenuStripTargetSelect";
            this.contextMenuStripTargetSelect.Size = new System.Drawing.Size(142, 48);
            // 
            // toolStripMenuItemSelectFile
            // 
            this.toolStripMenuItemSelectFile.Name = "toolStripMenuItemSelectFile";
            this.toolStripMenuItemSelectFile.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItemSelectFile.Text = "File (&F)";
            this.toolStripMenuItemSelectFile.Click += new System.EventHandler(this.toolStripMenuItemSelectFile_Click);
            // 
            // toolStripMenuItemSelectDirectory
            // 
            this.toolStripMenuItemSelectDirectory.Name = "toolStripMenuItemSelectDirectory";
            this.toolStripMenuItemSelectDirectory.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItemSelectDirectory.Text = "Directory (&D)";
            this.toolStripMenuItemSelectDirectory.Click += new System.EventHandler(this.toolStripMenuItemSelectDirectory_Click);
            // 
            // backgroundWorkerSearch
            // 
            this.backgroundWorkerSearch.WorkerReportsProgress = true;
            this.backgroundWorkerSearch.WorkerSupportsCancellation = true;
            this.backgroundWorkerSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSearch_DoWork);
            this.backgroundWorkerSearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSearch_ProgressChanged);
            this.backgroundWorkerSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSearch_RunWorkerCompleted);
            // 
            // toolStripMenuItemToolClearCaches
            // 
            this.toolStripMenuItemToolClearCaches.Name = "toolStripMenuItemToolClearCaches";
            this.toolStripMenuItemToolClearCaches.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemToolClearCaches.Text = "Clear Caches(&C)";
            this.toolStripMenuItemToolClearCaches.Click += new System.EventHandler(this.toolStripMenuItemToolClearCaches_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 171);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(16, 210);
            this.Name = "FormMain";
            this.Text = "X-Grepper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.contextMenuStripTargetSelect.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTool;
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
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSearchState;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarSearchProgress;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTargetSelect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSelectFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSelectDirectory;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemToolClearCaches;
    }
}

