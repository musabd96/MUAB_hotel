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
    public partial class U_Services : UserControl
    {
        dbHelper1 db = new dbHelper1();
        public static string status { get; set; }
        public static int roomNr { get; set; }

        public U_Services()
        {
            InitializeComponent();
        }

        private void U_Services_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            db.getRoomSt(dataGridView5);
            DataGridViewColumn Cancelled = dataGridView5.Columns[0];
            Cancelled.DisplayIndex = dataGridView5.ColumnCount - 1;

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView5.CurrentCell.Selected = true;

            lbRNr.Text = dataGridView5.Rows[e.RowIndex].Cells["Room Nr"].FormattedValue.ToString();

            if (dataGridView5.Columns[e.ColumnIndex].HeaderText == "Available")
            {
                panel1.Visible = true;
                btnOK.Enabled = false;

            }

                


        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if(checkBox1.Checked == true)
                {
                    checkedListBox1.SetItemChecked(i, true);
                    btnOK.Enabled = true;
                }
                else
                {
                    checkedListBox1.SetItemChecked(i, false);
                    btnOK.Enabled = false;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dbHelper1.roomNr = lbRNr.Text;
            dbHelper1.roomStatus = "Available";
            db.getCID();
            db.roomstatus();
            db.cancelBooking();

            MessageBox.Show($"Room service is seccussfull \n ROOM IS READY");

            U_Services_Load(sender, e);
        }
    }
}
