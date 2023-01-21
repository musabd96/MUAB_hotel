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
    public partial class U_Profile : UserControl
    {
        public static string newEmployeePassword { get; set; }
        public U_Profile()
        {
            InitializeComponent();
        }
        dbHelper dbHelper = new dbHelper();
        private void btnedit_Click(object sender, EventArgs e)
        {
            
            
        }

        private void U_Setting_Load(object sender, EventArgs e)
        {
            pnlPass.Visible = false;
            dbHelper.getEmployee();
            txtFname.Text = dbHelper.employeeFname;
            txtFname.Enabled = false;
            txtLname.Text = dbHelper.employeeLname;
            txtLname.Enabled = false;
            txtEmail.Text = dbHelper.employeeEmail;
            txtEmail.Enabled = false;
            txtUname.Text = dbHelper.employeeUserName;
            txtUname.Enabled = false;
            txtMobile.Text = dbHelper.employeeMobile;
            txtMobile.Enabled = false;
            txtEmpID.Text = dbHelper.employeeId.ToString();
            txtEmpID.Enabled = false;
            txtRole.Text = dbHelper.employeeRole.ToString();
            txtRole.Enabled = false;
            txtPass.Text = dbHelper.employeePassword;
            txtPass.Enabled = false;

        }

        

        private void pbPass_Click(object sender, EventArgs e)
        {
            pnlPass.Visible = true;
            pnlPass.Location = new Point(526, 102);
            pnlPass.Height = 429;
            txtCurtPass.Focus();
            
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtConfPass.Clear();
            txtNewPass.Clear();
            txtConfPass.Clear();
            pnlPass.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int currentPass = Convert.ToInt32(txtCurtPass.Text);
            newEmployeePassword = txtNewPass.Text;
            string confirmPass = txtConfPass.Text;
            if (currentPass == Convert.ToInt32(dbHelper.employeePassword))
            {
                if(newEmployeePassword == confirmPass)
                {
                    dbHelper.newemployeepassword();
                    pnlPass.Visible = false;
                    MessageBox.Show("Change Password Success");
                }
                else
                {
                    txtConfPassError.SetError(txtConfPass, "Do not matched!");
                    txtConfPass.ForeColor = Color.Red;
                    txtConfPass.Focus();
                }
            }
            else
            {
                txtCurPassError.SetError(txtCurtPass, "Wrong Password!");
                txtCurtPass.ForeColor = Color.Red;
                txtCurtPass.Focus();
               
            }
        }

        //Hide Password
        private void pBHideCurnt_Click(object sender, EventArgs e)
        {
            if (txtCurtPass.PasswordChar == '\0')
            {
                pBShowCurnt.BringToFront();
                txtCurtPass.PasswordChar = '*';
            }
        }

        private void pBHidePass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.PasswordChar == '\0')
            {
                pBShowPass.BringToFront();
                txtNewPass.PasswordChar = '*';
            }
        }

        private void pBHideConf_Click(object sender, EventArgs e)
        {
            if (txtConfPass.PasswordChar == '\0')
            {
                pBShowConf.BringToFront();
                txtConfPass.PasswordChar = '*';
            }
        }
        //Show Password

        private void pBShowCurnt_Click(object sender, EventArgs e)
        {
            if (txtCurtPass.PasswordChar == '*')
            {
                pBHideCurnt.BringToFront();
                txtCurtPass.PasswordChar = '\0';
            }
        }

        private void pBShowPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.PasswordChar == '*')
            {
                pBHidePass.BringToFront();
                txtNewPass.PasswordChar = '\0';
            }
        }

        private void pBShowConf_Click(object sender, EventArgs e)
        {
            if (txtConfPass.PasswordChar == '*')
            {
                pBHideConf.BringToFront();
                txtConfPass.PasswordChar = '\0';
            }
        }

        private void txtConfPass_TextChanged(object sender, EventArgs e)
        {
            txtConfPass.ForeColor = Color.Black;
        }

        private void txtCurtPass_TextChanged(object sender, EventArgs e)
        {
            txtCurtPass.ForeColor = Color.Black;

        }

    }
}
