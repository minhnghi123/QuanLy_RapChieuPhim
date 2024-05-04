using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CtrRap
    {
        RapDL tblRap;
        public DataTable LayDSRap()
        {
            return tblRap.LayDSRap();
        }
        public bool ThemRap(String TenRap)
        {
            try
            {
                tblRap.ThemMoiRap(TenRap);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Suarap(String TenRap, String MaRap)
        {
            try
            {
                tblRap.SuaRap(TenRap, MaRap);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Xoarap(String s)
        {
            try
            {
                bool t = tblRap.XoaRap(s);
                return t;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
