namespace ExcelAddInVSTOCS
{
    partial class DemoTaskPaneWF
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rootLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.wpfPanel = new System.Windows.Forms.Panel();
            this.wfLabel = new System.Windows.Forms.Label();
            this.scanWorksheetButton = new System.Windows.Forms.Button();
            this.addinDirLabel = new System.Windows.Forms.Label();
            this.rootLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootLayoutPanel
            // 
            this.rootLayoutPanel.ColumnCount = 6;
            this.rootLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rootLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rootLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rootLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rootLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rootLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rootLayoutPanel.Controls.Add(this.wpfPanel, 0, 3);
            this.rootLayoutPanel.Controls.Add(this.wfLabel, 0, 0);
            this.rootLayoutPanel.Controls.Add(this.scanWorksheetButton, 4, 0);
            this.rootLayoutPanel.Controls.Add(this.addinDirLabel, 0, 1);
            this.rootLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.rootLayoutPanel.Name = "rootLayoutPanel";
            this.rootLayoutPanel.RowCount = 6;
            this.rootLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayoutPanel.Size = new System.Drawing.Size(260, 417);
            this.rootLayoutPanel.TabIndex = 0;
            // 
            // wpfPanel
            // 
            this.rootLayoutPanel.SetColumnSpan(this.wpfPanel, 6);
            this.wpfPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpfPanel.Location = new System.Drawing.Point(3, 44);
            this.wpfPanel.Name = "wpfPanel";
            this.rootLayoutPanel.SetRowSpan(this.wpfPanel, 3);
            this.wpfPanel.Size = new System.Drawing.Size(254, 382);
            this.wpfPanel.TabIndex = 0;
            // 
            // wfLabel
            // 
            this.wfLabel.AutoSize = true;
            this.wfLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfLabel.Location = new System.Drawing.Point(3, 0);
            this.wfLabel.Name = "wfLabel";
            this.wfLabel.Size = new System.Drawing.Size(47, 29);
            this.wfLabel.TabIndex = 1;
            this.wfLabel.Text = "WinForm";
            // 
            // scanWorksheetButton
            // 
            this.scanWorksheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scanWorksheetButton.Location = new System.Drawing.Point(149, 3);
            this.scanWorksheetButton.Name = "scanWorksheetButton";
            this.scanWorksheetButton.Size = new System.Drawing.Size(75, 23);
            this.scanWorksheetButton.TabIndex = 2;
            this.scanWorksheetButton.Text = "扫描";
            this.scanWorksheetButton.UseVisualStyleBackColor = true;
            this.scanWorksheetButton.Click += new System.EventHandler(this.onClickScanWorksheetButton);
            // 
            // addinDirLabel
            // 
            this.addinDirLabel.AutoSize = true;
            this.rootLayoutPanel.SetColumnSpan(this.addinDirLabel, 6);
            this.addinDirLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addinDirLabel.Location = new System.Drawing.Point(3, 29);
            this.addinDirLabel.Name = "addinDirLabel";
            this.addinDirLabel.Size = new System.Drawing.Size(254, 12);
            this.addinDirLabel.TabIndex = 3;
            this.addinDirLabel.Text = ":";
            // 
            // DemoTaskPaneWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rootLayoutPanel);
            this.Name = "DemoTaskPaneWF";
            this.Size = new System.Drawing.Size(260, 417);
            this.rootLayoutPanel.ResumeLayout(false);
            this.rootLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rootLayoutPanel;
        private System.Windows.Forms.Panel wpfPanel;
        private System.Windows.Forms.Label wfLabel;
        private System.Windows.Forms.Button scanWorksheetButton;
        private System.Windows.Forms.Label addinDirLabel;
    }
}
