using ApkDomain.DataModel;
using ApkDomain.DataModel.Entities;
using ApkDomain.DataModel.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Excel = Microsoft.Office.Interop.Excel;

namespace ApK.Service
{
    public class ApkService
    {
        private ApKRepository _repo;


        public ApkService(ApKRepository repo)
        {
            _repo = repo;

        }

        public void readXls()
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\abryngel\Documents\git\APK\ProductsNya.xls");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;            

            
            //excel is not zero based!!
            var count = 0;
            for (int i = 1; i <= rowCount; i++)
            {
                count++;
                var rawItem = new rawItemEntity();
                rawItem.nr = (int)(xlRange.Cells[i, 1].Value2 ?? 0);
                rawItem.Artikelid = (int)(xlRange.Cells[i, 2].Value2 ?? 0);
                rawItem.Varnummer = (int)(xlRange.Cells[i, 3].Value2 ?? 0);

                rawItem.Namn = xlRange.Cells[i, 4].Value2 ?? "";
                rawItem.Namn2 = xlRange.Cells[i, 5].Value2 ?? "";
                rawItem.Prisinklmoms = double.Parse((xlRange.Cells[i, 6].Value2 ?? "0"), System.Globalization.CultureInfo.InvariantCulture);


                rawItem.Pant = double.Parse((xlRange.Cells[i, 7].Value2 ?? "0"), System.Globalization.CultureInfo.InvariantCulture);
                rawItem.Volymiml = double.Parse((xlRange.Cells[i, 8].Value2 ?? "0"), System.Globalization.CultureInfo.InvariantCulture);
                rawItem.PrisPerLiter = double.Parse((xlRange.Cells[i, 9].Value2 ?? "0"), System.Globalization.CultureInfo.InvariantCulture);

                rawItem.Saljstart = DateTime.FromOADate(xlRange.Cells[i, 10].Value2);

                rawItem.Utgatt = xlRange.Cells[i, 11].Value2 == 0d ? false : true;

                rawItem.Varugrupp = xlRange.Cells[i, 12].Value2 ?? "";
                rawItem.Typ = xlRange.Cells[i, 13].Value2 ?? "";
                rawItem.Stil = xlRange.Cells[i, 14].Value2 ?? "";
                rawItem.Forpackning = xlRange.Cells[i, 15].Value2 ?? "";
                rawItem.Forslutning = xlRange.Cells[i, 16].Value2 ?? "";
                rawItem.Ursprung = xlRange.Cells[i, 17].Value2 ?? "";
                rawItem.Ursprunglandnamn = xlRange.Cells[i, 18].Value2 ?? "";
                rawItem.Producent = xlRange.Cells[i, 19].Value2 ?? "";
                rawItem.Leverantor = xlRange.Cells[i, 20].Value2 ?? "";

                rawItem.Argang = (int)(xlRange.Cells[i, 21].Value2 ?? 0);
                rawItem.Provadargang = xlRange.Cells[i, 22].Value2 ?? "";
                rawItem.Alkoholhalt = double.Parse(((xlRange.Cells[i, 23].Value2).Remove(xlRange.Cells[i, 23].Value2.Length - 1) ?? "0"), System.Globalization.CultureInfo.InvariantCulture);
                rawItem.Sortiment = xlRange.Cells[i, 24].Value2 ?? "";
                rawItem.SortimentText = xlRange.Cells[i, 25].Value2 ?? "";
                rawItem.Ekologisk = xlRange.Cells[i, 26].Value2 == 0d ? false : true;
                rawItem.Etiskt = xlRange.Cells[i, 27].Value2 == 0d ? false : true;
                rawItem.EtisktEtikett = xlRange.Cells[i, 28].Value2 ?? "";
                rawItem.Koscher = xlRange.Cells[i, 29].Value2 == 0d ? false : true;
                rawItem.RavarorBeskrivning = xlRange.Cells[i, 30].Value2 ?? "";

                _repo.addItemRaw(rawItem);
                if (count == 200)
                {
                    _repo.save();
                    count = 0;
                }
            }
            _repo.save();
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void makeItemsFromRawItems()
        {
            

            

        }
    }
}