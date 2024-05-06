using OpenLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VeDL
    {
        DataHelper dt = DataHelper.GetInstance();
        DataTable ve;
        public DataTable getVe()
        {
            ve = dt.FillDataTable("select * from ve");
            return ve;

        }
        public  void inserVe(DataTable da)
        {
            foreach (DataRow dr in da.Rows) {
                 dr[3]=0;
                string sql= "insert into ve values(" + dr[1] + ",'" + dr[2] + "'," + dr[3] + "," + dr[4] + ",null,N'" + dr[6] + "','" + dr[7] +"',null )";
                dt.ExecuteNonQuery(sql, null);


            }

            

        }
    }
}
