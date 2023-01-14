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
            conn.Close();

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
            conn.Close();

        }


        #endregion


        #region Dashboard

        //views (join booking and room tables)
        internal void dashboardView(DataGridView dataGridView)
        {
            u_Home u_Home = new u_Home();
            string query = "muabhotel.dashboardView";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$roomsnr", u_Home.roomsNr);

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

        #region Booking

        public static string bookingId { get; set; }
        public static int roomNr { get; set; }
        public static string roomType { get; set; }
        public static int totalDays { get; set; }
        public static string checkIn { get; set; }
        public static string checkOut { get; set; }
       
        public static decimal totalPrice { get; set; }
        public static string roomStatus { get; set; }
        public static int roomsCapacity { get; set; }



        //create bookid 
        internal void newBookingid()
        {
            string query = "muabhotel.newbookingid";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close();

        }

        //last Last BookingId
        internal void LastBookingId()
        {
            string query = "muabhotel.LastBookingId";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);


            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    bookingId = reader.GetString(0);
                    checkIn = reader.GetString(2);
                }
            }
            conn.Close();
        }

        internal void availableRooms(DataGridView dataGridView)
        {
            string query = "muabhotel.availableRooms";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$rooms_type", U_Booking.roomsType);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView.DataSource = table;
            }
            conn.Close();
        }

        //new booking
        internal void newBooking()
        {
            MessageBox.Show($"{totalDays} BID");
            string query = "muabhotel.newBooking";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$roomNr", roomNr);
            //cmd.Parameters.AddWithValue("$roomsCapacity", roomsCapacity);
            cmd.Parameters.AddWithValue("$checkIn", checkIn);
            cmd.Parameters.AddWithValue("$checkOut", checkOut);
            cmd.Parameters.AddWithValue("$totalPrice", totalPrice);
            cmd.Parameters.AddWithValue("$totalDays", totalDays);
            cmd.Parameters.AddWithValue("$guestsId", guestsId);
            cmd.Parameters.AddWithValue("$employeeId", employee_id);
            cmd.Parameters.AddWithValue("$bookingId", bookingId);
            cmd.Parameters.AddWithValue("$roomStatus", roomStatus);

            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close();
        }

        #endregion

        #region Guests

        public static int guestsId { get; set; }
        public static string guests_firstName { get; set; }
        public static string guests_lastName { get; set; }
        public static int guests_mobile { get; set; }
        public static string guests_email { get; set; }

        //Create new guest
        internal void newGuest()
        {
            string query = "muabhotel.newGuest";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$firstName", guests_firstName);
            cmd.Parameters.AddWithValue("$lastName", guests_lastName);
            cmd.Parameters.AddWithValue("$email", guests_email);
            cmd.Parameters.AddWithValue("$mobile", guests_mobile);
            cmd.Parameters.AddWithValue("$guestsId", guestsId);

            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close();
        }

        internal void newGuestsId()
        {
            string query = "muabhotel.newGuestsId";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            var ds = new DataSet();

            cmd.ExecuteReader();


            conn.Close();
        }

        internal void LastguestsId()
        {
            string query = "muabhotel.LastguestsId";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);


            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    guestsId = reader.GetInt32(0);
                    guests_firstName = reader.GetString(1);
                }
            }
            conn.Close();
        }

        #endregion

    }
}
