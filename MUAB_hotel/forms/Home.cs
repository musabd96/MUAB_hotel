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

        string userPnl;
        bool menuBarExpand;
        dbHelper dbHelper = new dbHelper();
        public Home()
        {
            InitializeComponent();
            userControl(u_Home);

            pnlDash.BackColor = Color.GhostWhite;
            lbDash.ForeColor = Color.Black;
            pBDash.Image = imageList1.Images[13];
            pBDash.SizeMode = PictureBoxSizeMode.StretchImage;

            closeMenu();

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
            dbHelper.getEmployee();
            lbname.Text = dbHelper.employeeFname + " " + dbHelper.employeeLname;
            lbPosition.Text = dbHelper.employeeRole;


        }
        #region Menu Bar buttons


        private void pBDash_Click(object sender, EventArgs e)
        {
            userPnl = "u_Home";
            userControl(u_Home);

            pnlDash.BackColor = Color.GhostWhite;
            lbDash.ForeColor = Color.Black;
            pBDash.Image = imageList1.Images[13];
            pBDash.SizeMode = PictureBoxSizeMode.StretchImage;
            pnlBooking.BackColor = Color.FromArgb(35, 40, 45);
            pnlReception.BackColor = Color.FromArgb(35, 40, 45);
            pnlService.BackColor = Color.FromArgb(35, 40, 45);
            pnlProfile.BackColor = Color.FromArgb(35, 40, 45);
            pnlAdmin.BackColor = Color.FromArgb(35, 40, 45);

            pnlBooking_MouseLeave(sender, e);
            pnlReception_MouseLeave(sender, e);
            pnlService_MouseLeave(sender, e);
            pnlProfile_MouseLeave(sender, e);
            pnlAdmin_MouseLeave(sender, e);
        }

        private void pBBooking_Click(object sender, EventArgs e)
        {
            userPnl = "U_Booking";
            userControl(U_Booking);
            pnlDash.BackColor = Color.FromArgb(35, 40, 45);

            pnlBooking.BackColor = Color.GhostWhite;
            lbBooking.ForeColor = Color.Black;
            pBBooking.Image = imageList1.Images[11];
            pBBooking.SizeMode = PictureBoxSizeMode.StretchImage;

            pnlReception.BackColor = Color.FromArgb(35, 40, 45);
            pnlService.BackColor = Color.FromArgb(35, 40, 45);
            pnlProfile.BackColor = Color.FromArgb(35, 40, 45);
            pnlAdmin.BackColor = Color.FromArgb(35, 40, 45);

            pnlDash_MouseLeave(sender, e);
            pnlReception_MouseLeave(sender, e);
            pnlService_MouseLeave(sender, e);
            pnlProfile_MouseLeave(sender, e);
            pnlAdmin_MouseLeave(sender, e);
        }

        private void pBReception_Click(object sender, EventArgs e)
        {
            userPnl = "U_Reception";
            userControl(U_Reception);
            
            pnlDash.BackColor = Color.FromArgb(35, 40, 45);
            lbDash.ForeColor = Color.White;
            pnlBooking.BackColor = Color.FromArgb(35, 40, 45);

            pnlReception.BackColor = Color.GhostWhite;
            lbReception.ForeColor = Color.Black;
            pBReception.Image = imageList1.Images[9];
            pBReception.SizeMode = PictureBoxSizeMode.StretchImage;

            pnlService.BackColor = Color.FromArgb(35, 40, 45);
            pnlProfile.BackColor = Color.FromArgb(35, 40, 45);
            pnlAdmin.BackColor = Color.FromArgb(35, 40, 45);

            pnlDash_MouseLeave(sender, e);
            pnlBooking_MouseLeave(sender, e);
            pnlService_MouseLeave(sender, e);
            pnlProfile_MouseLeave(sender, e);
            pnlAdmin_MouseLeave(sender, e);
        }

        private void pBService_Click(object sender, EventArgs e)
        {
            userPnl = "U_Services";
            userControl(U_Services);
            pnlDash.BackColor = Color.FromArgb(35, 40, 45);
            pnlBooking.BackColor = Color.FromArgb(35, 40, 45);
            pnlReception.BackColor = Color.FromArgb(35, 40, 45);

            pnlService.BackColor = Color.GhostWhite;
            lbService.ForeColor = Color.Black;
            pBService.Image = imageList1.Images[7];
            pBService.SizeMode = PictureBoxSizeMode.StretchImage;

            pnlProfile.BackColor = Color.FromArgb(35, 40, 45);
            pnlAdmin.BackColor = Color.FromArgb(35, 40, 45);

            pnlDash_MouseLeave(sender, e);
            pnlBooking_MouseLeave(sender, e);
            pnlReception_MouseLeave(sender, e);
            pnlProfile_MouseLeave(sender, e);
            pnlAdmin_MouseLeave(sender, e);
        }

        private void pBProfile_Click(object sender, EventArgs e)
        {
            userPnl = "U_Profile";
            userControl(U_Profile);
            
            pnlDash.BackColor = Color.FromArgb(35, 40, 45);
            pnlBooking.BackColor = Color.FromArgb(35, 40, 45);
            pnlReception.BackColor = Color.FromArgb(35, 40, 45);
            pnlService.BackColor = Color.FromArgb(35, 40, 45);

            pnlProfile.BackColor = Color.GhostWhite;
            lbProfile.ForeColor = Color.Black;
            pBProfile.Image = imageList1.Images[5];
            pBProfile.SizeMode = PictureBoxSizeMode.StretchImage;

            pnlAdmin.BackColor = Color.FromArgb(35, 40, 45);

            pnlDash_MouseLeave(sender, e);
            pnlBooking_MouseLeave(sender, e);
            pnlReception_MouseLeave(sender, e);
            pnlService_MouseLeave(sender, e);
            pnlAdmin_MouseLeave(sender, e);
        }

        private void pBAdmin_Click(object sender, EventArgs e)
        {
            userPnl = "U_Adminstration";
            userControl(U_Adminstration);
           
            pnlDash.BackColor = Color.FromArgb(35, 40, 45);
            pnlBooking.BackColor = Color.FromArgb(35, 40, 45);
            pnlReception.BackColor = Color.FromArgb(35, 40, 45);
            pnlService.BackColor = Color.FromArgb(35, 40, 45);
            pnlProfile.BackColor = Color.FromArgb(35, 40, 45);

            pnlAdmin.BackColor = Color.GhostWhite;
            lbAdmin.ForeColor = Color.Black;
            pBAdmin.Image = imageList1.Images[3];
            pBAdmin.SizeMode = PictureBoxSizeMode.StretchImage;

            pnlDash_MouseLeave(sender, e);
            pnlBooking_MouseLeave(sender, e);
            pnlReception_MouseLeave(sender, e);
            pnlService_MouseLeave(sender, e);
            pnlProfile_MouseLeave(sender, e);

        }

        private void pBLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Show();
        }


        #endregion


        
        #region Menu Bar

        //Open Menu bar
        public void openMenu()
        {
            pBLogo2.Visible = false;
            pnlMenuBar.Width = 212;
            pnl_U.Width = 1155;
            pnlBlack.Width = 1155;
            pnlBlack.Location = new Point(207, 0);
            pnl_U.Location = new Point(207, 99);


        }

        //Close Menu bar
        internal void closeMenu()
        {
            pBLogo2.Visible = true;
            pnlMenuBar.Width = 60;
            pnl_U.Width = 1302;
            pnlBlack.Width = 1302;
            pnl_U.Location = new Point(60, 99);
            pnlBlack.Location = new Point(60, 0);
            
        }



        private void pBCloseBar_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void pBMenuBarIcon_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
            
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

        #region MenuBar mouse reaction

        private void pnlDash_MouseEnter(object sender, EventArgs e)
        {
            pnlDash.BackColor = Color.GhostWhite;
            lbDash.ForeColor = Color.Black;
            pBDash.Image = imageList1.Images[13];
            pBDash.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void pnlBooking_MouseEnter(object sender, EventArgs e)
        {
            pnlBooking.BackColor = Color.GhostWhite;
            lbBooking.ForeColor = Color.Black;
            pBBooking.Image = imageList1.Images[11];
            pBBooking.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void pnlReception_MouseEnter(object sender, EventArgs e)
        {
            pnlReception.BackColor = Color.GhostWhite;
            lbReception.ForeColor = Color.Black;
            pBReception.Image = imageList1.Images[9];
            pBReception.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pnlService_MouseEnter(object sender, EventArgs e)
        {
            pnlService.BackColor = Color.GhostWhite;
            lbService.ForeColor = Color.Black;
            pBService.Image = imageList1.Images[7];
            pBService.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pnlProfile_MouseEnter(object sender, EventArgs e)
        {
            pnlProfile.BackColor = Color.GhostWhite;
            lbProfile.ForeColor = Color.Black;
            pBProfile.Image = imageList1.Images[5];
            pBProfile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pnlAdmin_MouseEnter(object sender, EventArgs e)
        {
            pnlAdmin.BackColor = Color.GhostWhite;
            lbAdmin.ForeColor = Color.Black;
            pBAdmin.Image = imageList1.Images[3];
            pBAdmin.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pnlLogout_MouseEnter(object sender, EventArgs e)
        {
            pnlLogout.BackColor = Color.GhostWhite;
            lbLogout.ForeColor = Color.Black;
            pBLogout.Image = imageList1.Images[2];
            pBLogout.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Mouse leave

        private void pnlDash_MouseLeave(object sender, EventArgs e)
        {
            
            if(userPnl == "u_Home")
            {
                pnlDash.BackColor = Color.GhostWhite;
                lbDash.ForeColor = Color.Black;
                pBDash.Image = imageList1.Images[13];
                pBDash.SizeMode = PictureBoxSizeMode.StretchImage;
                pnlBooking_MouseLeave(sender, e);
            }
            else
            {
                pnlDash.BackColor = Color.FromArgb(35, 40, 45);
                lbDash.ForeColor = Color.White;
                pBDash.Image = imageList1.Images[12];
                pBDash.SizeMode = PictureBoxSizeMode.StretchImage;
            }



        }

        private void pnlBooking_MouseLeave(object sender, EventArgs e)
        {
            if(userPnl == "U_Booking")
            {
                pnlBooking.BackColor = Color.GhostWhite;
                lbBooking.ForeColor = Color.Black;
                pBBooking.Image = imageList1.Images[11];
                pBBooking.SizeMode = PictureBoxSizeMode.StretchImage;
            }else
            {
                pnlBooking.BackColor = Color.FromArgb(35, 40, 45);
                lbBooking.ForeColor = Color.White;
                pBBooking.Image = imageList1.Images[10];
                pBBooking.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void pnlReception_MouseLeave(object sender, EventArgs e)
        {
            if (userPnl == "U_Reception")
            {
                pnlReception.BackColor = Color.GhostWhite;
                lbReception.ForeColor = Color.Black;
                pBReception.Image = imageList1.Images[9];
                pBReception.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pnlReception.BackColor = Color.FromArgb(35, 40, 45);
                lbReception.ForeColor = Color.White;
                pBReception.Image = imageList1.Images[8];
                pBReception.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pnlService_MouseLeave(object sender, EventArgs e)
        {
            if(userPnl == "U_Services")
            {
                pnlService.BackColor = Color.GhostWhite;
                lbService.ForeColor = Color.Black;
                pBService.Image = imageList1.Images[7];
                pBService.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pnlService.BackColor = Color.FromArgb(35, 40, 45);
                lbService.ForeColor = Color.White;
                pBService.Image = imageList1.Images[6];
                pBService.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }

        private void pnlProfile_MouseLeave(object sender, EventArgs e)
        {
            if(userPnl == "U_Profile")
            {
                pnlProfile.BackColor = Color.GhostWhite;
                lbProfile.ForeColor = Color.Black;
                pBProfile.Image = imageList1.Images[5];
                pBProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pnlProfile.BackColor = Color.FromArgb(35, 40, 45);
                lbProfile.ForeColor = Color.White;
                pBProfile.Image = imageList1.Images[4];
                pBProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pnlAdmin_MouseLeave(object sender, EventArgs e)
        {
            if(userPnl == "U_Adminstration")
            {
                pnlAdmin.BackColor = Color.GhostWhite;
                lbAdmin.ForeColor = Color.Black;
                pBAdmin.Image = imageList1.Images[3];
                pBAdmin.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pnlAdmin.BackColor = Color.FromArgb(35, 40, 45);
                lbAdmin.ForeColor = Color.White;
                pBAdmin.Image = imageList1.Images[0];
                pBAdmin.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pnlLogout_MouseLeave(object sender, EventArgs e)
        {
            pnlLogout.BackColor = Color.FromArgb(35, 40, 45);
            lbLogout.ForeColor = Color.White;
            pBLogout.Image = imageList1.Images[1];
            pBLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        #endregion

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            
            if (menuBarExpand)
            {
                pnlMenuBar.Width -= 152;
                if(pnlMenuBar.Width == pnlMenuBar.MinimumSize.Width)
                {
                    menuBarExpand = false;
                    sidebartimer.Stop();
                    closeMenu();
                }
            }
            else
            {
                pnlMenuBar.Width += 152;
                if(pnlMenuBar.Width == pnlMenuBar.MaximumSize.Width)
                {
                    menuBarExpand = true;
                    sidebartimer.Stop();
                    openMenu();
                }
            }
        }
    }
}
