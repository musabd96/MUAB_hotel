using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAB_hotel
{
    public class dbHelper
    {
        public static string server = "localhost";
        public static string database = "cusdata";
        public static string user = "root";
        public static string pass = "0909";



        MySqlConnection conn = new MySqlConnection($"SERVER={server};DATABASE={database};UID={user};PASSWORD={pass};");

        internal void getData(DataGridView dataGridView)
        {
            U_Booking u_Booking = new U_Booking();
            string Query = "select * from hoteldb.rooms where rooms_type ='" + U_Booking.roomsType + "'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView.DataSource = table;
            conn.Close();
        }
        
    }
}
