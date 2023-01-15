using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
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
        dbHelper dbHelper = new dbHelper();
        public static string roomStatus { get; set; }
        public static string service { get; set; }
        public static int roomNr { get; set; }

        public U_Services()
        {
            InitializeComponent();
        }

        private void U_Services_Load(object sender, EventArgs e)
        {
            pBX.Visible = false;
            pBl.Visible = false;
            pnlService.Visible = false;
            txtSearch_TextChanged(sender, e);
            DataGridViewColumn Cancelled = dataGridView5.Columns[0];
            Cancelled.DisplayIndex = dataGridView5.ColumnCount - 1;

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView5.CurrentCell.Selected = true;

            lbRNr.Text = dataGridView5.Rows[e.RowIndex].Cells["Room Nr"].FormattedValue.ToString();
            roomStatus = dataGridView5.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
            lbSerType.Text = roomStatus;

            roomNr = Convert.ToInt32(lbRNr.Text);

            if (dataGridView5.Columns[e.ColumnIndex].HeaderText == "Service")
            {
                if(roomStatus == "CheckOut")
                {
                    pnlService.Visible = true;
                    checkBox1.Visible = true;
                    checkedListBox1.Visible = true;
                    btnOK.Enabled = true;
                    checkedListBox1.Items.Clear();
                    checkedListBox1.Items.Add("Bed");
                    checkedListBox1.Items.Add("Toiled");
                    checkedListBox1.Items.Add("floor");
                    


                }
                else if (roomStatus == "CheckIn")
                {
                    pnlService.Visible = true;
                    checkBox1.Visible = true;
                    checkedListBox1.Visible = true;
                    btnOK.Enabled = true;
                    checkedListBox1.Items.Clear();
                    checkedListBox1.Items.Add("Guests Order1");
                    checkedListBox1.Items.Add("Guests Order2");
                    checkedListBox1.Items.Add("Guests Order3");
                }
                else if (roomStatus == "Booked")
                {
                    pnlService.Text = "Guests Requirments";
                    pnlService.Visible = true;
                    checkBox1.Visible = true;
                    checkedListBox1.Visible = true;
                    btnOK.Enabled = true;
                    checkedListBox1.Items.Clear();
                    checkedListBox1.Items.Add("Guests Reguest1");
                    checkedListBox1.Items.Add("Guests Reguest2");
                    checkedListBox1.Items.Add("Guests Reguest3");
                }
                
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
            if (roomStatus == "CheckIn")
            {
                //Charge the guest service price 
                MessageBox.Show("Room service is seccussfull");
            }
            else if (roomStatus == "CheckOut")
            {
                U_Reception.roomNr = roomNr;
                dbHelper.getGuest();
                dbHelper.cancelledBooking();
                // In Future create a table that stored the old booking details

                MessageBox.Show($"Room Nr: {roomNr} Is Available");
            }
            else if (roomStatus == "Booked")
            {
                //Charge the guest service price 
                MessageBox.Show("Room service is seccussfull");
            }
            checkBox1.Checked = false;
            U_Services_Load(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                pBX.Visible = true;
                pBl.Visible = true;
                dbHelper.searchRoom(dataGridView5);
            }
            else
            {
                pBX.Visible = false;
                pBl.Visible = false;
                dbHelper.searchRoom(dataGridView5);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            U_Services_Load(sender, e);
        }
    }
}
