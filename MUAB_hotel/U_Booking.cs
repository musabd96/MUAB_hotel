using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            pnlSelectRoom.Height = 10;
            dateTimePicker2.MinDate = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;
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
            int result = DateTime.Compare(dateTimePicker2.Value, dateTimePicker1.Value);

            if (cBRoomTy.SelectedItem.ToString().Contains(" "))
            {
                MessageBox.Show("Select a room type");
                cBRoomTy.ForeColor = Color.Red;
            }
            else
            {
                if (result != 0)
                {
                    MessageBox.Show("ok");
                    roomsType = (string)cBRoomTy.SelectedItem;
                    dbHelper db = new dbHelper();
                    pnlSelectRoom.Height = 595;
                    pnlSelectRoom.Location = new Point(0, 109);
                    db.getData(dataGridView1);
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
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

        }


        private void cBRoomTy_Click(object sender, EventArgs e)
        {
            cBRoomTy.ForeColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlSelectRoom.Height = 10;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtRoomNr.Text = dataGridView1.Rows[e.RowIndex].Cells["rooms_nr"].FormattedValue.ToString();
                txtRoomType.Text = dataGridView1.Rows[e.RowIndex].Cells["rooms_type"].FormattedValue.ToString();
                string roomPrice = dataGridView1.Rows[e.RowIndex].Cells["rooms_price"].FormattedValue.ToString() ;

                txtChIn.Text = dateTimePicker2.Text;
                txtChOut.Text = dateTimePicker1.Text;

                TimeSpan diff = dateTimePicker2.Value.Subtract(dateTimePicker1.Value);
                double days = diff.TotalDays;
                txtTotalNght.Text = days.ToString();

                int nights = Convert.ToInt32(txtTotalNght.Text);

                int total = nights * (Convert.ToInt32(roomPrice));
                txtPrice.Text = total.ToString();
;            }
        }
    }
}
