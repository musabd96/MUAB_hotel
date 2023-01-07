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
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            if (txtUname.Text == "admin" || txtPass.Text == "admin")
            {
                userName = txtUname.Text;
                
                home.Show();
                this.Hide();
            }
            else
            {
                home.Show();
                this.Hide();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
