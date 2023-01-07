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
            pnledit.Visible = false;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            pnledit.Visible = true;
            pnledit.Height = 704;
            pnledit.Location = new Point(0, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pnledit.Visible = false;
            pnledit.Height = 0;
            pnledit.Location = new Point(0, 694);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnledit.Visible = false;
            pnledit.Height = 0;
            pnledit.Location = new Point(0, 694);
        }
    }
}
