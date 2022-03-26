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
using System.IO;
using System.Windows.Forms;
using Serilog;
using FreeSql;
using ExcelAddInVSTOCS.Storage;

namespace ExcelAddInVSTOCS
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Application.WorkbookBeforeSave += Application_WorkbookBeforeSave;
            Application.WorkbookOpen += Application_WorkbookOpen;
            Application.WorkbookBeforeClose += Application_WorkbookBeforeClose;
            Application.WorkbookActivate += Application_WorkbookActivate;
        }

        private void Application_WorkbookActivate(Excel.Workbook wb)
        {
            var wfn = Application.ActiveWorkbook.FullName;
            var habit = UserHabit.Load(wfn);
            Log.Information("加载用户习惯：{0}", habit);
            Globals.Ribbons.DemoRibbon.visiableToggleButton.Checked = habit.VisiableTaskPane;
        }

        private void Application_WorkbookOpen(Excel.Workbook wb)
        {
            var habit = UserHabit.Load(wb.FullName);
            var dtp = new DemoTaskPaneWF(wb.FullName, "一个WinForm 任务窗口");
            dtp.WorkbookTaskPane.Visible = habit.VisiableTaskPane;
        }

        private void Application_WorkbookBeforeClose(Excel.Workbook wb, ref bool cancel)
        {
            if (!cancel)
            {
                DemoTaskPaneWF.Drop(wb.FullName);
            }
        }

        /// <summary>
        /// 卸载时刷新日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            Log.Information("日志落盘");
            Log.CloseAndFlush();
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
