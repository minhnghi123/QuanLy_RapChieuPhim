
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhongChieuDL
    {
        DataHelper dt = DataHelper.GetInstance();
        DataTable Phim = new DataTable();
        DataTable PhimDangChieu = new DataTable();
        DataTable RapChieu = new DataTable();
        public DataTable getPhong()
        {
            PhimDangChieu = dt.FillDataTable("select* from PhongChieu");
            return PhimDangChieu;
        }
        public DataTable getRap()
        {
            RapChieu = dt.FillDataTable("select* from RapChieu");
            return RapChieu;
        }
        public bool inserSuatChieu(DataRow dr)
        {
            try
            {
                string sql = "insert into PhongChieu (MaRapChieu, SoGhe)  values (" + dr[1] + "," + 0 + ")";
                dt.ExecuteNonQuery(sql, null);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool updateSuatChieu(DataRow dr)
        {
            try
            {
                string dk = "MaPhongChieu  = " + dr[0];

                dt.UpdateRowTableDungThuTuCotCoKieutudongtang(PhimDangChieu, dk, 0, dr.ItemArray);

                dt.UpdateFromDataTableToDataBase("PhongChieu", PhimDangChieu);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool xoa(string masuachieu)
        {
            try
            {
                string sql = "delete FROM  PhongChieu   where MaPhongChieu  =" + masuachieu;
                dt.ExecuteNonQuery(sql, null);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
