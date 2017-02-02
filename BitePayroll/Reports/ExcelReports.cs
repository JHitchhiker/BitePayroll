using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BitePayroll.Data;
using System.IO;

namespace BitePayroll
{
    public static class ExcelReports
    {
        public static void CXCReport()
        {
            if (File.Exists(@"c:\reports\cxcreport.xls"))
            {
                File.Delete(@"c:\reports\cxcreport.xls");
            }
            
            var xlApp = new Excel.Application();
            xlApp.Workbooks.Add();
            Excel._Workbook wb = xlApp.ActiveWorkbook;
            var workSheet = wb.ActiveSheet;
            DataTable dt = new ReportRepository().CXCReport(GlobalValues.Instance.CurrentMonth);

            for (var i = 0; i < dt.Columns.Count; i++)
            {
                workSheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
            }
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                for (var j = 0; j < dt.Columns.Count; j++)
                {
                    workSheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                }
            }
            wb.SaveAs(@"c:\reports\cxcreport.xls");
            xlApp.Quit();
        }

        public static void BitePayroll()
        {
            if (File.Exists(@"c:\reports\bitepayroll.xls"))
            {
                File.Delete(@"c:\reports\bitepayroll.xls");
            }

            var xlApp = new Excel.Application();
            xlApp.Workbooks.Add();
            Excel._Workbook wb = xlApp.ActiveWorkbook;
            var workSheet = wb.ActiveSheet;
            DataTable dt = new ReportRepository().BitePayroll(GlobalValues.Instance.CurrentMonth);

            for (var i = 0; i < dt.Columns.Count; i++)
            {
                workSheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
            }
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                for (var j = 0; j < dt.Columns.Count; j++)
                {
                    workSheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                }
            }
            wb.SaveAs(@"c:\reports\bitepayroll.xls");
            xlApp.Quit();
        }
    }
}
