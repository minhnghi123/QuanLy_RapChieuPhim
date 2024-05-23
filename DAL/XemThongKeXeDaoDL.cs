using OpenLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XemThongKeXeDaoDL
    {
        DataHelper dt = DataHelper.GetInstance();
        DataTable db;
        public DataTable layThongKeXeDap()
        {
            db = dt.FillDataTable("select * from View_DoanhThu\r\n");
            return db;
        }
     }
}
