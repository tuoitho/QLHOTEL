using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Employee
    {
        public static bool CheckExist(int maNV)
        {
            return DAL_Employee.CheckExist(maNV);
        }

        public static DataTable DSNhanVien() => DAL_Employee.DSNhanVien();

        public static bool insertNhanVien(DTO_Employee dtoEmployee)
        {
            return DAL_Employee.insertNhanVien(dtoEmployee);
            
            
        }
    }
}
