using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ShiftAssignment
    {
        public int AssignmentID { get; set; }
        public int WorkShiftID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime Date { get; set; }
    }
}
