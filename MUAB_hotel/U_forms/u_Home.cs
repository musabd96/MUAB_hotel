using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAB_hotel
{
    public partial class u_Home : UserControl
    {
        public static int roomsNr { get; set; }
        public static string roomStatus { get; set; }
        public static int totalBooked { get; set; }
        public static int totalAvailable { get; set; }
        public static int totalRooms { get; set; }
        public static int notAvailable { get; set; }

        dbHelper dbHelper = new dbHelper();
        public u_Home()
        {
            InitializeComponent();


        }

        private void u_Home_Load(object sender, EventArgs e)
        {
            // Rooms Datagredview
            dbHelper.roomsview(dataGridView1);
            dbHelper.Available();

            lbCurAva.Text = totalAvailable.ToString();

            dbHelper.totalRooms();
            lbTotRooms.Text = totalRooms.ToString();
            dbHelper.totalBooked();
            lbtotalBooked.Text = totalBooked.ToString();
            dbHelper.notAvailable();
            lbNotAvai.Text = notAvailable.ToString();

            if(dbHelper.employeeRole == "Housekeeping")
            {

            }
        }

        
    }
}
