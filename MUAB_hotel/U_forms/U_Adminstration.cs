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
    public partial class U_Adminstration : UserControl
    {
        dbHelper1 db = new dbHelper1();
        dbHelper dbHelper = new dbHelper();
        public static string searchEmp { get; set; }
        public static string Name { get; set; }
        public static string email { get; set; }
        public static int employee_id { get; set; }
        public static string Mobile { get; set; }


        //New Employee data 

        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static string role { get; set; }
        public static string mobile { get; set; }
        public static string Email { get; set; }
        public static string userName { get; set; }
        public static decimal salary { get; set; }


        public U_Adminstration()
        {
            InitializeComponent();
            pnlNewEmp.Visible = false;
            pnlEmp.Visible = false;
        }

        #region Buttons

        private void pBsearch_Click(object sender, EventArgs e)
        {
            
            txtSearch_TextChanged(sender, e);
            if (dataGridView6.RowCount == 0)
            {
                MessageBox.Show($"NOT FOUND (-> {txtSearch.Text} <-)" +
                    $" \nIN THE SYSTEM \n\n TRY AGAIN!!!");
                txtSearch.ForeColor = Color.Red;
                txtSearch.SelectAll();
                txtSearch.Focus();

            }
        }





        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            pnlNewEmp.Visible = true;
            pnlNewEmp.Height = 704;
            pnlNewEmp.Location = new Point(2, 0);
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchEmp = txtSearch.Text;
            if (txtSearch.Text != "")
            {
                pBX.Visible = true;
                pBl.Visible = true;
                dbHelper.viewEmployees(dataGridView6);
                dataGridView6.Focus();


                txtSearch.Focus();
            }
            else
            {
                pBX.Visible = false;
                pBl.Visible = false;

            }
            dbHelper.viewEmployees(dataGridView6);
            dataGridView6.Focus();


            txtSearch.Focus();
        }

        


        private void pBclosePnl_Click(object sender, EventArgs e)
        {
            pnlEmp.Visible=false;
        }


        //termination employee
        private void pBFired_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are You Actually Going to Get Fired {Name}?", "Confirmation", 
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessageBox.Show($"{employee_id}Test");
            if (result == DialogResult.Yes)
            {
                dbHelper.termination();
                pnlEmp.Visible = false;
                dbHelper.viewEmployees(dataGridView6);

            }
            else if (result == DialogResult.No)
            {
                pnlEmp.Visible = false;
                dbHelper.viewEmployees(dataGridView6);


            }
            
        }


        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                dbHelper.viewEmployees(dataGridView6);
                dataGridView6.Focus();

                if (dataGridView6.RowCount == 0)
                {
                    MessageBox.Show($"NOT FOUND (-> {txtSearch.Text} <-)" +
                        $" \nIN THE SYSTEM \n\n TRY AGAIN!!!");
                    txtSearch.ForeColor = Color.Red;
                    txtSearch.SelectAll();
                    txtSearch.Focus();

                }

            }
        }

        #endregion

        private void U_Admin_Load(object sender, EventArgs e)
        {

            txtSearch_TextChanged(sender, e);
            pBl.Visible = false;
            pBX.Visible = false;
            if (dbHelper.role == "Manager")
            {
                pBFired.Visible = true;
                btnNewEmp.Visible = true;
            }
            else
            {
                btnNewEmp.Visible = false;
                pBFired.Visible = false;
            }
            
        }

        //DataGredView that shows all the employee 
        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pnlEmp.Visible = true;
            pnlEmp.Location = dataGridView6.PointToClient(Cursor.Position);

            employee_id =Convert.ToInt32( dataGridView6.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
            Name = dataGridView6.Rows[e.RowIndex].Cells["FirstName"].FormattedValue.ToString();
            lbFullName.Text = dataGridView6.Rows[e.RowIndex].Cells["FirstName"].FormattedValue.ToString() + " "
                             + dataGridView6.Rows[e.RowIndex].Cells["LastName"].FormattedValue.ToString();
            role = dataGridView6.Rows[e.RowIndex].Cells["Role"].FormattedValue.ToString();
            lbStatus.Text = dataGridView6.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
            linkEmail.Text = dataGridView6.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
            linkMob.Text = dataGridView6.Rows[e.RowIndex].Cells["Mobile"].FormattedValue.ToString();
            lbPosition.Text = role;
            lbEmpId.Text = employee_id.ToString();
        }

        
        
        private void U_Admin_Click(object sender, EventArgs e)
        {
            pnlEmp.Visible = false;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }



        #region New Employee

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = txtFirstName.Text.ToLower() + "." + txtLastName.Text.ToLower() + "@muab.com";
            txtUserName.Text = txtFirstName.Text.ToLower() + "." + txtLastName.Text.ToLower();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = txtFirstName.Text.ToLower() + "." + txtLastName.Text.ToLower() + "@muab.com";
            txtUserName.Text = txtFirstName.Text.ToLower() + "." + txtLastName.Text.ToLower();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            role = cBPosition.Text;
            mobile = txtMobile.Text;
            Email = txtEmail.Text;
            userName = txtUserName.Text;
            salary = Convert.ToDecimal(txtSalary.Text);

            dbHelper.newEmployee();
            MessageBox.Show("New employee is successfully registered");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlNewEmp.Visible = false;
            pnlNewEmp.Height = 0;
            pnlNewEmp.Location = new Point(2, 694);
        }

        #endregion
    }

}
