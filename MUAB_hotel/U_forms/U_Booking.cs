﻿using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI.Common;
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
    public partial class U_Booking : UserControl
    {
        
        
        
        public static  int adultCounter;
        public static  int childrenCounter;
        public static  int roomsCounter;
        public static  string roomsType;
        
        

        public U_Booking()
        {
            
            InitializeComponent();
            pnlSelectRoom.Height = 0;
            pnlSelectRoom.Visible = false;
            dtCheckout.MinDate = DateTime.Now;
            dtCheckin.MinDate = DateTime.Now;
            dtCheckout.Value = DateTime.Now;
            dtCheckin.Value = DateTime.Now;
        }

        #region - + buttons 

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (lbAdultCount.Text == "0")
            {

            }
            else if (lbAdultCount.Text != "0")
            {
                adultCounter -= 1;
                lbAdultCount.Text = adultCounter.ToString();
            }

        }


        private void btnChilNeg_Click(object sender, EventArgs e)
        {
            if (lbChildrenCount.Text == "0")
            {

            }
            else if (lbChildrenCount.Text != "0")
            {
                childrenCounter -= 1;
                lbChildrenCount.Text = childrenCounter.ToString();
            }
        }

        



     
        private void btnAdultPlus_Click(object sender, EventArgs e)
        {
            adultCounter += 1;
            lbAdultCount.Text = adultCounter.ToString();
        }

        private void btnChilPlus_Click(object sender, EventArgs e)
        {
            childrenCounter += 1;
            lbChildrenCount.Text = childrenCounter.ToString();
        }

        

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {

            dbHelper db = new dbHelper();

            // Check booking table if it was a available booking_id or create new one
            db.LastBookingId();
            if(dbHelper.checkIn != "0")
            {
                MessageBox.Show($"är null ids");
                db.newBookingid();
                db.LastBookingId();
            }
            


            // Check guests table if it was a available guests_id or create new one
            db.LastguestsId();
            if(dbHelper.guests_firstName != "0")
            {
                db.newGuestsId();
                db.LastguestsId();


            }

            



            txtCusId.Text = dbHelper.guestsId.ToString();
            txtBookId.Text = dbHelper.bookingId;

            int result = DateTime.Compare(dtCheckout.Value, dtCheckin.Value);

            if (cBRoomTy.SelectedItem.ToString().Contains("-Select  room type-"))
            {
                MessageBox.Show("Select a room type");
                cBRoomTy.ForeColor = Color.Red;
            }
            else
            {
                if (result != 0)
                {
                    roomsType = (string)cBRoomTy.SelectedItem;
                    pnlSelectRoom.Visible = true;
                    pnlSelectRoom.Height = 707;
                    pnlSelectRoom.Location = new Point(0, 0);
                    db.availableRooms(dataGridView1);
                    dataGridView1.Focus();
                }

                else
                {
                    MessageBox.Show("Change the date");
                }
 
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cBRoomTy.SelectedItem = "Select a room type";
            lbAdultCount.Text = "0";
            lbChildrenCount.Text = "0";
            dtCheckin.Value = DateTime.Now;
            dtCheckout.Value = DateTime.Now;

        }


        private void cBRoomTy_Click(object sender, EventArgs e)
        {
            cBRoomTy.ForeColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlSelectRoom.Visible=false;
            checkBox1.Checked = false;
            pnlSelectRoom.Height = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    txtRoomNr.Text = dataGridView1.Rows[e.RowIndex].Cells["Room Nr"].FormattedValue.ToString();
                    txtRoomType.Text = dataGridView1.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
                    decimal roomPrice = (decimal)dataGridView1.Rows[e.RowIndex].Cells["Price"].Value;
                    
                    
                    txtChIn.Text = dtCheckin.Text;
                    txtChOut.Text = dtCheckout.Text;

                    TimeSpan diff = dtCheckout.Value.Subtract(dtCheckin.Value);
                    double days = diff.TotalDays;

                    int result = (int)Math.Round(days, 1, MidpointRounding.AwayFromZero);

                    txtTotalNght.Text = result.ToString();



                    int nights = Convert.ToInt32(days);

                    decimal total = nights * roomPrice;
                    txtPrice.Text = total.ToString();

                    ;
                }
            }
            catch
            {

            }
            
        }

        private void U_Booking_Load(object sender, EventArgs e)
        {
            txtCusId.Enabled= false;
            txtBookId.Enabled= false;
            txtRoomNr.Enabled= false;
            txtRoomType.Enabled= false;
            txtTotalNght.Enabled= false;
            txtPrice.Enabled = false;
            txtChIn.Enabled= false;
            txtChOut.Enabled= false;
            btnBook.Enabled= false;

            
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            dbHelper db = new dbHelper();

            dbHelper.guests_firstName= txtFirstName.Text;
            dbHelper.guests_lastName = txtLastname.Text;
            dbHelper.guests_mobile = Convert.ToInt32( txtMobile.Text );
            dbHelper.guests_email = txtEmail.Text;
            dbHelper.roomType = txtRoomType.Text;
            dbHelper.checkIn = txtChIn.Text;
            dbHelper.checkOut = txtChOut.Text;
            dbHelper.roomsCapacity =Convert.ToInt32( lbAdultCount.Text + lbChildrenCount.Text);
            MessageBox.Show($"{dbHelper.roomsCapacity} people");

            dbHelper.roomNr = Convert.ToInt32( txtRoomNr.Text );
            dbHelper.totalDays = Convert.ToInt32( txtTotalNght.Text );
            dbHelper.totalPrice = Convert.ToDecimal( txtPrice.Text );

            dbHelper.roomStatus = "Booked";

            db.newGuest();
            db.newBooking();
            
            
            

            MessageBox.Show("booking success");


            pnlSelectRoom.Visible = false;
            pnlSelectRoom.Height = 0;
            dtCheckout.Value = DateTime.Now;
            dtCheckin.Value = DateTime.Now;
            cBRoomTy.SelectedItem = "-Select  room type-";
            lbAdultCount.Text = "0";
            lbChildrenCount.Text = "0";
            checkBox1.Checked = false;
            txtFirstName.Clear();
            txtLastname.Clear();
            txtMobile.Clear();
            txtEmail.Clear();




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                btnBook.Enabled = true;
            }
            else
            {
                btnBook.Enabled = true;
            }
        }
    }
}
