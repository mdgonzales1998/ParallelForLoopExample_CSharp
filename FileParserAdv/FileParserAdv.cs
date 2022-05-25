using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;
using Contracts;

namespace FileParserAdv
{
    public class FileParser
    {
        public List<CustomerOrders> ReadFile(string path)
        {
            Excel.Application xlApp;
            Excel.Workbook wb;
            Excel.Worksheet ws;
            Excel.Range range;
            int rCnt;
            int cCnt;
            Object obj;
            List<CustomerOrders> coList = new List<CustomerOrders>();

            try
            {
                xlApp = new Excel.Application();
                wb = xlApp.Workbooks.Open(path);
                ws = wb.Worksheets[1];

                range = ws.UsedRange;

                for (rCnt = 2; rCnt <= range.Rows.Count; rCnt++)
                {
                    CustomerOrders cusOrder = new CustomerOrders();

                    cusOrder.CustomerID = ((Excel.Range)range.Cells[rCnt, 1]).Value;
                    cusOrder.CompanyName = ((Excel.Range)range.Cells[rCnt, 2]).Value;
                    cusOrder.ContactName = ((Excel.Range)range.Cells[rCnt, 3]).Value;
                    cusOrder.ContactTitle = ((Excel.Range)range.Cells[rCnt, 4]).Value;
                    cusOrder.Customers_Address = ((Excel.Range)range.Cells[rCnt, 5]).Value;
                    cusOrder.Customers_City = ((Excel.Range)range.Cells[rCnt, 6]).Value;
                    cusOrder.Customers_Region = ((Excel.Range)range.Cells[rCnt, 7]).Value;
                    cusOrder.Customers_PostalCode = ((Excel.Range)range.Cells[rCnt, 8]).Value.ToString();
                    cusOrder.Customers_Country = ((Excel.Range)range.Cells[rCnt, 9]).Value;
                    cusOrder.Customers_Phone = ((Excel.Range)range.Cells[rCnt, 10]).Value;
                    cusOrder.Customers_Fax = ((Excel.Range)range.Cells[rCnt, 11]).Value;

                    coList.Add(cusOrder);
                }

                wb.Close();
                xlApp.Quit();

                ReleaseObject(xlApp);
                ReleaseObject(wb);
                ReleaseObject(ws);
            }
            catch (Exception)
            {

                throw;
            }

            return coList;
        }

        private void ReleaseObject(Object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
                throw;
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
