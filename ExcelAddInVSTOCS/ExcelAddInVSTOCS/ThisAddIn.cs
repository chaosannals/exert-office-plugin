using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools.Excel.Controls;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using System.Windows.Forms.Integration;


namespace ExcelAddInVSTOCS
{
    public partial class ThisAddIn
    {
        private CustomTaskPane demoTaskPaneWF;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Application.WorkbookBeforeSave += Application_WorkbookBeforeSave;
            InitWinFormTaskPane();
        }

        private CustomTaskPane InitWinFormTaskPane()
        {
            var dtpwf = new DemoTaskPaneWF();
            var host = InitWPFTaskPane();
            dtpwf.Controls.Add(host);
            demoTaskPaneWF = CustomTaskPanes.Add(dtpwf, "一个WinForm 任务窗口");
            demoTaskPaneWF.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionLeft;
            demoTaskPaneWF.Visible = true;
            return demoTaskPaneWF;
        }

        private ElementHost InitWPFTaskPane()
        {
            ElementHost host = new ElementHost();
            host.Dock = DockStyle.Fill;
            var dtpwpf = new DemoTaskPaneWPF();
            host.Child = dtpwpf;
            return host;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        void Application_WorkbookBeforeSave(Excel.Workbook Wb, bool SaveAsUI, ref bool Cancel)
        {
            Excel.Worksheet activeWorksheet = Application.ActiveSheet as Excel.Worksheet;
            Excel.Range firstRow = activeWorksheet.Range["A1"];
            firstRow.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown);
            Excel.Range newFirstRow = activeWorksheet.Range["A1"];
            newFirstRow.Value2 = "This text was added by using code";

            Excel.Range br = activeWorksheet.Range["A3"];
            Worksheet ws = Globals.Factory.GetVstoObject(activeWorksheet);
            ws.Controls.AddButton(br, "I'm button");
        }

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
