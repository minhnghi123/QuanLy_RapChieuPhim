using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using OpenLibrary.DataAccess;

namespace BLL
{
    public class CtrQLNhanVien
    {   QLNhanVienDL cn=new QLNhanVienDL();
        ChiNhanhDL cn1 = new ChiNhanhDL();
        LoaiNhanVienDL cn2 = new LoaiNhanVienDL();
       
        public DataTable laydsNhanVien()
        {
            return cn.LayNhanvienbt();
        }
        public DataTable laydsNhanVienbt()
        {
            return cn.LayNhanvienbt();
        }
        public DataTable laydsloaiNhanVien()
        {
            return cn2.layLoaiNhanVienDL();
        }
        public DataTable laydsChiNhanh()
        {
            return cn1.LayChiNhanh();
        }
        public bool ThemMoiNhanvien(DataRow dr)
        {

            try
            {
                cn.ThemmoiNhanVien(dr);
                return true;
            }
            catch (Exception e)
            {
                return
                    false;
            }
        }
        public bool SuaNhanVien(DataRow dr)
        {

            try
            {
                cn.SuaNhanVien(dr);
                return true;
            }
            catch (Exception e)
            {
                return
                    false;
            }
        }
        public bool XoaNhanVien(int dr)
        {

            try
            {
                cn.XoaNhanvien(dr);
                return true;
            }
            catch (Exception e)
            {
                return
                    false;
            }
        }
    }
}
