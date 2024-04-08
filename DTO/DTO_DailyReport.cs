using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DailyReport
    {
        public int DailyReportID { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeID { get; set; }
        public decimal WorkHours { get; set; }
    }
}
