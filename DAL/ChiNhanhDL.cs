using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.DataAccess
{
    public class ChiNhanhDL
    {
        DataTable cn;
        DataHelper dt = DataHelper.GetInstance();
        public ChiNhanhDL()
        {
          //  cn = dt.FillDataTable("select * from ChiNhanh");
        }
        public DataTable LayChiNhanh()
        {
            return cn;
        }
    }
}
