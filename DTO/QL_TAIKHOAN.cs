using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QL_TAIKHOAN
    {
        public string MaTK {  get; set; }   
        public string TaiKhoan {  get; set; }
        public string MatKhau { get; set; }
        public int FK_iMaQuyen {  get; set; }   
    }
}
