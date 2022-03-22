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
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelAddInVSTOCS
{
    public partial class DemoTaskPaneWF : UserControl
    {
        public Excel.Application Application;
        private DemoWorksheetEditor worksheetEditor;
        private ElementHost wpfUserControl;

        public DemoTaskPaneWF(Excel.Application application)
        {
            Application = application;
            worksheetEditor = new DemoWorksheetEditor();
            InitializeComponent();
            wpfUserControl = InitWPFUserControl();
            wpfPanel.Controls.Add(wpfUserControl);
        }

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
            worksheetEditor.Scan(Application.ActiveSheet as Excel.Worksheet);
        }
    }
}
