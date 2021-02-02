using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_dien
{
    public class Database
    {
        private string connectionString = @"Data Source=localhost;Initial Catalog=TT_Nhom1;Integrated Security=True";
        private SqlConnection conn;

        //private string sql;
        private DataTable dt;
        private SqlCommand cmd;

        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                //conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connected Failed: " + ex.Message);
            }
        }


        public DataTable SelectData(string sql)
        {
            try
            {
                conn.Open();
                //sql = "select * from NHANVIEN";
                //sql = "exec SelectAllNV";
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Loading ERROR: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading Error: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


        public int ExeCute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //return (int)cmd.ExecuteScalar();

                foreach (var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error: " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }


        public Boolean del_data(String manv)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql = "DELETE From NHANVIEN where MaNV = '"+manv+"'"  ;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                check = true;
                conn.Close();
            }
            catch (Exception)
            {
                check = false;
                throw;
            }
            

            return check;
        }

        public DataTable SearchData(string sql,int indexkeysearch,string valuesearch)
        {
            try
            {
                conn.Open();
                //sql = "select * from NHANVIEN";
                //sql = "exec SelectAllNV";

                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (indexkeysearch == 0)
                {
                    cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = valuesearch;
                }else if (indexkeysearch == 1)
                {
                    cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = valuesearch;
                }else if (indexkeysearch == 2)
                {
                    cmd.Parameters.Add("@TenPB", SqlDbType.NVarChar).Value = valuesearch;
                }
                dt = new DataTable();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    while (reader.Read())
                    {
                        Console.WriteLine("Ten : " + reader["TenNV"]);
                    }
                    return dt;
                }
                else
                {
                    dt = null;
                    return dt;
                }
                //dt.Load(cmd.ExecuteReader());
                //return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Loading ERROR: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
