using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Checkin
    {
        public static DataTable GetAllCheckins()
        {
            return DAL.DAL_Checkin.GetAllCheckins();
        }
    }
}
