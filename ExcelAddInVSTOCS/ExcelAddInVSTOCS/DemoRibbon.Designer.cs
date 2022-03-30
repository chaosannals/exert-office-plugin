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
            this.label1 = this.Factory.CreateRibbonLabel();
            this.ribbonDemoTab123456789 = this.Factory.CreateRibbonTab();
            this.settingGroup = this.Factory.CreateRibbonGroup();
            this.visiableToggleButton = this.Factory.CreateRibbonToggleButton();
            this.actionGroup = this.Factory.CreateRibbonGroup();
            this.findSheetEditBox = this.Factory.CreateRibbonEditBox();
            this.findSheetButton = this.Factory.CreateRibbonButton();
            this.findSheetTipLabel = this.Factory.CreateRibbonLabel();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.newSheetEditBox = this.Factory.CreateRibbonEditBox();
            this.newSheetButton = this.Factory.CreateRibbonButton();
            this.newSheetTipLabel = this.Factory.CreateRibbonLabel();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.buttonGroup = this.Factory.CreateRibbonButtonGroup();
            this.selectionButton = this.Factory.CreateRibbonButton();
            this.testButton = this.Factory.CreateRibbonButton();
            this.scanButton = this.Factory.CreateRibbonButton();
            this.tipLabel = this.Factory.CreateRibbonLabel();
            this.ribbonTab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.ribbonDemoTab123456789.SuspendLayout();
            this.settingGroup.SuspendLayout();
            this.actionGroup.SuspendLayout();
            this.buttonGroup.SuspendLayout();
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
            // label1
            // 
            this.label1.Label = "内置 tab ID 无法改动示例会扰乱";
            this.label1.Name = "label1";
            // 
            // ribbonDemoTab123456789
            // 
            this.ribbonDemoTab123456789.Groups.Add(this.settingGroup);
            this.ribbonDemoTab123456789.Groups.Add(this.actionGroup);
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
            // actionGroup
            // 
            this.actionGroup.Items.Add(this.findSheetEditBox);
            this.actionGroup.Items.Add(this.findSheetButton);
            this.actionGroup.Items.Add(this.findSheetTipLabel);
            this.actionGroup.Items.Add(this.separator1);
            this.actionGroup.Items.Add(this.newSheetEditBox);
            this.actionGroup.Items.Add(this.newSheetButton);
            this.actionGroup.Items.Add(this.newSheetTipLabel);
            this.actionGroup.Items.Add(this.separator2);
            this.actionGroup.Items.Add(this.buttonGroup);
            this.actionGroup.Items.Add(this.tipLabel);
            this.actionGroup.Label = "功能";
            this.actionGroup.Name = "actionGroup";
            // 
            // findSheetEditBox
            // 
            this.findSheetEditBox.Label = "搜索关键字：";
            this.findSheetEditBox.Name = "findSheetEditBox";
            this.findSheetEditBox.Text = null;
            // 
            // findSheetButton
            // 
            this.findSheetButton.Label = "搜索";
            this.findSheetButton.Name = "findSheetButton";
            this.findSheetButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.onClickFindSheetButton);
            // 
            // findSheetTipLabel
            // 
            this.findSheetTipLabel.Label = ":";
            this.findSheetTipLabel.Name = "findSheetTipLabel";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // newSheetEditBox
            // 
            this.newSheetEditBox.Label = "创建工作表名：";
            this.newSheetEditBox.Name = "newSheetEditBox";
            this.newSheetEditBox.Text = null;
            // 
            // newSheetButton
            // 
            this.newSheetButton.Label = "创建";
            this.newSheetButton.Name = "newSheetButton";
            this.newSheetButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.onClickNewSheetButton);
            // 
            // newSheetTipLabel
            // 
            this.newSheetTipLabel.Label = ":";
            this.newSheetTipLabel.Name = "newSheetTipLabel";
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            // 
            // buttonGroup
            // 
            this.buttonGroup.Items.Add(this.selectionButton);
            this.buttonGroup.Items.Add(this.testButton);
            this.buttonGroup.Items.Add(this.scanButton);
            this.buttonGroup.Name = "buttonGroup";
            // 
            // selectionButton
            // 
            this.selectionButton.Label = "获取选中范围";
            this.selectionButton.Name = "selectionButton";
            this.selectionButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.onClickGetSelection);
            // 
            // testButton
            // 
            this.testButton.Label = "测试";
            this.testButton.Name = "testButton";
            this.testButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.onClickTestButton);
            // 
            // scanButton
            // 
            this.scanButton.Label = "扫描";
            this.scanButton.Name = "scanButton";
            this.scanButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.onClickScanButton);
            // 
            // tipLabel
            // 
            this.tipLabel.Label = "：";
            this.tipLabel.Name = "tipLabel";
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
            this.actionGroup.ResumeLayout(false);
            this.actionGroup.PerformLayout();
            this.buttonGroup.ResumeLayout(false);
            this.buttonGroup.PerformLayout();
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
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup actionGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox findSheetEditBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton findSheetButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox newSheetEditBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton newSheetButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel newSheetTipLabel;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel findSheetTipLabel;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton scanButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton testButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton selectionButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel tipLabel;
    }

    partial class ThisRibbonCollection
    {
        internal DemoRibbon DemoRibbon
        {
            get { return this.GetRibbon<DemoRibbon>(); }
        }
    }
}
