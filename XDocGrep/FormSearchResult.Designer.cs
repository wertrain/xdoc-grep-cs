﻿namespace XDocGrep
{
    partial class FormSearchResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchResult));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.listViewSearchResult = new System.Windows.Forms.ListView();
            this.columnHeaderText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.listViewSearchResult, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // listViewSearchResult
            // 
            this.listViewSearchResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderText,
            this.columnHeaderFileName});
            this.listViewSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSearchResult.FullRowSelect = true;
            this.listViewSearchResult.HideSelection = false;
            this.listViewSearchResult.Location = new System.Drawing.Point(3, 3);
            this.listViewSearchResult.Name = "listViewSearchResult";
            this.listViewSearchResult.Size = new System.Drawing.Size(794, 444);
            this.listViewSearchResult.TabIndex = 0;
            this.listViewSearchResult.UseCompatibleStateImageBehavior = false;
            this.listViewSearchResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderText
            // 
            this.columnHeaderText.Text = "位置";
            this.columnHeaderText.Width = 463;
            // 
            // columnHeaderFileName
            // 
            this.columnHeaderFileName.Text = "ファイル名";
            this.columnHeaderFileName.Width = 224;
            // 
            // FormSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSearchResult";
            this.Text = "Search Result";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.ListView listViewSearchResult;
        private System.Windows.Forms.ColumnHeader columnHeaderText;
        private System.Windows.Forms.ColumnHeader columnHeaderFileName;
    }
}