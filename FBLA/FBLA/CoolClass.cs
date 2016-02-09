using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLA {
    class CoolClass {
        public static void MakeMeAnExcel() {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afrea\\Documents\\GitHub\\FblaSignIn\\FBLA\\FBLA\\fbla.mdf;Integrated Security=True");
            con.Open();

            try {
                using (var package = new ExcelPackage(new FileInfo(@"C:\Users\afrea\Desktop\test.xlsx")))
                using (var command = new SqlCommand("SELECT * FROM dbo.Users", con))
                using (var reader = command.ExecuteReader()) {
                    package.Workbook.Worksheets.Add("FBLA Students");
                    var ws = package.Workbook.Worksheets[1];
                    ws.Name = "FBLA Students";
                    ws.Cells.Style.Font.Size = 10;
                    ws.Cells.Style.Font.Name = "Callibri";

                    ws.Cells[1, 1].Value = reader.GetName(0);
                    ws.Cells[1, 2].Value = reader.GetName(1);
                    ws.Cells[1, 3].Value = reader.GetName(2);
                    ws.Cells[1, 4].Value = reader.GetName(3);
                    ws.Cells[1, 5].Value = reader.GetName(4);
                    ws.Cells[1, 6].Value = reader.GetName(5);

                    ws.Cells[1, 1].Style.Border.Bottom.Style = ws.Cells[1, 2].Style.Border.Bottom.Style = ws.Cells[1, 3].Style.Border.Bottom.Style = ws.Cells[1, 4].Style.Border.Bottom.Style = ws.Cells[1, 5].Style.Border.Bottom.Style = ws.Cells[1, 6].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
                    ws.Cells[1, 1].Style.HorizontalAlignment = ws.Cells[1, 2].Style.HorizontalAlignment = ws.Cells[1, 3].Style.HorizontalAlignment = ws.Cells[1, 4].Style.HorizontalAlignment = ws.Cells[1, 5].Style.HorizontalAlignment = ws.Cells[1, 6].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Column(1).Width = 4.5;
                    ws.Column(2).Width = 18.86;
                    ws.Column(3).Width = 18.86;
                    ws.Column(4).Width = 16;
                    ws.Column(5).Width = 6.3;
                    ws.Column(6).Width = 18.86;

                    package.Save();
                }
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            con.Close();

            
        }

        
    }
}
