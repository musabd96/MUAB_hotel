using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MUAB_hotel
{
    public partial class Update : Form
    {

        public static string newRoomType { get; set; }
        public static string oldRoomType { get; set; }
        public static string roomNrs { get; set; }

        dbHelper dbHelper= new dbHelper();
        U_Reception u_Reception = new U_Reception();


        public Update()
        {
            InitializeComponent();


        }
        private void Update_Load(object sender, EventArgs e)
        {


            

            oldRoomType = U_Reception.type;

            txtFName.Text = U_Reception.FName;
            txtLName.Text = U_Reception.LName;
            cBRmNr.Text = U_Reception.roomNr.ToString();

            cBRmTyp.Text = U_Reception.type;
            dtCheckin.Text = U_Reception.checkIn;
            dtCheckout.Text = U_Reception.checkOut;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            U_Reception.FName = txtFName.Text;
            U_Reception.LName = txtLName.Text;
            U_Reception.newRoomNr = Convert.ToInt32(cBRmNr.Text);
            U_Reception.checkIn = dtCheckin.Text;
            U_Reception.checkOut = dtCheckout.Text;

            TimeSpan diff = dtCheckout.Value.Subtract(dtCheckin.Value);
            double days = diff.TotalDays;

            int result = (int)Math.Round(days, 1, MidpointRounding.AwayFromZero);

            days = result;

            U_Reception.Days = days.ToString();

            int nights = Convert.ToInt32(days);
            dbHelper.roomPrice();
            int total = nights * (Convert.ToInt32(U_Reception.Price));
            U_Reception.newPrice = total.ToString();
            dbHelper.editCustomer();
            this.Close();

            


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBRmTyp_SelectedIndexChanged(object sender, EventArgs e)
        {


            newRoomType = cBRmTyp.Text;

            cBRmNr.Items.Clear();
            allRoom();
            if (oldRoomType == newRoomType)
            {
                cBRmNr.Text = U_Reception.roomNr.ToString();

            }
            else if (oldRoomType != newRoomType)
            {
                
                cBRmNr.Text = "-Select  room nr-";


            }
            

            

        }

        
        MySqlConnection conn = new MySqlConnection($"SERVER={dbHelper.server};DATABASE={dbHelper.database};UID={dbHelper.user};PASSWORD={dbHelper.pass};");

        internal void allRoom()
        {
            string Query = "SELECT * FROM hoteldb.rooms WHERE rooms_type = '" + newRoomType + "';";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                roomNrs = reader.GetString("rooms_nr");
                
                cBRmNr.Items.Add(roomNrs);

                

            }

            


            conn.Close();
        }

    }
}
