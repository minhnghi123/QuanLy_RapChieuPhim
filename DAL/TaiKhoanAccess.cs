using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO; 
namespace DAL
{
    public class TaiKhoanAccess:DatabaseAccess
    {
        public string CheckLogin(QL_TAIKHOAN taikhoan)
        {
            string info = CheckLoginDAL(taikhoan);
            return info; 
        }
    }
}
