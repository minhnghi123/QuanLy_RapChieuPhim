using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.SqlClient;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Windows.Forms;
using System.IO;

namespace GUII
{
    class XuatExecl
    {

        public static void exportecxel(DataGridView g, string duongdan, string tenfile)
        {
            duongdan = @"";
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value;
                    }
                }
            obj.Range["A1", "M100"].Font.Name = "Times New Roman";
            obj.Range["A1", "M100"].HorizontalAlignment = 3;
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenfile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
            //obj.Quit();
        }


        public static void export_phieu(DataGridView g, string duongdan, string tenfile)
        {
            // Khởi tạo đường dẫn đầy đủ
            duongdan = "C:\\Users\\hophu\\Downloads\\CLONE\\CLONE\\QuanLy_RapChieuPhim\\excel\\ThongTinPhieu";
            string fullPath = Path.Combine(duongdan, tenfile + ".xlsx");

            app obj = new app();
            obj.Application.Workbooks.Add(); // Kiểm tra thứ tự các tham số
            obj.Columns.ColumnWidth = 25;

            for (int i = 1; i < g.Columns.Count ; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count-1; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value;
                    }
                }
            }

            obj.Cells[g.Rows.Count + 2, g.Columns.Count - 1] = "Số lượng : ";

            obj.Range["A1", "M100"].Font.Name = "Times New Roman";
            obj.Range["A1", "M100"].HorizontalAlignment = 3;

            obj.ActiveWorkbook.SaveCopyAs(fullPath);
            obj.ActiveWorkbook.Saved = true;
            obj.Quit(); // Gỡ comment để thoát ứng dụng Excel sau khi lưu file
        }


        public static void nhapnhieu(DataGridView g, string duongdan, string tenfile, string s, string tile, string chietkhau)
        {
            duongdan = @"";
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;



            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value;
                    }
                }
            obj.Cells[g.Rows.Count + 2, g.Columns.Count - 1] = "Chiếu khấu : ";
            obj.Cells[g.Rows.Count + 2, g.Columns.Count] = " " + chietkhau + " %";
            obj.Cells[g.Rows.Count + 3, g.Columns.Count - 1] = "Tổng Tiền : ";
            obj.Cells[g.Rows.Count + 3, g.Columns.Count] = " " + s;
            obj.Range["A1", "M100"].Font.Name = "Times New Roman";
            obj.Range["A1", "M100"].HorizontalAlignment = 3;
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenfile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
            //obj.Quit();
        }
    }
}
