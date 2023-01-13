using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAB_hotel
{
    internal class dbHelper
    {

        // Database connection variable

        public static string server = "localhost";
        public static string database = "cusdata";
        public static string user = "root";
        public static string pass = "allia";


        MySqlConnection conn = new MySqlConnection($"SERVER={server};DATABASE={database};UID={user};PASSWORD={pass};");



        #region Login


        Login Login = new Login();

        public static string userName { get; set; }
        public static string password { get; set; }
        public static int employee_id { get; set; }
        public static string employee_firstName { get; set; }
        public static string employee_lastName { get; set; }
        public static string employee_email { get; set; }
        public static string employee_status { get; set; }
        public static string role { get; set; }

        //Login 
        internal void login()
        {
            string query = "muabhotel.login";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$username", Login.userName);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    userName = reader.GetString(1);
                    password = reader.GetString(2);
                    employee_id = reader.GetInt32(3);
                }
            }

        }
        
        // Getting employee's information that login
        internal void getEmployee()
        {
            string query = "muabhotel.getEmployee";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$employee_id", employee_id);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    employee_firstName = reader.GetString(1);
                    employee_lastName = reader.GetString(2);
                    employee_email = reader.GetString(3);
                    employee_status = reader.GetString(6);
                    role = reader.GetString(9);
                }
            }

        }


        #endregion


        #region Dashboard

        //views (join booking and room tables)
        internal void dashboardView(DataGridView dataGridView)
        {
            string query = "muabhotel.dashboardView";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$roomsnr", employee_id);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView.DataSource = table;
            }
            conn.Close();

            
        }

        internal void roomSt()
        {
            string query = "muabhotel.roomSt";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$roomsNr", u_Home.roomsNr);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    u_Home.roomStatus = reader.GetString(4);
                    
                }
            }
            conn.Close();
        }

        #endregion

    }
}
