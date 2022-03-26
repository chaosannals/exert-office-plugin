namespace ExcelAddInVSTOCS
{
    partial class DemoRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public DemoRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.ribbonTab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.saveButton = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.ribbonDemoTab123456789 = this.Factory.CreateRibbonTab();
            this.settingGroup = this.Factory.CreateRibbonGroup();
            this.visiableToggleButton = this.Factory.CreateRibbonToggleButton();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.ribbonTab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.ribbonDemoTab123456789.SuspendLayout();
            this.settingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.ribbonTab1.Groups.Add(this.group1);
            this.ribbonTab1.Groups.Add(this.group2);
            this.ribbonTab1.Label = "演示功能区";
            this.ribbonTab1.Name = "ribbonTab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.saveButton);
            this.group1.Label = "演示1组";
            this.group1.Name = "group1";
            // 
            // saveButton
            // 
            this.saveButton.Label = "保存";
            this.saveButton.Name = "saveButton";
            // 
            // group2
            // 
            this.group2.Items.Add(this.label1);
            this.group2.Label = "演示2组";
            this.group2.Name = "group2";
            // 
            // ribbonDemoTab123456789
            // 
            this.ribbonDemoTab123456789.Groups.Add(this.settingGroup);
            this.ribbonDemoTab123456789.Label = "测试功能区";
            this.ribbonDemoTab123456789.Name = "ribbonDemoTab123456789";
            // 
            // settingGroup
            // 
            this.settingGroup.Items.Add(this.visiableToggleButton);
            this.settingGroup.Label = "设置";
            this.settingGroup.Name = "settingGroup";
            // 
            // visiableToggleButton
            // 
            this.visiableToggleButton.Label = "显示";
            this.visiableToggleButton.Name = "visiableToggleButton";
            this.visiableToggleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.onClickRibbonVisiableButton);
            // 
            // label1
            // 
            this.label1.Label = "内置 tab ID 无法改动示例会扰乱";
            this.label1.Name = "label1";
            // 
            // DemoRibbon
            // 
            this.Name = "DemoRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.ribbonTab1);
            this.Tabs.Add(this.ribbonDemoTab123456789);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.DemoRibbon_Load);
            this.ribbonTab1.ResumeLayout(false);
            this.ribbonTab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ribbonDemoTab123456789.ResumeLayout(false);
            this.ribbonDemoTab123456789.PerformLayout();
            this.settingGroup.ResumeLayout(false);
            this.settingGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab ribbonTab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab ribbonDemoTab123456789;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton saveButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup settingGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton visiableToggleButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
    }

    partial class ThisRibbonCollection
    {
        internal DemoRibbon DemoRibbon
        {
            get { return this.GetRibbon<DemoRibbon>(); }
        }
    }
}
