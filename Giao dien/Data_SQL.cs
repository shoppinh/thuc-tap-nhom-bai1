using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Giao_dien
{
    internal class data
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPCUATUNG\SQLEXPRESS;Initial Catalog=TT_Nhom1;Integrated Security=True");

        private void open_connect()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

        }

        private void close_connect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }

        public Boolean exec_data(string cmd)
        {
            open_connect();

            Boolean check = false;


            try
            {
                SqlCommand cmds = new SqlCommand(cmd, con);
                cmds.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }


            close_connect();

            return check;
        }


        public DataTable readData(string cmd)
        {
            open_connect();

            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmds = new SqlCommand(cmd, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmds);
                dataAdapter.Fill(dt);

            }
            catch (Exception)
            {
                dt = null;

            }

            close_connect();
            return dt;
        }
    }
}
