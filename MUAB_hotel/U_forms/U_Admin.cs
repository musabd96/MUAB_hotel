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

        public U_Admin()
        {
            InitializeComponent();
            pnlNewEmp.Visible = false;
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
            txtEmail.Text = txtFname.Text + "." + txtLname.Text + "@muab.com";
            txtEmail.Text = txtFname.Text + "." + txtLname.Text;
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = txtFname.Text + "." + txtLname.Text + "@muab.com";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void U_Admin_Load(object sender, EventArgs e)
        {
            
            dbHelper.empView(dataGridView6);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search = txtSearch.Text;
            dbHelper.empView(dataGridView6);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch_Click(sender, e);
            btnSearch_Click(sender, e);
            txtSearch.Focus();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.White;
            txtSearch.Clear();
        }

        
    }
}
