using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using Serilog;

namespace ExcelAddInVSTOCS
{
    public class DemoWorksheetEditor
    {
        public void Scan(Excel.Worksheet worksheet)
        {
            Log.Information("Cells:");
            foreach (Excel.Range c in worksheet.UsedRange)
            {
                Log.Information($"{c.Address} {c.Value}");
            }
        }
    }
}
