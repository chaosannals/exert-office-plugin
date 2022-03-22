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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.wpfPanel = new System.Windows.Forms.Panel();
            this.wfLabel = new System.Windows.Forms.Label();
            this.scanWorksheetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.wpfPanel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.wfLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.scanWorksheetButton, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // wpfPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.wpfPanel, 6);
            this.wpfPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpfPanel.Location = new System.Drawing.Point(3, 32);
            this.wpfPanel.Name = "wpfPanel";
            this.tableLayoutPanel1.SetRowSpan(this.wpfPanel, 3);
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
            this.scanWorksheetButton.Location = new System.Drawing.Point(110, 3);
            this.scanWorksheetButton.Name = "scanWorksheetButton";
            this.scanWorksheetButton.Size = new System.Drawing.Size(75, 23);
            this.scanWorksheetButton.TabIndex = 2;
            this.scanWorksheetButton.Text = "扫描";
            this.scanWorksheetButton.UseVisualStyleBackColor = true;
            this.scanWorksheetButton.Click += new System.EventHandler(this.onClickScanWorksheetButton);
            // 
            // DemoTaskPaneWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DemoTaskPaneWF";
            this.Size = new System.Drawing.Size(260, 417);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel wpfPanel;
        private System.Windows.Forms.Label wfLabel;
        private System.Windows.Forms.Button scanWorksheetButton;
    }
}
