using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ctrSuatChieu
    {
        PhimDL phim = new PhimDL ();
        SuatChieuDL suatChieu=new SuatChieuDL ();
        PhongChieuDL PhongChieuDL = new PhongChieuDL ();
        public DataTable suachieu()
        {
            return suatChieu.getSuatChieu();
        }
        public DataTable Phim()
        {
            return phim.getPhiM();
        }
        public DataTable PHong()
        {
            return PhongChieuDL.getPhong();
        }
        public bool inserSuatChieu(DataRow dr)
        {
            return suatChieu.inserSuatChieu(dr);
        }
        public bool update(DataRow dr)
        {
            return suatChieu.updateSuatChieu(dr);
        }
        public bool xoa(string masuachieu)
        {
            return suatChieu.xoa(masuachieu);
        }
    }
}
