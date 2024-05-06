using DAL;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class ctrDatVePhim
    {
        PhimDL  phimdl = new PhimDL();
        public DataTable getPhimDanchieu()
        {
            return phimdl.getPhiMDangChieu();
        }

    }
}
