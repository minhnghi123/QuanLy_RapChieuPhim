using OpenLibrary.DataAccess;
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
        
        public DataTable getPhong()
        {
            PhimDangChieu = dt.FillDataTable("select* from PhongChieu");
            return PhimDangChieu;
        }
    }
}
