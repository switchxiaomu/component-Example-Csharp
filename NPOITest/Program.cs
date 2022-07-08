using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPOITest
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"f:\test.xlsx";

            //HSSFWorkbook workbook;
            XSSFWorkbook workbook;
            using (FileStream stream = File.OpenRead(fileName))
                //workbook = new HSSFWorkbook(stream);
                workbook = new XSSFWorkbook(stream);

            ISheet sheet = workbook.CreateSheet("菜鸟4");
            IRow row = sheet.CreateRow(0);
            ICell cell = row.CreateCell(0);
            cell.SetCellValue($"第0行 第0列");

            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
                workbook.Write(fs);
        }
    }
}
