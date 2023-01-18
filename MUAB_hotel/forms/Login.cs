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
    public partial class Login : Form
    {
        
        public static string userName { get; set; }
        public static string password { get; set; }
        

        public Login()
        {
            InitializeComponent();
        }

        #region Login 
        
        //Login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                userName = txtUname.Text;
                password = txtPass.Text;

                dbHelper dbHelper = new dbHelper();
                dbHelper.login();

                
                Home1 home1 = new Home1();
                Home home = new Home();

                //admin login 
                if (userName == "admin" && password == "1234")
                {

                    home1.Show();
                    this.Hide();
                }
                
                else if (userName == dbHelper.employeeUserName && password == dbHelper.employeePassword)
                {
                    // control if the user is housekeeping position or other position 
                    // Housekeeping olny access the home1 form other positions can access all
                    dbHelper.getEmployee();
                    if (dbHelper.employeeRole == "Housekeeping")
                    {
                        home1.Show();
                        this.Hide();
                    }
                    else
                    {
                        home.Show();
                        this.Hide();
                    }

                }
                else
                {
                    if(userName == dbHelper.employeeUserName)
                    {

                        lbError.Text = "Wrong password!";
                        lbError.Location = new Point(111, 233);
                        
                        pnlPass.BackColor = Color.Red;
                        txtPass.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbError.Text = "Wrong username and password!";
                        lbError.Location = new Point(133, 69);

                        pnlAccNr.BackColor = Color.Red;
                        txtUname.ForeColor = Color.Red;
                        pnlPass.BackColor = Color.Red;
                        txtPass.ForeColor = Color.Red;
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Invalid fiel d");
            }
            
        }


        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        private void txtUname_TextChanged(object sender, EventArgs e)
        {
            pnlAccNr.BackColor = Color.DodgerBlue;
            txtUname.ForeColor = Color.White;
            lbError.Text = "";
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            pnlPass.BackColor = Color.DodgerBlue;
            txtPass.ForeColor = Color.White;
            lbError.Text = "";
        }

        #endregion

        #region pass hide or view button

        private void pBHide_Click(object sender, EventArgs e)
        {
            
            if (txtPass.PasswordChar == '\0')
            {
                pBView.BringToFront();
                txtPass.PasswordChar = '*';
            }

        }

       
       


        private void pBView_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                pBHide.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        #endregion

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
