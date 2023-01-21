using Google.Protobuf.WellKnownTypes;
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
        public static  int days;
        public static  string roomsType;
        
        

        public U_Booking()
        {
            
            InitializeComponent();

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

            //first name textbox error provider
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                txtFirstNameError.SetError(txtFirstName, "First name is required");
                pnlFirstName.BackColor = Color.Red;
            }
            else
            {
                txtFirstNameError.SetError(txtFirstName, string.Empty);
            }

            //last name textbox error provider
            if (string.IsNullOrEmpty(txtLastname.Text.Trim()))
            {
                txtLastnameError.SetError(txtLastname, "Last name is required");
                pnlLastname.BackColor = Color.Red;
            }
            else
            {
                txtLastnameError.SetError(txtLastname, string.Empty);
            }


            //Mobile textbox error provider

            if (string.IsNullOrEmpty(txtMobile.Text.Trim()))
            {
                txtMobileError.SetError(txtMobile, "Mobile is required");
                pnlMobile.BackColor = Color.Red;
            }
            else
            {
                txtMobileError.SetError(txtMobile, string.Empty);
            }

            //Email textbox error provider
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                txtEmailError.SetError(txtEmail, "Email is required");
                pnlEmail.BackColor = Color.Red;
            }
            else
            {
                txtEmailError.SetError(txtEmail, string.Empty);
            }


            //Room type combobox error provider
            if (cBRoomTy.SelectedItem.ToString().Contains("-Select room type-"))
            {
                cBRoomTyError.SetError(cBRoomTy, "Room type is required");
                pnlRoomTy.BackColor = Color.Red;
            }
            else
            {
                cBRoomTyError.SetError(cBRoomTy, string.Empty);

            }

            //checkin and out different days between if no different will errorprovide apperas
            DateTime checkin = dtCheckin.Value;
            DateTime checkout = dtCheckout.Value;

            TimeSpan diff = checkout - checkin;

            days = diff.Days;



            if (days > 0)
            {
                
                dtCheckinError.SetError(dtCheckin, string.Empty);
                dtCheckoutError.SetError(dtCheckout, string.Empty);

                
            }

            else 
            {
                //Check in/out error provider
                dtCheckinError.SetError(dtCheckin, "At least  one night is required");
                dtCheckoutError.SetError(dtCheckout, "At least  one night is required");
                pnlCheckin.BackColor = Color.Red;
                pnlCheckout.BackColor = Color.Red;
            }

            


            if (txtFirstName.Text != "" && txtLastname.Text != "" &&
                   txtMobile.Text != "" && txtEmail.Text != "" &&
                   cBRoomTy.SelectedItem.ToString() != "-Select room type-")
            {
                //calculate the different between the checkin and checkout 
                

                if (days > 0)
                {

                    // Check booking table if it was a available booking_id or create new one
                    db.LastBookingId();
                    if (dbHelper.checkIn != "0")
                    {
                        db.newBookingid();
                        db.LastBookingId();
                    }


                    // Check guests table if it was a available guests_id or create new one
                    db.LastguestsId();
                    if (dbHelper.guests_firstName != "0")
                    {
                        db.newGuestsId();
                        db.LastguestsId();

                    }

                    
                    txtCusId.Text = dbHelper.guestsId.ToString();
                    txtBookId.Text = dbHelper.bookingId;


                    roomsType = (string)cBRoomTy.SelectedItem;
                    pnlSelectRoom.Visible = true;
                    pnlSelectRoom.Height = 707;
                    pnlSelectRoom.Location = new Point(0, 0);
                    db.availableRooms(dataGridView1);
                    dataGridView1.Focus();
                }

                else 
                {
                    //Check in/out error provider
                    dtCheckinError.SetError(dtCheckin, "At least  one night is required");
                    dtCheckoutError.SetError(dtCheckout, "At least  one night is required");
                    pnlCheckin.BackColor = Color.Red;
                    pnlCheckout.BackColor = Color.Red;
                }
            }
            else
            {
                lberror.Text = "*Please fill in the required field";
            }

            

            

            // Check booking table if it was a available booking_id or create new one
            db.LastBookingId();
            if(dbHelper.checkIn != "0")
            {
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

            

            
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            txtFirstName.Text = "";
            txtLastname.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            cBRoomTy.SelectedItem = "-Select room type-";
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
            txtFirstName.Focus();
            pnlSelectRoom.Height = 0;
            pnlSelectRoom.Visible = false;
            txtCusId.Enabled= false;
            txtBookId.Enabled= false;
            txtRoomNr.Enabled= false;
            txtRoomType.Enabled= false;
            txtTotalNght.Enabled= false;
            txtPrice.Enabled = false;
            txtChIn.Enabled= false;
            txtChOut.Enabled= false;
            btnBook.Enabled= false;

            dtCheckin.MinDate = DateTime.Now.Date;
            dtCheckout.MinDate = DateTime.Now.Date;
            
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            
            try
            {
                dbHelper db = new dbHelper();

                dbHelper.guests_firstName = txtFirstName.Text;
                dbHelper.guests_lastName = txtLastname.Text;
                dbHelper.guests_mobile = txtMobile.Text;
                dbHelper.guests_email = txtEmail.Text;
                dbHelper.roomType = txtRoomType.Text;
                dbHelper.checkIn = txtChIn.Text;
                dbHelper.checkOut = txtChOut.Text;
                dbHelper.roomsCapacity = Convert.ToInt32(lbAdultCount.Text + lbChildrenCount.Text);

                dbHelper.roomNr = Convert.ToInt32(txtRoomNr.Text);
                dbHelper.totalDays = Convert.ToInt32(txtTotalNght.Text);
                dbHelper.totalPrice = Convert.ToDecimal(txtPrice.Text);

                dbHelper.roomStatus = "Booked";
                db.newGuest();
                db.newBooking();




                MessageBox.Show("booking success");
                btnCancel_Click(sender, e);
                btnReset_Click(sender, e);

            }
            catch
            {
                MessageBox.Show("not booked");
            }





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

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            pnlFirstName.BackColor = Color.DodgerBlue;
            txtFirstNameError.SetError(txtFirstName, string.Empty);
            lberror.Visible = false;
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            pnlLastname.BackColor = Color.DodgerBlue;
            txtLastnameError.SetError(txtLastname, string.Empty);
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            pnlMobile.BackColor = Color.DodgerBlue;
            txtMobileError.SetError(txtMobile, string.Empty);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.DodgerBlue;
            txtEmailError.SetError(txtEmail, string.Empty);
        }

        private void cBRoomTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlRoomTy.BackColor = Color.DodgerBlue;
            cBRoomTyError.SetError(cBRoomTy, string.Empty);
        }

        private void dtCheckin_ValueChanged(object sender, EventArgs e)
        {
            pnlCheckin.BackColor = Color.DodgerBlue;
            dtCheckinError.SetError(dtCheckin, string.Empty);
        }
        

        private void dtCheckout_ValueChanged(object sender, EventArgs e)
        {
            pnlCheckin.BackColor = Color.DodgerBlue;
            pnlCheckout.BackColor = Color.DodgerBlue;
            dtCheckinError.SetError(dtCheckin, string.Empty);
            dtCheckinError.SetError(dtCheckout, string.Empty);
        }

    }
}
