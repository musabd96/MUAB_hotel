using Google.Protobuf.WellKnownTypes;
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

        //database connection 
        public static string server = "localhost";
        public static string database = "cusdata";
        public static string user = "root";
        public static string pass = "0909";


        MySqlConnection conn = new MySqlConnection($"SERVER={server};DATABASE={database};UID={user};PASSWORD={pass};");

        #region BOOKING

        //Booking
        public static string bookingId { get; set; }
        public static string roomNr { get; set; }
        public static string roomType { get; set; }
        public static string totalDays { get; set; }
        public static string checkIn { get; set; }
        public static string checkOut { get; set; }


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

        internal void newbookingid()
        {
           

            string Query = "INSERT INTO hoteldb.booking (booking_id, booking_check_in ) VALUES (SUBSTRING(UUID(), 1, 5), 0);";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(Query, conn);
            var ds = new DataSet();

            //cmd.Parameters.AddWithValue("@0", 0);
            cmd.ExecuteReader();

            conn.Close();

        }

        

        internal void LastBookingId()
        {
            string query = "SELECT * FROM hoteldb.booking WHERE booking_check_in = 0";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                bookingId = (string)reader["booking_id"];

            }
            conn.Close();
        }
        

        internal void newBooking()
        {

            MessageBox.Show($"chin {customerId} bokid room{roomNr}");
            string query = "UPDATE hoteldb.booking SET booking_check_in = '" + checkIn+ "', booking_check_out = '" + checkOut + "', " +
                "booking_days = '" + totalDays + "', customers_id = '" + customerId + "', rooms_nr = '" + roomNr + "' WHERE booking_id = '" + bookingId + "'";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQueryAsync();


            conn.Close();
        }

        #endregion


        #region Customer

        //customer

        public static int customerId { get; set; }
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static string phoneNr { get; set; }
        public static string address { get; set; }

        internal void newcustomerid()
        {


            string Query = "INSERT INTO hoteldb.customers (customers_first_name ) VALUES (0);";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(Query, conn);
            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close();

        }



        internal void LastcustomerId()
        {
                MessageBox.Show($"cusId = {customerId}");
            string query = "SELECT * FROM hoteldb.customers WHERE customers_first_name = 0";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                customerId = (int)reader["customers_id"];
                MessageBox.Show($"cusId = {customerId}");
            }
            conn.Close();
        }

        internal void newCustomer()
        {
            MessageBox.Show($"fname {firstName} lname{lastName} cusid{customerId}");
            string query = "UPDATE hoteldb.customers SET customers_first_name = '" + firstName + "', customers_last_name = '" + lastName + "', " +
                "customers_phone = '" + phoneNr + "', customers_address  = '" + address + "' WHERE customers_id = '" + customerId + "'";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQueryAsync();


            conn.Close();
        }
        #endregion

        #region Rooms

        public static string roomStatus { get; set; }


        internal void roomstatus()
        {
            string query = "UPDATE hoteldb.rooms SET rooms_status = '" + roomStatus + "' WHERE rooms_nr = '" + roomNr + "'";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQueryAsync();


            conn.Close();
        }

        #endregion


    }
}
