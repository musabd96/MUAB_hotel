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
        Login Login = new Login();

        u_Home u_Home = new u_Home();
        U_Booking U_Booking = new U_Booking();
        U_Reception U_Reception = new U_Reception();
        U_Services U_Services = new U_Services();
        U_Profile U_Profile = new U_Profile();
        U_Adminstration U_Adminstration = new U_Adminstration();
        

        dbHelper dbHelper = new dbHelper();
        public Home()
        {
            InitializeComponent();
            userControl(u_Home);

            openMenu();
            pnlDash.Enabled = false;

            
            timer1.Start();
        }

        
        //all U_forms controll and show it Panel pnl_U

        private void userControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl_U.Controls.Clear();
            pnl_U.Controls.Add(userControl);    
            userControl.BringToFront();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // getting the employee's info 
            dbHelper.getEmployee();
            lbname.Text = dbHelper.employeeFname + " " + dbHelper.employeeLname;
            lbPosition.Text = dbHelper.employeeRole;

            pnlDash.Enabled = false;
        }

        #region Menu Bar

        //Open Menu bar
        public void openMenu()
        {
            pnlMenuBarIcon.Visible = false;
            pnlMenuBar.Width = 212;
            pBLOGO.Visible = true;
            pnl_U.Width = 1155;
            pnlBlack.Width = 1155;
            pnlBlack.Location = new Point(182, 0);
            pnl_U.Location = new Point(182, 94);


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
            
        }



        private void pBCloseBar_Click(object sender, EventArgs e)
        {
            closeMenu();
        }

        private void pBMenuBarIcon_Click(object sender, EventArgs e)
        {
            openMenu();
        }
        #endregion


        
        #region Menu Bar buttons

        private void pBDash_Click(object sender, EventArgs e)
        {
            userControl(u_Home);
        }

        private void pBBooking_Click(object sender, EventArgs e)
        {
            userControl(U_Booking);
        }

        private void pBReception_Click(object sender, EventArgs e)
        {
            userControl(U_Reception);
        }

        private void pBService_Click(object sender, EventArgs e)
        {
            userControl(U_Services);
        }

        private void pBProfile_Click(object sender, EventArgs e)
        {
            userControl(U_Profile);
        }

        private void pBAdmin_Click(object sender, EventArgs e)
        {
            userControl(U_Adminstration);
        }

        private void pBLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Show();
        }
        #endregion

        // form closing
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
           

            
        }
        //bool menuExpanded = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("dd-MM-yyy");
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        
    }
}
