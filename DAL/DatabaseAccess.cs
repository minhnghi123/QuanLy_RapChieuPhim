using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO; 
namespace DAL
{ 
    public class SqlConnectionData
{
    public static SqlConnection Conncect()
    {
        string strcon = "Data Source=LAPTOP-PICGBI40\\HONGPHUC;Initial Catalog=QLY_NHANVIEN;Integrated Security=True;";
        SqlConnection conn = new SqlConnection(strcon);
        return conn;
    }
}


    public class DatabaseAccess
    {
       public static string CheckLoginDAL(QL_TAIKHOAN taikhoan)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Conncect();
            conn.Open();    
            SqlCommand cmd = new SqlCommand("proc_login",conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", taikhoan.TaiKhoan);
            cmd.Parameters.AddWithValue("@pass", taikhoan.MatKhau); 
            cmd.Connection = conn;  
            SqlDataReader r = cmd.ExecuteReader();  
            if (r.HasRows)
            {
                while(r.Read())
                {
                    user = r.GetString(0);
                    return user; 
                }
                r.Close(); 
                conn.Close();   
            }
            else
            {
                return "Tai Khoan Hoac Mat Khau Khong Chinh Xac"; 
            }
            return user; 
        }
    }
}
