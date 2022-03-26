using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Microsoft.Office.Tools;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace ExcelAddInVSTOCS
{
    public partial class DemoTaskPaneWF : UserControl
    {
        private static Dictionary<string, DemoTaskPaneWF> instances;

        static DemoTaskPaneWF()
        {
            instances = new Dictionary<string, DemoTaskPaneWF>();
        }

        public static DemoTaskPaneWF Find(string wfn)
        {
            if (instances.ContainsKey(wfn))
            {
                return instances[wfn];
            }
            return null;
        }

        public static DemoTaskPaneWF Drop(string wfn)
        {
            if (instances.ContainsKey(wfn))
            {
                var r = instances[wfn];
                instances.Remove(wfn);
                return r;
            }
            return null;
        }

        private DemoWorksheetEditor worksheetEditor;
        private ElementHost wpfUserControl;
        
        public string WorkbookFullName { get; private set; }
        public CustomTaskPane WorkbookTaskPane { get; private set; }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="application"></param>
        public DemoTaskPaneWF(string wfn, string title)
        {
            WorkbookFullName = wfn;
            worksheetEditor = new DemoWorksheetEditor();
            InitializeComponent();
            wpfUserControl = InitWPFUserControl();
            wpfPanel.Controls.Add(wpfUserControl);
            addinDirLabel.Text = AppDomain.CurrentDomain.BaseDirectory;
            WorkbookTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(this, title);
            WorkbookTaskPane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionLeft;
            instances.Add(wfn, this);
        }

        /// <summary>
        /// 承载 WPF 的控件
        /// </summary>
        /// <returns></returns>
        private ElementHost InitWPFUserControl()
        {
            ElementHost host = new ElementHost();
            host.Dock = DockStyle.Fill;
            var dtpwpf = new DemoTaskPaneWPF();
            host.Child = dtpwpf;
            return host;
        }

        private void onClickScanWorksheetButton(object sender, EventArgs e)
        {
            worksheetEditor.Scan(Globals.ThisAddIn.Application.ActiveSheet as Excel.Worksheet);
        }
    }
}
