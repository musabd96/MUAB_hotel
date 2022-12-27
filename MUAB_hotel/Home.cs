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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            closeMenu();
            u_Home u_Home = new u_Home();
            userControl(u_Home);
        }

        #region Menu Bar

        //Open Menu bar
        public void openMenu()
        {
            pnlMenuBarIcon.Visible = false;
            pnlMenuBar.Width = 190;
            pBLOGO.Visible = true;
            pnl_U.Width = 1160;
            pnlBlack.Width = 1162;
            pnlBlack.Location = new Point(182, 0);
            pnl_U.Location = new Point(182, 88);
            


        }

        //Close Menu bar
        public void closeMenu()
        {
            pnlMenuBarIcon.Visible = true;
            pnlMenuBar.Width = 60;
            pBLOGO.Visible = false;
            pnl_U.Width = 1302;
            pnlBlack.Width = 1305;
            pnl_U.Location = new Point(60, 88);
            pnlBlack.Location = new Point(57, 0);
        }


        #endregion

        private void userControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl_U.Controls.Clear();
            pnl_U.Controls.Add(userControl);    
            userControl.BringToFront();
        }


        private void pBCloseBar_Click(object sender, EventArgs e)
        {
            closeMenu();
        }

        private void pBMenuBarIcon_Click(object sender, EventArgs e)
        {
            openMenu();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            u_Home u_Home = new u_Home();
            userControl(u_Home);
            btnHome.Enabled = false;
            btnBooking.Enabled = true;

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            U_Booking u_Booking = new U_Booking();
            userControl(u_Booking);
            btnBooking.Enabled = false;
            btnHome.Enabled = true;
        }

        private void btnReception_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

    }
}
