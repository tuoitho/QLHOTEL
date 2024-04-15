using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Phong
    {
        static MyDB myDB = new MyDB();
        //public static DataTable PhongCard()
        //{
        //    DataTable dataTable = new DataTable();
        //    try
        //    {
        //        myDB.OpenConnection();
        //        SqlCommand sqlCommand = new SqlCommand("select * from Phong join loaiphong on phong.maloaiphong=loaiPhong.maloaiphong", myDB.GetConnection);
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //        sqlDataAdapter.Fill(dataTable);
        //    }
        //    catch (Exception ex)
        //    {
        //        ex.ToString();
        //    }
        //    finally
        //    {
        //        myDB.CloseConnection();
        //    }
        //    return dataTable;
        //}
        public static DataTable DSPhong() {             DataTable dataTable = new DataTable();
                   try
            {
                myDB.OpenConnection();
                SqlCommand sqlCommand = new SqlCommand("select * from Phong", myDB.GetConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
            }
                       catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                myDB.CloseConnection();
            }
            return dataTable;
        }
    }
}
