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
    public partial class Dashboard : UserControl
    {
        public static int roomsNr { get; set; }
        public static string roomStatus { get; set; }
        public static int totalBooked { get; set; }
        public static int totalAvailable { get; set; }
        public static int totalRooms { get; set; }
        public static int notAvailable { get; set; }

        dbHelper dbHelper = new dbHelper();
        public Dashboard()
        {
            InitializeComponent();
            lbReload.Visible = false;
        }

        private void u_Home_Load(object sender, EventArgs e)
        {
            dbHelper.Available();
            dbHelper.roomsview(dataGridView1);

            lbCurAva.Text = totalAvailable.ToString();

            dbHelper.totalRooms();
            lbTotRooms.Text = totalRooms.ToString();
            dbHelper.totalBooked();
            lbtotalBooked.Text = totalBooked.ToString();
            dbHelper.notAvailable();
            lbNotAvai.Text = notAvailable.ToString();

            listBoxTasks.DataSource = dbHelper.employeeTasks();
            listBoxTasks.Text = dbHelper.employeeTasks().ToString();


        }


        private void pbReload_MouseEnter(object sender, EventArgs e)
        {
            lbReload.Visible = true;
            lbReload.Location = PointToClient(Cursor.Position);
            lbReload.BringToFront();
        }

        private void pbReload_MouseLeave(object sender, EventArgs e)
        {
            lbReload.Visible = false;
        }

        private void pbReload_Click(object sender, EventArgs e)
        {

            u_Home_Load(sender, e);
        }

        
    }
}
