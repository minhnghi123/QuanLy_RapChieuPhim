using OpenLibrary.DataAccess;
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
        DataTable tblRap;
        DataHelper dt = DataHelper.GetInstance();
        public RapDL() 
        {
            tblRap = dt.FillDataTable("Select * from RapChieu");    
        }
        public DataTable LayDSRap()
        {
            return tblRap;
        }
        public bool ThemMoiRap(String TenRap)
        {
            try
            {
                dt.InsertRowtable(tblRap, null, TenRap);
                dt.UpdateFromDataTableToDataBase("RapChieu", tblRap);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }
        public bool XoaRap(String MaRap)
        {
            try
            {
                dt.DeleteRowTable(tblRap, "MaRapChieu = " + MaRap);
                dt.UpdateFromDataTableToDataBase("RapChieu", tblRap);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }
        public bool SuaRap(String TenRap, String MaRap)
        {
            try
            {
                String dk = "MaRapChieu = " + MaRap;
                dt.UpdateRowTable(tblRap, dk, "TenRap", TenRap);
                dt.UpdateFromDataTableToDataBase("RapChieu", tblRap);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }
    }
}
