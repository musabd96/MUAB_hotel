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
        bool menuExpand;

        public Home()
        {
            InitializeComponent();
            u_Home u_Home = new u_Home();
            userControl(u_Home);

            openMenu();
        }

        #region Menu Bar

        //Open Menu bar
        public void openMenu()
        {
            pnlMenuBarIcon.Visible = false;
            pnlMenuBar.Width = 189;
            pBLOGO.Visible = true;
            pnl_U.Width = 1180;
            pnlBlack.Width = 1180;
            pnlBlack.Location = new Point(182, 0);
            pnl_U.Location = new Point(182, 94);

            btnHome.Enabled = true;
            btnBooking.Enabled = true;
            btnBooking.Enabled = true;
            btnReception.Enabled = true;
            btnSetting.Enabled = true;
            btnAdmin.Enabled = false;

        }

        //Close Menu bar
        internal void closeMenu()
        {

            pnlMenuBarIcon.Visible = true;
            pnlMenuBar.Width = 60;
            pBLOGO.Visible = false;
            pnl_U.Width = 1302;
            pnlBlack.Width = 1305;
            pnl_U.Location = new Point(60, 94);
            pnlBlack.Location = new Point(60, 0);
            btnHome.Enabled = false;
            btnBooking.Enabled = false;
            btnBooking.Enabled = false;
            btnReception.Enabled = false;
            btnSetting.Enabled = false;
            btnAdmin.Enabled = false;
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
            btnReception.Enabled = true;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            U_Booking u_Booking = new U_Booking();
            userControl(u_Booking);
            btnBooking.Enabled = false;
            btnHome.Enabled = true;
            btnReception.Enabled = true;
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            U_Reception U_Reception = new U_Reception();
            userControl(U_Reception);
            btnReception.Enabled = false;
            btnBooking.Enabled = true;
            btnHome.Enabled = true;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

            btnHome.Enabled = false;
        }
    }
}
