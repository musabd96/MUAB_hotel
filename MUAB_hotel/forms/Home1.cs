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
    public partial class Home1 : Form
    {
        dbHelper dbHelper = new dbHelper();
        Dashboard u_Home = new Dashboard();
        public Home1()
        {
            InitializeComponent();
            userControl(u_Home);
            openMenu();
            btnHome.Enabled = false;
            timer1.Start();
        }

       

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

        //all U_forms controll and show it Panel pnl_U
        private void userControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl_U.Controls.Clear();
            pnl_U.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //Home button
        private void btnHome_Click(object sender, EventArgs e)
        {
            Dashboard u_Home = new Dashboard();
            userControl(u_Home);
            btnHome.Enabled = false;
            btnService.Enabled = true;
            btnSetting.Enabled = true;
        }

        //service button
        private void btnService_Click(object sender, EventArgs e)
        {
            U_Services U_Services = new U_Services();
            userControl(U_Services);
            btnHome.Enabled = true;
            btnService.Enabled = false;
            btnSetting.Enabled = true;
        }


        //setting button
        private void btnSetting_Click(object sender, EventArgs e)
        {
            U_Profile U_Setting = new U_Profile();
            userControl(U_Setting);
            btnHome.Enabled = true;
            btnService.Enabled = true;
            btnSetting.Enabled = false;
        }


        private void pBCloseBar_Click(object sender, EventArgs e)
        {
            closeMenu();
        }

        private void pBMenuBarIcon_Click(object sender, EventArgs e)
        {
            openMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Home1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("dd-MM-yyy");
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Home1_Load(object sender, EventArgs e)
        {
            // getting the employee's info 
            dbHelper.getEmployee();
            lbname.Text = dbHelper.employeeFname + " " + dbHelper.employeeLname;
            lbPosition.Text = dbHelper.employeeRole;
        }
    }
}
