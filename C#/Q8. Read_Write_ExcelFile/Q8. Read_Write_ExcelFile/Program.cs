//WAP to  Read and Write from an Excel file (Microsoft Excel/Open office) 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel; //Add This References


namespace Q8.Read_Write_ExcelFile
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Step 1: Add the references from the COM library (Microsoft 16.0 Excel Object Library)
            //Step 2: Using Microsoft.Office.Interop.Excel;

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\User\OneDrive - Asia Pacific University\Desktop\Doc Net\Practical Assignments\C#\Q8. Read_Write_ExcelFile\Q8. Read_Write_ExcelFile\bin\Debug\SampleExcelFile.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    //Display new row whenever column=1
                    if (j == 1)
                        Console.Write("\r\n");

                    //Display Value
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");  
                }
            }

            
            //close,quit and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            Console.ReadKey();
        }
    }
}
