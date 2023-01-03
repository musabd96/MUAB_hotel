using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
        public static string pass = "allia";


        MySqlConnection conn = new MySqlConnection($"SERVER={server};DATABASE={database};UID={user};PASSWORD={pass};");

        #region BOOKING

        //Booking
        public static string bookingId { get; set; }
        public static string roomNr { get; set; }
        public static string roomType { get; set; }
        public static string totalDays { get; set; }
        public static string price { get; set; }
        public static string checkIn { get; set; }
        public static string checkOut { get; set; }


        internal void getData(DataGridView dataGridView)
        {
            U_Booking u_Booking = new U_Booking();
            string Query = "SELECT rooms_nr as 'Room Nr', rooms_type as 'Type', rooms_price as 'Price' FROM hoteldb.rooms where rooms_type ='" + U_Booking.roomsType + "';";
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

            string query = "UPDATE hoteldb.booking SET booking_check_in = '" + checkIn+ "', booking_check_out = '" + checkOut + "', " +
                "booking_days = '" + totalDays + "', booking_price = '" + price + "', customers_id = '" + customerId + "', rooms_nr = '" + roomNr + "' WHERE booking_id = '" + bookingId + "'";

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
            string query = "SELECT * FROM hoteldb.customers WHERE customers_first_name = 0";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                customerId = (int)reader["customers_id"];
            }
            conn.Close();
        }

        internal void newCustomer()
        {
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

        internal void roomPrice()
        {
            MessageBox.Show($"rom {U_Reception.newRoomNr}");
            string Query = "SELECT rooms_price FROM hoteldb.rooms where rooms_nr = '" + U_Reception.newRoomNr + "';";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                U_Reception.Price = (string)reader["rooms_price"];
            }
            conn.Close();
        }

        internal void roomstatus()
        {
            string query = "UPDATE hoteldb.rooms SET rooms_status = '" + roomStatus + "' WHERE rooms_nr = '" + roomNr + "'";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQueryAsync();


            conn.Close();
        }

        internal void showRoom(DataGridView dataGridView)
        {
            u_Home u_Home = new u_Home();
            
            if(u_Home.roomsStatus == "- All -")
            {
                string Query = "SELECT rooms_nr AS 'Room Nr' FROM hoteldb.rooms;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(Query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView.DataSource = table;
                
                conn.Close();
            }
            else
            {
                string Query = "SELECT rooms_nr 'Room Nr', rooms_status AS 'Status' FROM hoteldb.rooms WHERE rooms_type = '" + u_Home.roomsStatus + "';";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(Query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView.DataSource = table;


                conn.Close();
            }


        }

       
        #endregion


        #region RECEPTION


        internal void search(DataGridView dataGridView)
        {
            U_Reception U_Reception = new U_Reception();
            string Query = "SELECT booking_id AS 'Book ID', customers.customers_first_name AS 'First Name', " +
                                              "customers.customers_last_name AS 'Last Name', " +
                                              "rooms.rooms_nr AS 'Room Nr', " +
                                              "rooms.rooms_type AS 'Type' , " +
                                              "booking_price AS 'Price', " +
                                              "booking_check_in AS 'Check in', " +
                                              "booking_check_out AS 'Check out' , " +
                                              "booking_days AS 'Total days' , " +
                                              "booking_status AS 'Status' " +
                                              " FROM hoteldb.booking inner join hoteldb.customers on " +
                                              "booking.customers_id = customers.customers_id " +
                                              " inner join hoteldb.rooms on booking.rooms_nr = rooms.rooms_nr " +
                                              "WHERE customers_first_name = '" + U_Reception.search + "' " +
                                              " OR booking_id = '" + U_Reception.search + "';";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView.DataSource = table;
            conn.Close();

        }

        internal void editCustomer()
        {
            U_Reception u_Reception = new U_Reception();

            string query = " UPDATE  hoteldb.customers SET customers_first_name = '" + U_Reception.FName + "'," +
                                                           "customers_last_name = '" + U_Reception.LName + "' " +
                                                           "WHERE customers_id = '" + U_Reception.customersID + "' ;" +
                           " UPDATE  hoteldb.rooms SET rooms_status = 'Available' WHERE rooms_nr = '" + U_Reception.roomNr + "' ;" +
                           " UPDATE  hoteldb.rooms SET rooms_status = 'Booked' WHERE rooms_nr = '" + U_Reception.newRoomNr + "' ;" +
                           " UPDATE  hoteldb.booking SET booking_check_in = '" + U_Reception.checkIn + "'," +
                                                           "booking_check_out = '" + U_Reception.checkOut + "', " +
                                                           "rooms_nr = '" + U_Reception.newRoomNr + "', " +
                                                           "booking_days = '" + U_Reception.Days + "', " +
                                                           "booking_price = '" + U_Reception.newPrice + "', " +
                                                           "booking_status = '" + U_Reception.status + "' " +
                                                           "WHERE booking_id = '" + U_Reception.bookingID + "';";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQueryAsync();


            conn.Close();
        }

        internal void getCustomerData()
        {
            U_Reception U_Reception = new U_Reception();
            string Query = "SELECT * FROM hoteldb.booking inner join hoteldb.customers on booking.customers_id = customers.customers_id " +
                           " inner join hoteldb.rooms on booking.rooms_nr = rooms.rooms_nr WHERE customers_first_name = '" + U_Reception.search + "' " +
                           " OR booking_id = '" + U_Reception.search + "';";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                U_Reception.customersID = (int)reader["customers_id"];
            }
            conn.Close();
        }


        internal void chechInOut()
        {
            U_Reception u_Reception = new U_Reception();
            string query = " UPDATE  hoteldb.booking SET booking_status = '" + U_Reception.status + "' " +
                                                    "WHERE booking_id = '" + U_Reception.bookingID + "';";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQueryAsync();


            conn.Close();
        }

        internal void cancelBooking()
        {

            string query = "DELETE FROM hoteldb.customers WHERE customers_id = '" + U_Reception.customersID + "'; " +
                           "UPDATE hoteldb.rooms SET rooms_status = 'Available' WHERE rooms_nr = '" + U_Reception.roomNr + "';";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQueryAsync();


            conn.Close();

        }

        
        #endregion

    }
}
