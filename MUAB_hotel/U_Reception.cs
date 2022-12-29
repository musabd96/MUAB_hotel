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
    public partial class U_Reception : UserControl
    {
        public static string search { get; set; }
        public static string FName { get; set; }
        public static int roomNr { get; set; }
        public static string newRoomNr { get; set; }
        public static string type { get; set; }
        public static string LName { get; set; }
        public static string checkIn { get; set; }
        public static string checkOut { get; set; }
        public static string bookingID { get; set; }
        public static int customersID { get; set; }
        public static string Days { get; set; }
        public static string Price { get; set; }
        public static string newPrice { get; set; }


        public U_Reception()
        {
            InitializeComponent();
            pnlEdit.Height = 0;
            pnlEdit.Visible= false;

        }

        private void editPnl()
        {
            pnlEdit.Visible = false;
            pnlEdit.Height = 0;
            txtSearch.Clear();
            txtFName.Clear();
            txtLName.Clear();
            dtCheckin.Value = DateTime.Now;
            dtCheckout.Value = DateTime.Now;

            dbHelper db = new dbHelper();
            search = "";
            db.search(dataGridView3);
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            dbHelper db = new dbHelper();
            search = txtSearch.Text;

            db.search(dataGridView3);
            dataGridView3.Focus();
            db.getCustomerData();
        }



        private void U_Reception_Load(object sender, EventArgs e)
        {
            editPnl();
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            pnlEdit.Height = 707;
            pnlEdit.Location = new Point(0, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            editPnl();


        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
            MessageBox.Show("Test hahha454");
                    dataGridView3.CurrentRow.Selected = true;
                    bookingID = dataGridView3.Rows[e.RowIndex].Cells["Book ID"].FormattedValue.ToString();
                    txtFName.Text = dataGridView3.Rows[e.RowIndex].Cells["First Name"].FormattedValue.ToString();
                    txtLName.Text = dataGridView3.Rows[e.RowIndex].Cells["Last Name"].FormattedValue.ToString();
                    cBRmTyp.Text = dataGridView3.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
                    txtRNr.Text = dataGridView3.Rows[e.RowIndex].Cells["Room Nr"].FormattedValue.ToString();
                    dtCheckin.Text = dataGridView3.Rows[e.RowIndex].Cells["Check in"].FormattedValue.ToString();
                    dtCheckout.Text = dataGridView3.Rows[e.RowIndex].Cells["Check out"].FormattedValue.ToString();
                    Price = dataGridView3.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();

                    MessageBox.Show($"Test {dtCheckout.Text} hahhaa");
                    roomNr = Convert.ToInt32(txtRNr.Text);
                }
            }
            catch
            {

            }
        }

        

        private void btnCnl_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to CANCEL this \n " +
                                                  $"booking ID ---> {bookingID} \n" +
                                                  $"Full Name ----> {txtFName.Text} {txtLName.Text} \n",
                                                  "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                dbHelper dbHelper = new dbHelper();

                dbHelper.cancelBooking();
                editPnl();
            }
            else
            {
                
            }

           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FName = txtFName.Text;
            LName = txtLName.Text;
            type = (string)cBRmTyp.Text;
            newRoomNr = txtRNr.Text;
            checkIn = dtCheckin.Text;
            checkOut = dtCheckout.Text;

            TimeSpan diff = dtCheckout.Value.Subtract(dtCheckin.Value);
            double days = diff.TotalDays;

            int result = (int)Math.Round(days, 1, MidpointRounding.AwayFromZero);

            days = result;

            Days = days.ToString();

            int nights = Convert.ToInt32(days);

            int total = nights * (Convert.ToInt32(Price));
            newPrice = total.ToString();

            editPnl();


            dbHelper dbHelper = new dbHelper();

            dbHelper.editCustomer();
        }

        
    }

}
