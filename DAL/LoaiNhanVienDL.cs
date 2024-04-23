using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.DataAccess
{
    public class LoaiNhanVienDL
    {
        DataTable cn;
        DataHelper dt = DataHelper.GetInstance();
        public LoaiNhanVienDL()
        {
          //  cn = dt.FillDataTable("select * from LoaiNhanvien");
        }
        public DataTable layLoaiNhanVienDL()
        {
            return cn;
        }
    }
}
