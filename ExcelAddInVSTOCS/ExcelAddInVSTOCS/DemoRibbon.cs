using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Serilog;
using ExcelAddInVSTOCS.Storage;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelAddInVSTOCS
{
    public partial class DemoRibbon
    {
        private void DemoRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        /// <summary>
        /// 显示切换 任务面板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 搜索工作表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClickFindSheetButton(object sender, RibbonControlEventArgs e)
        {
            var t = findSheetEditBox.Text;
            List<string> result = new List<string>();
            foreach (Excel.Worksheet ws in Globals.ThisAddIn.Application.Worksheets)
            {
                Log.Information($"工作表: {ws.Name}");
                if (ws.Name.Contains(findSheetEditBox.Text))
                {
                    result.Add(ws.Name);
                    Log.Information($"工作表: {ws.Name} 匹配：{findSheetEditBox.Text}");
                    foreach (Excel.Range r in ws.UsedRange)
                    {
                        Log.Information($"{r.Address} => {r.Value}");
                    }
                }
            }
            findSheetTipLabel.Label = string.Join(",", result);
        }

        /// <summary>
        /// 创建工作表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClickNewSheetButton(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet ws = null;
            try
            {
                ws = Globals.ThisAddIn.Application.Worksheets.Add() as Excel.Worksheet;
                ws.Name = newSheetEditBox.Text;
                var a1 = ws.Range["A1"];
                a1.Value = "信息1";
                var b1 = ws.Range["B1"];
                b1.Value = "信息2";
                newSheetTipLabel.Label = $"工作表：{newSheetEditBox.Text} 创建成功";
            }
            catch (COMException ex)
            {
                if (ws != null)
                {
                    ws.Delete();
                    Log.Information($"异常：{ex.Message}，清理创建一半的工作表：{newSheetEditBox.Text}");
                }
                newSheetTipLabel.Label = ex.Message;
            }
        }


        /// <summary>
        /// 扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClickScanButton(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet as Excel.Worksheet;
            Log.Information("开始扫描");
            for (int i = 1; i <= 1000 ; ++i)
            {
                var p = $"A{i}";
                var r = ws.Range[p];
                if (r.Value is null)
                {
                    break;
                }
                Log.Information("{0}: {1}", p, r.Value);
                Log.Information("Address: {0}", r.Address);
                Log.Information("AddressLocal: {0}", r.AddressLocal);
                Log.Information("Row: {0}, Column: {1}", r.Row, r.Column);
                Log.Information("Right: {0}, Bottom: {1}", r.Column + r.Columns.Count -1 ,r.Row + r.Rows.Count - 1);
            }
        }


        /// <summary>
        /// 测试。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClickTestButton(object sender, RibbonControlEventArgs e)
        {
            var ws = Globals.ThisAddIn.Application.ActiveSheet as Excel.Worksheet;
            // 选中区域
            var r = ws.Range[
                ws.Cells[2, 2],
                ws.Cells[6, 6]
            ];
            r.Select();
        }

        private void onClickGetSelection(object sender, RibbonControlEventArgs e)
        {
            var r = Globals.ThisAddIn.Application.Selection as Excel.Range;
            tipLabel.Label = r.Address;
        }
    }
}
