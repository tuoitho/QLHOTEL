using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Checkin
    {
        static MyDB mydb = new MyDB();
        public static DataTable GetAllCheckins()
        {
            mydb.OpenConnection();
            string query = "SELECT * FROM Checkin";
            SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            DataTable dataTable = new DataTable();
            new SqlDataAdapter(command).Fill(dataTable);
            return dataTable;
           
        }

        //public static int AddCheckin(int employeeId, DateTime start, DateTime end, int assignmentId)
        //{
        //    string query = $"INSERT INTO Checkin (EmployeeID, Start, End, AssignmentID) VALUES ({employeeId}, '{start}', '{end}', {assignmentId})";
        //    return mydb.ExecuteNonQuery(query);
        //}

        
    }
}
