using OpenLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhimDL
    {
        DataHelper dt = DataHelper.GetInstance();
        DataTable Phim = new DataTable();
        DataTable PhimDangChieu = new DataTable();
        public PhimDL() { } 
        public DataTable getPhiMDangChieu()
        {
            PhimDangChieu = dt.FillDataTable("select* from view_phimdangchieutrongngay");
            return PhimDangChieu;
        }
        public DataTable getPhiMDangChieuseachr(string text)
        {
            PhimDangChieu = dt.FillDataTable("select* from view_phimdangchieutrongngay  where TenPhim like N'%" + text + "%' ");
            return PhimDangChieu;
        }
        public DataTable getPhiM()
        {
            PhimDangChieu = dt.FillDataTable("select* from Phim");
            return PhimDangChieu;
        }
    }
   
}
