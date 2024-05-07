using OpenLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuatChieuDL
    {
        DataHelper dt = DataHelper.GetInstance();
        DataTable suatchieu;
        public DataTable getSuatChieu()
        { 
            suatchieu = dt.FillDataTable("select* from Suatchieu");
            return suatchieu;
            }
        public bool inserSuatChieu(DataRow dr)
        {
           try
            {
                string sql = "insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (" + dr[1] + "," + dr[2] + ",'" + dr[3] + "'," + dr[4] + ")";
                dt.ExecuteNonQuery(sql, null);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
        public bool updateSuatChieu(DataRow dr)
        {
            try
            {
                string dk = "MaSuatChieu = " +dr[0] ;
             
                dt.UpdateRowTableDungThuTuCotCoKieutudongtang(suatchieu, dk,0, dr.ItemArray);

                dt.UpdateFromDataTableToDataBase("Suatchieu", suatchieu);

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
                string sql = "delete FROM  suatchieu where MaSuatChieu =" +masuachieu ;
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
