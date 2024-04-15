using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
namespace DAL
{
    public class DAL_Employee
    {


        public static DataTable DSNhanVien()
        {
            DataTable dataTable = new DataTable();
            MyDB myDB = new MyDB();
            //List<DTO_Employee> lstNhanVien = new List<DTO_Employee>();
            try
            {
                myDB.OpenConnection();
                SqlCommand sqlCommand = new SqlCommand("select * from Employees", myDB.GetConnection);
                
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                //if (dataTable != null)
                //    for (int i = 0; i < dataTable.Rows.Count; i++)
                //    {
                //        DTO_Employee dtoEmployee = new DTO_Employee();
                //        dtoEmployee.MaNV = dataTable.Rows[i]["manv"].ToString();
                //        dtoEmployee.TenNV = dataTable.Rows[i]["tennv"].ToString();
                //        dtoEmployee.DiaChi = dataTable.Rows[i]["diachi"].ToString();
                //        dtoEmployee.SDT = dataTable.Rows[i]["sdt"].ToString();
                //        dtoEmployee.Email = dataTable.Rows[i]["email"].ToString();
                //        dtoEmployee.Gender = dataTable.Rows[i]["gender"].ToString();
                //        dtoEmployee.ChucVu = dataTable.Rows[i]["ChucVu"].ToString();
                //        dtoEmployee.LuongCoBan = Convert.ToDouble(dataTable.Rows[i]["LuongCoBan"].ToString());
                //        lstNhanVien.Add(dtoEmployee);
                        
                //    }
                                
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

        public static bool insertNhanVien(DTO_Employee dtoEmployee)
        {
            MyDB myDB = new MyDB();
            try
            {
                myDB.OpenConnection();
                SqlCommand sqlCommand = new SqlCommand("insert into Employees values(@manv,@tennv,@gender,@ngaysinh,@diachi,@sdt,@chucvu,null)", myDB.GetConnection);
                sqlCommand.Parameters.Add(parameterName: "@manv", SqlDbType.Int).Value = dtoEmployee.MaNV;
                sqlCommand.Parameters.Add(parameterName: "@tennv", SqlDbType.NVarChar).Value = dtoEmployee.TenNV;
                sqlCommand.Parameters.Add(parameterName: "@gender", SqlDbType.NVarChar).Value = dtoEmployee.Gender;
                sqlCommand.Parameters.Add(parameterName: "@ngaysinh", SqlDbType.Date).Value = dtoEmployee.Ngaysinh;
                sqlCommand.Parameters.Add(parameterName: "@diachi", SqlDbType.NVarChar).Value = dtoEmployee.DiaChi;
                sqlCommand.Parameters.Add(parameterName: "@sdt", SqlDbType.NVarChar).Value = dtoEmployee.SDT;
                sqlCommand.Parameters.Add(parameterName: "@chucvu", SqlDbType.Int).Value = dtoEmployee.ChucVu;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                myDB.CloseConnection();
            }
            return true;

        }
    }
}
