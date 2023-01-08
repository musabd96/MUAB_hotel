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
    public partial class U_Admin : UserControl
    {
        dbHelper dbHelper = new dbHelper();
        public static string search { get; set; }
        public static string Name { get; set; }
        public static string email { get; set; }
        public static int EmpId { get; set; }
        public static string Mobile { get; set; }


        //New Employee data 

        public static string fName { get; set; }
        public static string lName { get; set; }
        public static string position { get; set; }
        public static string mobileNr { get; set; }
        public static string Email { get; set; }
        public static string uName { get; set; }


        public U_Admin()
        {
            InitializeComponent();
            pnlNewEmp.Visible = false;
            pnlEmp.Visible = false;
        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            pnlNewEmp.Visible = true;
            pnlNewEmp.Height = 704;
            pnlNewEmp.Location = new Point(2, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlNewEmp.Visible = false;
            pnlNewEmp.Height = 0;
            pnlNewEmp.Location = new Point(2, 694);
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = txtFname.Text.ToLower() + "." + txtLname.Text.ToLower() + "@muab.com";
            txtUName.Text = txtFname.Text.ToLower() + "." + txtLname.Text.ToLower();
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = txtFname.Text.ToLower() + "." + txtLname.Text.ToLower() + "@muab.com";
            txtUName.Text = txtFname.Text.ToLower() + "." + txtLname.Text.ToLower();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fName = txtFname.Text;
            lName = txtLname.Text;
            position = cBPosition.Text;
            mobileNr = txtPhNr.Text;
            Email = txtEmail.Text;
            uName = txtUName.Text;

            dbHelper.newEmp();
            MessageBox.Show("New employee is successfully registered");
        }

        private void U_Admin_Load(object sender, EventArgs e)
        {
            
            dbHelper.empView(dataGridView6);
            if(dbHelper.position == "Manager")
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search = txtSearch.Text;
            dbHelper.empView(dataGridView6);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
            txtSearch.Focus();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.White;
            txtSearch.Clear();
            pnlEmp.Visible = false;
        }

        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pnlEmp.Visible = true;
            pnlEmp.Location = dataGridView6.PointToClient(Cursor.Position);

            Name = dataGridView6.Rows[e.RowIndex].Cells["First Name"].FormattedValue.ToString();
            dbHelper.getEmp();
            lbFullName.Text = dataGridView6.Rows[e.RowIndex].Cells["First Name"].FormattedValue.ToString() + " "
                             + dataGridView6.Rows[e.RowIndex].Cells["Last Name"].FormattedValue.ToString();
            lbPosition.Text = dataGridView6.Rows[e.RowIndex].Cells["Position"].FormattedValue.ToString();
            lbStatus.Text = dataGridView6.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
            linkEmail.Text = dataGridView6.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
            lbEmpId.Text = EmpId.ToString();
            linkMob.Text = Mobile;
        }

        private void pBclosePnl_Click(object sender, EventArgs e)
        {
            pnlEmp.Visible=false;
        }

        

        private void U_Admin_Click(object sender, EventArgs e)
        {
            pnlEmp.Visible = false;
        }

        private void pBFired_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are You Actually Going to Get Fired {Name}?", "Confirmation", 
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dbHelper.fired();
            }
            else if (result == DialogResult.No)
            {
                pnlEmp.Visible = false;
            }
            
        }
    }
}
