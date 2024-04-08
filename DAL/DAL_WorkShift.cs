using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_WorkShift
    {
        static MyDB mydb = new MyDB();
        //public static DataTable GetAllWorkShifts()
        //{
        //    string query = "SELECT * FROM WorkShift";
            
        //}
        //public static int AddWorkShift(string shiftName, TimeSpan startTime, TimeSpan endTime, DateTime date, string managers, string receptionists, string workers)
        //{
        //    string query = $"INSERT INTO WorkShift (ShiftName, StartTime, EndTime, Date, Managers, Receptionists, Workers) VALUES ('{shiftName}', '{startTime}', '{endTime}', '{date}', '{managers}', '{receptionists}', '{workers}')";
        //    return mydb.ExecuteNonQuery(query);
        //}
        public static bool checkIfExsitWorkShift(int emid, DateTime dateTime)
        {
            mydb.OpenConnection();
            dateTime = DateTime.ParseExact("2024-03-28 08:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            SqlCommand command = new SqlCommand("SELECT * FROM WorkShift WHERE WorkShiftID = @emid and @dt> StartTime and @dt<EndTime",mydb.GetConnection);
            command.Parameters.Add("@emid", SqlDbType.Int).Value = emid;
            command.Parameters.Add("@dt", SqlDbType.DateTime).Value = dateTime;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            mydb.CloseConnection();
            return dt.Rows.Count > 0;
        }
        

        //public static int UpdateWorkShift(int workShiftId, string shiftName, TimeSpan startTime, TimeSpan endTime, DateTime date, string managers, string receptionists, string workers)
        //{
        //    string query = $"UPDATE WorkShift SET ShiftName = '{shiftName}', StartTime = '{startTime}', EndTime = '{endTime}', Date = '{date}', Managers = '{managers}', Receptionists = '{receptionists}', Workers = '{workers}' WHERE WorkShiftID = {workShiftId}";
        //    return mydb.ExecuteNonQuery(query);
        //}

        //public static int DeleteWorkShift(int workShiftId)
        //{
        //    string query = $"DELETE FROM WorkShift WHERE WorkShiftID = {workShiftId}";
        //    return mydb.ExecuteNonQuery(query);
        //}
    }
}
