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
        RapDL rapChieu = new RapDL();
        public DataTable suatRap()
        {
            return rapChieu.getRapChieu();
        }
        public bool insertRapChieu(DataRow dr)
        {
            return rapChieu.inserRap(dr);
        }
        public bool update(DataRow dr)
        {
            return rapChieu.updateRap(dr);
        }
        public bool xoa(string marapchieu)
        {
            return rapChieu.deleteRap(marapchieu);
        }
    }
}
