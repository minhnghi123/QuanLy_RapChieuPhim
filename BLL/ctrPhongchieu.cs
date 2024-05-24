using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ctrPhongChieu
    {
       
        PhongChieuDL PhongChieuDL = new PhongChieuDL ();
       
     
        public DataTable PHong()
        {
            return PhongChieuDL.getPhong();
        }
        public DataTable rap()
        {
            return PhongChieuDL.getRap();
        }
        public bool inserSuatChieu(DataRow dr)
        {
            return PhongChieuDL.inserSuatChieu(dr);
        }
        public bool update(DataRow dr)
        {
            return PhongChieuDL.updateSuatChieu(dr);
        }
        public bool xoa(string masuachieu)
        {
            return PhongChieuDL.xoa(masuachieu);
        }
    }
}
