using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Serilog;
using ExcelAddInVSTOCS.Storage;

namespace ExcelAddInVSTOCS
{
    public partial class DemoRibbon
    {
        private void DemoRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void onClickRibbonVisiableButton(object sender, RibbonControlEventArgs e)
        {
            var c = sender as RibbonToggleButton;
            Log.Information($"toggle: {c.Checked}");
            var wfn = Globals.ThisAddIn.Application.ActiveWorkbook.FullName;
            var dtp = DemoTaskPaneWF.Find(wfn);
            if (dtp != null)
            {
                dtp.WorkbookTaskPane.Visible = c.Checked;
                Log.Information($"面板显示切换：{wfn} => {c.Checked}");
            }
            var habit = UserHabit.Load(wfn);
            habit.UpdateAt = DateTime.Now;
            habit.VisiableTaskPane = c.Checked;
            habit.Save(wfn);
        }
    }
}
