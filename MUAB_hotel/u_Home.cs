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
        public static string roomsStatus;

        public u_Home()
        {
            InitializeComponent();
        }

        private void u_Home_Load(object sender, EventArgs e)
        {
            roomsStatus = (string)cBRmSt.SelectedItem;
            dbHelper db = new dbHelper();
            db.showRoom(dataGridView2);
        }

        private void cBRmSt_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbHelper db = new dbHelper();
            roomsStatus = (string)cBRmSt.SelectedItem;
            db.showRoom(dataGridView2);
            dataGridView2.Focus();
        }
    }
}
