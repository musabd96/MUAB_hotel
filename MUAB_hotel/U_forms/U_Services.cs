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
            btnSave.Enabled = false;
            pBX.Visible = false;
            pBl.Visible = false;
            pnlService.Visible = false;
            pBsearch_Click(sender, e);

        }

        #region CheckBox 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox1.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, checkBox1.Checked);
                    
                }
                btnSave.Enabled = true;
                pBsearch_Click(sender, e);
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                    
                }
                btnSave.Enabled = false;
            }

        }

        
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (checkedListBox1.CheckedItems.Count == 1 && e.NewValue == CheckState.Unchecked)
            {
                checkBox1.Checked = false;
            }
            else if (checkedListBox1.CheckedItems.Count == checkedListBox1.Items.Count - 1 && e.NewValue == CheckState.Checked)
            {
                checkBox1.Checked = true;
            }


        }

        #endregion

        


        private void dataGridView5_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            lbRNr.Text = dataGridView5.Rows[e.RowIndex].Cells["Room Nr"].FormattedValue.ToString();
            roomStatus = dataGridView5.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();


            roomNr = Convert.ToInt32(lbRNr.Text);

            if (roomStatus == "CheckOut")
            {
                pnlService.Visible = true;
                lbSerType.Text = "Cleaning";
                checkBox1.Visible = true;
                checkedListBox1.Visible = true;
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add("Bed");
                checkedListBox1.Items.Add("Toiled");
                checkedListBox1.Items.Add("floor");



            }
            else if (roomStatus == "CheckIn")
            {
                pnlService.Visible = true;
                lbSerType.Text = "Guests Orders";
                checkBox1.Visible = true;
                checkedListBox1.Visible = true;
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add("Guests Order1");
                checkedListBox1.Items.Add("Guests Order2");
                checkedListBox1.Items.Add("Guests Order3");
            }
            else if (roomStatus == "Booked")
            {
                pnlService.Visible = true;
                lbSerType.Text = "Guests Requirments";
                checkBox1.Visible = true;
                checkedListBox1.Visible = true;
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add("Guests Reguest1");
                checkedListBox1.Items.Add("Guests Reguest2");
                checkedListBox1.Items.Add("Guests Reguest3");
            }


        }

        #region Buttons

        
        private void pBsearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
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

        private void btnSave_Click(object sender, EventArgs e)
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            U_Services_Load(sender, e);
        }





        #endregion

    }
}
