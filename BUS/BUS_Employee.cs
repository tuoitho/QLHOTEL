﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Employee
    {
        public static DataTable DSNhanVien() => DAL_Employee.DSNhanVien();
    }
}
