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
    public partial class u_Home : UserControl
    {
        public u_Home()
        {
            InitializeComponent();
        }

        private void u_Home_Load(object sender, EventArgs e)
        {
            lbHome.Parent = pictureBox1;
            lbHome.BackColor = Color.Transparent;
        }
    }
}
