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
    public partial class U_Setting : UserControl
    {
        public U_Setting()
        {
            InitializeComponent();
        }
        dbHelper dbHelper = new dbHelper();
        private void btnedit_Click(object sender, EventArgs e)
        {
            
            
        }

        private void U_Setting_Load(object sender, EventArgs e)
        {
            dbHelper.getEmployee();
            lbUname.Text = dbHelper.userName;
            lbFullName.Text = (dbHelper.employee_firstName + ' ' + dbHelper.employee_lastName);
            lbEmail.Text = dbHelper.employee_email;
            lbMobile.Text = dbHelper.employee_mobile;
        }
    }
}
