﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ctrHoaDon
    {
        VeDL ve= new VeDL();
        public void capnhathoadon(DataTable dt)
        {
            ve.inserVe(dt);
        }    
    }
}
