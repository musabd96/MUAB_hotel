using DocumentFormat.OpenXml.Bibliography;
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
        public static string bookingId { get; set; }
        public static int guestId { get; set; }
        public static string roomStatus { get; set; }
        public static string Days { get; set; }
        public static decimal Price { get; set; }
        public static string newPrice { get; set; }

        //dbHelper1 db = new dbHelper1();
        dbHelper dbHelper = new dbHelper();
        Chech_in_out inout = new Chech_in_out();

        public U_Reception()
        {
            InitializeComponent();
            
        }


        internal void U_Reception_Load(object sender, EventArgs e)
        {
            pBsearch_Click(sender, e);
            txtSearch.Focus();
            pBl.Visible = false;
            pBX.Visible = false;
            DataGridViewColumn Edit = dataGridView3.Columns[0];
            Edit.DisplayIndex = dataGridView3.ColumnCount - 1;
            Edit.Width = 50;
            
            DataGridViewColumn X = dataGridView3.Columns[1];
            X.DisplayIndex = dataGridView3.ColumnCount - 1;
            X.Width = 40;

            Select.Width = 45;
            btnChIn.Enabled = false;
            btnChOut.Enabled = false;
            btnService.Enabled = false;


        }


        #region Buttons

        
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            txtSearch.ForeColor = Color.Black;

            if (e.KeyCode == Keys.Enter)
            {

                dbHelper.searchBooking(dataGridView3);
                dataGridView3.Focus();

                if (dataGridView3.RowCount == 0)
                {
                    MessageBox.Show($"NOT FOUND (-> {txtSearch.Text} <-)" +
                        $" \nIN THE SYSTEM \n\n TRY AGAIN!!!");
                    txtSearch.ForeColor = Color.Red;
                    txtSearch.SelectAll();
                    txtSearch.Focus();

                }

            }
            
            
            
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search = txtSearch.Text;
            if(txtSearch.Text != "")
            {
                pBX.Visible = true;
                pBl.Visible = true;
            }
            else
            {
                pBX.Visible = false;
                pBl.Visible = false;
                
            }
            dbHelper.searchBooking(dataGridView3);
            dataGridView3.Focus();


            txtSearch.Focus();
            
        }



        //Check in button
        private void btnChIn_Click(object sender, EventArgs e)
        {
            
            if (roomNr == 0)
            {
                MessageBox.Show("Select a guest");
                
            }
            else
            {
                
                roomStatus = "CheckIn";
                Chech_in_out.message = "Check in?";
                inout.ShowDialog();
                pBsearch_Click(sender, e);
            }

            roomNr = 0;
            MessageBox.Show($"{roomNr}");
            btnChIn.Enabled = false;
            btnChOut.Enabled = false;
            btnService.Enabled = false;



        }

        //Check out button
        private void btnChOut_Click(object sender, EventArgs e)
        {
            
            if (roomNr == 0 )
            {
                MessageBox.Show("Select a guest");
            }
            else
            {
                
                roomStatus = "CheckOut";
                Chech_in_out.message = "Check out?";
                inout.ShowDialog();
                pBsearch_Click(sender, e);
            }

            roomNr = 0;
            MessageBox.Show($"{roomNr}");
            btnChIn.Enabled = false;
            btnChOut.Enabled = false;
            btnService.Enabled = false;


        }
        private void btnService_Click(object sender, EventArgs e)
        {
            if (roomNr == 0)
            {
                MessageBox.Show("Select a guest");
            }
            else
            {

                roomStatus = "Room Service";
                Chech_in_out.message = "Room Service?";
                inout.ShowDialog();
                pBsearch_Click(sender, e);
            }

            roomNr = 0;
            MessageBox.Show($"{roomNr}");
            btnChIn.Enabled = false;
            btnChOut.Enabled = false;
            btnService.Enabled = false;
        }

        #endregion




        #region Datagredview
        //datagredview
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            

            
        }


        #endregion

        private void pBsearch_Click(object sender, EventArgs e)
        {
            search = txtSearch.Text;
            dbHelper.searchBooking(dataGridView3);
            dataGridView3.Focus();
        }

        private void pBX_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            pBX.Visible = false;
            pBl.Visible = false;
        }

        private void dataGridView3_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {

                // Uncheck all other checkboxes in the same column
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        DataGridViewCheckBoxCell otherCell = (DataGridViewCheckBoxCell)row.Cells[e.ColumnIndex];
                        otherCell.Value = false;

                    }
                }


                dataGridView3.CurrentRow.Selected = true;
                bookingId = dataGridView3.Rows[e.RowIndex].Cells["bookId"].FormattedValue.ToString();
                FName = dataGridView3.Rows[e.RowIndex].Cells["firstName"].FormattedValue.ToString();
                LName = dataGridView3.Rows[e.RowIndex].Cells["lastName"].FormattedValue.ToString();
                type = dataGridView3.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
                string roomnr = dataGridView3.Rows[e.RowIndex].Cells["roomNr"].FormattedValue.ToString();
                checkIn = dataGridView3.Rows[e.RowIndex].Cells["check In"].FormattedValue.ToString();
                checkOut = dataGridView3.Rows[e.RowIndex].Cells["check Out"].FormattedValue.ToString();
                roomStatus = dataGridView3.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
                roomNr = Convert.ToInt32(roomnr);
                dbHelper.getGuest();
                btnChIn.Enabled = true;
                btnChOut.Enabled = true;
                btnService.Enabled = true;
            }


            if (dataGridView3.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                if (roomNr == 0)
                {
                    MessageBox.Show("Select a guest");
                    btnChIn.Enabled = false;
                    btnChOut.Enabled = false;
                    btnService.Enabled = false;
                }
                else
                {
                    Update update = new Update();


                    update.ShowDialog();

                    pBsearch_Click(sender, e);
                }

                roomNr = 0;
                btnChIn.Enabled = false;
                btnService.Enabled = false;




            }
            else if (dataGridView3.Columns[e.ColumnIndex].HeaderText == "X")
            {
                if (roomNr == 0)
                {
                    MessageBox.Show("Select a guest");
                    
                }
                else
                {
                    Chech_in_out.message = "Cancelled?";
                    inout.ShowDialog();
                    pBsearch_Click(sender, e);
                }

                



            }





        }

       
    }

}
