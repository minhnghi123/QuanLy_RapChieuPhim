using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess access = new TaiKhoanAccess();
        public string CheckLogin(QL_TAIKHOAN taikhoan)
        {
            if (taikhoan.TaiKhoan == "")
            {
                return "Yeu Cau Nhap Tai Khoan";
            }
            if (taikhoan.MatKhau == "")
            {
                return "Yeu Cau Nhap Mat Khau";
            }
            string info = access.CheckLogin(taikhoan);
            return info;    
        }
    }
}
