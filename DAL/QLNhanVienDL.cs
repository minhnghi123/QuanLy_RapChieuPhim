using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLNhanVienDL
    {
        DataTable nhanvien;
        DataTable nhanvienkethop;
        DataHelper dt = DataHelper.GetInstance();
        public QLNhanVienDL()
        {
            nhanvien = dt.FillDataTable("select * from NguoiDung");
        }
        
        public DataTable LayNhanvienbt()
        {
            
            nhanvien = dt.FillDataTable("select * from NguoiDung");
            return nhanvien;
        }
        public bool ThemmoiNhanVien(DataRow dr)
        {
            try
            {
               
                dt.InsertRowtable(nhanvien, dr.ItemArray);
                dt.UpdateFromDataTableToDataBase("NguoiDung", nhanvien);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;

            }
        }
        public bool XoaNhanvien(int MaNV)
        {
            try
            {
                dt.DeleteRowTable(nhanvien, "MaNguoiDung  = " + MaNV);
                dt.UpdateFromDataTableToDataBase("NguoiDung", nhanvien);
                return true;
            }
            catch (Exception ex1)
            {
                throw ex1;
                return false;

            }
        }
        public bool SuaNhanVien(DataRow dr)
        {
            try
            {
                var s = dr.ItemArray;
                String dk = " MaNguoiDung  = " + dr["MaNguoiDung"];

               dt.UpdateRowTable(nhanvien, dk, "HoTen", dr["HoTen"], "Email", dr["Email"], "SDT", dr["SDT"], "DiaChi", dr["DiaChi"]);

                dt.UpdateFromDataTableToDataBase("NguoiDung", nhanvien);
                return true;
            }
            catch (Exception ex1)
            {
                throw ex1;
                return false;

            }
        }
    }
}
