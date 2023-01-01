using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MUAB_hotel
{
    public partial class U_Reception : UserControl
    {
        public static string search { get; set; }
        public static string FName { get; set; }
        public static int roomNr { get; set; }
        public static int newRoomNr { get; set; }
        public static string type { get; set; }
        public static string LName { get; set; }
        public static string checkIn { get; set; }
        public static string checkOut { get; set; }
        public static string bookingID { get; set; }
        public static int customersID { get; set; }
        public static string Days { get; set; }
        public static string Price { get; set; }
        public static string newPrice { get; set; }

        dbHelper db = new dbHelper();

        public U_Reception()
        {
            InitializeComponent();
            

        }

        

        private void btnSeach_Click(object sender, EventArgs e)
        {



            try
            {
                search = txtSearch.Text;

                db.search(dataGridView3);
                dataGridView3.Focus();
                db.getCustomerData();

                if (dataGridView3.RowCount == 0)
                {
                    MessageBox.Show("Not Found it");
                    txtSearch.ForeColor = Color.Red;
                    txtSearch.SelectAll();
                    txtSearch.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Invalid Field");

            }

            
        }



        internal void U_Reception_Load(object sender, EventArgs e)
        {

            db.search(dataGridView3);
            dataGridView3.Focus();
          
            DataGridViewColumn Edit = dataGridView3.Columns[0];
            Edit.DisplayIndex = dataGridView3.ColumnCount - 1;
            Edit.Width = 50;
            
            DataGridViewColumn Delete = dataGridView3.Columns[1];
            Delete.DisplayIndex = dataGridView3.ColumnCount - 1;
            Edit.Width = 50;
            
        }





        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            txtSearch.ForeColor = Color.Black;

            if (e.KeyCode == Keys.Enter)
            {
                btnSeach_Click(sender, e);


            }
            
            
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView3.CurrentRow.Selected = true;
            bookingID = dataGridView3.Rows[e.RowIndex].Cells["Book ID"].FormattedValue.ToString();
            FName = dataGridView3.Rows[e.RowIndex].Cells["First Name"].FormattedValue.ToString();
            LName = dataGridView3.Rows[e.RowIndex].Cells["Last Name"].FormattedValue.ToString();
            type = dataGridView3.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
            string roomnr = dataGridView3.Rows[e.RowIndex].Cells["Room Nr"].FormattedValue.ToString();
            checkIn = dataGridView3.Rows[e.RowIndex].Cells["Check in"].FormattedValue.ToString();
            checkOut = dataGridView3.Rows[e.RowIndex].Cells["Check out"].FormattedValue.ToString();
            roomNr = Convert.ToInt32(roomnr);


            if (dataGridView3.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                
                Update update = new Update();

                
                update.ShowDialog();

                btnSeach_Click(sender, e);


            }
            else if (dataGridView3.Columns[e.ColumnIndex].HeaderText == "Cancel")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to CANCEL this \n " +
                                                  $"booking ID ---> {bookingID} \n" +
                                                  $"Full Name ----> {FName} {LName} \n",
                                                  "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dbHelper dbHelper = new dbHelper();

                    dbHelper.cancelBooking();
                    txtSearch.Text = "";
                    btnSeach_Click(sender, e);

                }
                else
                {

                }
            }


        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            

            e.CellStyle.ForeColor = Color.Green;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
