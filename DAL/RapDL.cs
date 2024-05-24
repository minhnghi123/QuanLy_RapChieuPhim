
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RapDL
    {
        DataHelper dt = DataHelper.GetInstance();
        DataTable rapchieu = new DataTable();
        public DataTable getRapChieu()
        {
            rapchieu = dt.FillDataTable("select* from RapChieu");
            return rapchieu;
        }
        public bool inserRap(DataRow dr)
        {
            try
            {
                string sql = "insert into rapchieu (MaRapChieu,TenRap,DiaChi) values (" + dr[1] + "," + dr[2] + ",'" + dr[3] + ")";
                dt.ExecuteNonQuery(sql, null);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool updateRap(DataRow dr)
        {
            try
            {
                string dk = "MaRapChieu = " + dr[0];

                dt.UpdateRowTableDungThuTuCotCoKieutudongtang(rapchieu, dk, 0, dr.ItemArray);

                dt.UpdateFromDataTableToDataBase("RapChieu", rapchieu);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool deleteRap(string marapchieu)
        {
            try
            {
                string sql = "delete FROM  suatchieu where MaRapChieu =" + marapchieu;
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
