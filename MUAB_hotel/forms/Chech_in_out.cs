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
    public partial class Chech_in_out : Form
    {
        dbHelper dbHelper = new dbHelper();
        public static string message;
        public Chech_in_out()
        {
            InitializeComponent();
            
            
        }


        //Check in/out and cancelled 
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (message == "Check in?")
            {
                dbHelper.chechInOut();
                this.Close();
            }
            else if (message == "Check out?")
            {
                dbHelper.chechInOut();
                this.Close();
            }

            else if (message == "Cancelled?")
            {
                dbHelper.cancelledBooking();
                //db.cancelBooking();
                this.Close();
            }

            lbFullName.Text = "";
            lbCID.Text = "";
            lbBookNr.Text = "";
            lbmessage.Text = "";
            
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chech_in_out_Load(object sender, EventArgs e)
        {
            lbmessage.Text = message;
            lbFullName.Text = U_Reception.FName + " " +U_Reception.LName;
            lbCID.Text = U_Reception.guestId.ToString();
            lbBookNr.Text = U_Reception.bookingId;
        }
    }
}
