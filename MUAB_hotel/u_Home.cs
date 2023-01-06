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
        public static int roomsNr;
        public static string roomStatus;

        dbHelper db = new dbHelper();
        public u_Home()
        {
            InitializeComponent();

            
        }

        private void u_Home_Load(object sender, EventArgs e)
        {
            btn1_Click(sender, e);
            
            
            

        }

        #region Buttons 1 - 7 As building levels

        

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Enabled = false;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            lb1.Text = "101";
            roomsNr = 101;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl1.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl1.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl1.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl1.BackColor = Color.Green;

            }


            lb2.Text = "102";
            roomsNr = 102;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl2.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl2.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl2.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl2.BackColor = Color.Green;

            }

            lb3.Text = "103";
            roomsNr = 103;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl3.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl3.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl3.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl3.BackColor = Color.Green;

            }

            lb4.Text = "104";

            roomsNr = 104;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl4.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl4.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl4.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl4.BackColor = Color.Green;

            }

            lb5.Text = "105";

            roomsNr = 105;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl5.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl5.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl5.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl5.BackColor = Color.Green;

            }

            lb6.Text = "106";
            roomsNr = 106;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl6.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl6.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl6.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl6.BackColor = Color.Green;

            }

            lb7.Text = "107";
            roomsNr = 107;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl7.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl7.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl7.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl7.BackColor = Color.Green;

            }

            lb8.Text = "108";

            roomsNr = 108;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl8.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl8.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl8.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl8.BackColor = Color.Green;

            }
            lb9.Text = "109";

            roomsNr = 109;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl9.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl9.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl9.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl9.BackColor = Color.Green;

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2.Enabled = false;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            lb1.Text = "201";
            roomsNr = 201;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl1.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl1.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl1.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl1.BackColor = Color.Green;

            }


            lb2.Text = "202";
            roomsNr = 202;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl2.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl2.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl2.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl2.BackColor = Color.Green;

            }

            lb3.Text = "203";
            roomsNr = 203;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl3.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl3.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl3.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl3.BackColor = Color.Green;

            }

            lb4.Text = "204";

            roomsNr = 204;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl4.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl4.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl4.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl4.BackColor = Color.Green;

            }

            lb5.Text = "205";

            roomsNr = 205;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl5.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl5.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl5.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl5.BackColor = Color.Green;

            }

            lb6.Text = "206";
            roomsNr = 206;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl6.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl6.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl6.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl6.BackColor = Color.Green;

            }

            lb7.Text = "207";
            roomsNr = 207;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl7.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl7.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl7.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl7.BackColor = Color.Green;

            }

            lb8.Text = "208";

            roomsNr = 208;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl8.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl8.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl8.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl8.BackColor = Color.Green;

            }
            lb9.Text = "209";

            roomsNr = 209;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl9.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl9.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl9.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl9.BackColor = Color.Green;

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = false;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;

            lb1.Text = "301";
            roomsNr = 301;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl1.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl1.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl1.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl1.BackColor = Color.Green;

            }


            lb2.Text = "302";
            roomsNr = 302;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl2.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl2.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl2.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl2.BackColor = Color.Green;

            }

            lb3.Text = "303";
            roomsNr = 303;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl3.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl3.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl3.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl3.BackColor = Color.Green;

            }

            lb4.Text = "304";

            roomsNr = 304;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl4.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl4.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl4.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl4.BackColor = Color.Green;

            }

            lb5.Text = "305";

            roomsNr = 305;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl5.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl5.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl5.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl5.BackColor = Color.Green;

            }

            lb6.Text = "306";
            roomsNr = 306;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl6.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl6.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl6.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl6.BackColor = Color.Green;

            }

            lb7.Text = "307";
            roomsNr = 307;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl7.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl7.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl7.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl7.BackColor = Color.Green;

            }

            lb8.Text = "308";

            roomsNr = 308;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl8.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl8.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl8.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl8.BackColor = Color.Green;

            }
            lb9.Text = "309";

            roomsNr = 309;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl9.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl9.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl9.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl9.BackColor = Color.Green;

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = false;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            lb1.Text = "401";
            roomsNr = 401;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl1.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl1.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl1.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl1.BackColor = Color.Green;

            }


            lb2.Text = "402";
            roomsNr = 402;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl2.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl2.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl2.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl2.BackColor = Color.Green;

            }

            lb3.Text = "403";
            roomsNr = 403;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl3.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl3.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl3.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl3.BackColor = Color.Green;

            }

            lb4.Text = "404";

            roomsNr = 404;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl4.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl4.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl4.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl4.BackColor = Color.Green;

            }

            lb5.Text = "405";

            roomsNr = 405;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl5.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl5.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl5.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl5.BackColor = Color.Green;

            }

            lb6.Text = "406";
            roomsNr = 406;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl6.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl6.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl6.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl6.BackColor = Color.Green;

            }

            lb7.Text = "407";
            roomsNr = 407;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl7.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl7.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl7.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl7.BackColor = Color.Green;

            }

            lb8.Text = "408";

            roomsNr = 408;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl8.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl8.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl8.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl8.BackColor = Color.Green;

            }
            lb9.Text = "409";

            roomsNr = 409;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl9.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl9.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl9.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl9.BackColor = Color.Green;

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = false;
            btn6.Enabled = true;
            btn7.Enabled = true;
            lb1.Text = "501";
            roomsNr = 501;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl1.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl1.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl1.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl1.BackColor = Color.Green;

            }


            lb2.Text = "502";
            roomsNr = 502;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl2.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl2.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl2.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl2.BackColor = Color.Green;

            }

            lb3.Text = "503";
            roomsNr = 503;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl3.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl3.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl3.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl3.BackColor = Color.Green;

            }

            lb4.Text = "504";

            roomsNr = 504;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl4.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl4.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl4.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl4.BackColor = Color.Green;

            }

            lb5.Text = "505";

            roomsNr = 505;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl5.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl5.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl5.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl5.BackColor = Color.Green;

            }

            lb6.Text = "506";
            roomsNr = 506;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl6.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl6.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl6.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl6.BackColor = Color.Green;

            }

            lb7.Text = "507";
            roomsNr = 507;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl7.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl7.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl7.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl7.BackColor = Color.Green;

            }

            lb8.Text = "508";

            roomsNr = 508;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl8.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl8.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl8.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl8.BackColor = Color.Green;

            }
            lb9.Text = "509";

            roomsNr = 509;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl9.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl9.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl9.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl9.BackColor = Color.Green;

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = false;
            btn7.Enabled = true;
            lb1.Text = "601";
            roomsNr = 601;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl1.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl1.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl1.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl1.BackColor = Color.Green;

            }


            lb2.Text = "602";
            roomsNr = 602;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl2.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl2.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl2.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl2.BackColor = Color.Green;

            }

            lb3.Text = "603";
            roomsNr = 603;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl3.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl3.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl3.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl3.BackColor = Color.Green;

            }

            lb4.Text = "604";

            roomsNr = 604;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl4.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl4.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl4.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl4.BackColor = Color.Green;

            }

            lb5.Text = "605";

            roomsNr = 605;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl5.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl5.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl5.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl5.BackColor = Color.Green;

            }

            lb6.Text = "606";
            roomsNr = 606;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl6.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl6.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl6.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl6.BackColor = Color.Green;

            }

            lb7.Text = "607";
            roomsNr = 607;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl7.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl7.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl7.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl7.BackColor = Color.Green;

            }

            lb8.Text = "608";

            roomsNr = 608;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl8.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl8.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl8.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl8.BackColor = Color.Green;

            }
            lb9.Text = "609";

            roomsNr = 609;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl9.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl9.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl9.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl9.BackColor = Color.Green;

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = false;
            lb1.Text = "701";
            roomsNr = 701;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl1.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl1.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl1.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl1.BackColor = Color.Green;

            }


            lb2.Text = "702";
            roomsNr = 702;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl2.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl2.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl2.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl2.BackColor = Color.Green;

            }

            lb3.Text = "703";
            roomsNr = 703;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl3.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl3.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl3.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl3.BackColor = Color.Green;

            }

            lb4.Text = "704";

            roomsNr = 704;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl4.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl4.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl4.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl4.BackColor = Color.Green;

            }

            lb5.Text = "705";

            roomsNr = 705;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl5.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl5.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl5.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl5.BackColor = Color.Green;

            }

            lb6.Text = "706";
            roomsNr = 706;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl6.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl6.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl6.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl6.BackColor = Color.Green;

            }

            lb7.Text = "707";
            roomsNr = 707;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl7.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl7.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl7.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl7.BackColor = Color.Green;

            }

            lb8.Text = "708";

            roomsNr = 708;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl8.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl8.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl8.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl8.BackColor = Color.Green;

            }
            lb9.Text = "709";

            roomsNr = 709;
            db.roomSt();
            if (roomStatus == "Booked")
            {
                pnl9.BackColor = Color.Gray;
            }
            else if (roomStatus == "ChechIn")
            {
                pnl9.BackColor = Color.Orange;

            }
            else if (roomStatus == "ChechOut")
            {
                pnl9.BackColor = Color.Red;

            }
            else if (roomStatus == "Available")
            {
                pnl9.BackColor = Color.Green;

            }
        }


        #endregion

        private void pnl1_Click(object sender, EventArgs e)
        {
            
            if(pnl1.BackColor != Color.Green)
            {
                roomsNr = Convert.ToInt32(lb1.Text);
                db.homeView(dataGridView4);
            }
            else
            {
                MessageBox.Show($"This room is AVAILABLE");
            }
        }

        private void pnl2_Click(object sender, EventArgs e)
        {
            if (pnl2.BackColor != Color.Green)
            {
                roomsNr = Convert.ToInt32(lb2.Text);
                db.homeView(dataGridView4);
            }
            else
            {
                MessageBox.Show($"This room is AVAILABLE");
            }
        }

        private void pnl3_Click(object sender, EventArgs e)
        {
            if (pnl3.BackColor != Color.Green)
            {
                roomsNr = Convert.ToInt32(lb3.Text);
                db.homeView(dataGridView4);
            }
            else
            {
                MessageBox.Show($"This room is AVAILABLE");
            }
        }

        private void pnl4_Click(object sender, EventArgs e)
        {
            if (pnl4.BackColor != Color.Green)
            {
                roomsNr = Convert.ToInt32(lb4.Text);
                db.homeView(dataGridView4);
            }
            else
            {
                MessageBox.Show($"This room is AVAILABLE");
            }
        }

        private void pnl5_Click(object sender, EventArgs e)
        {
            if (pnl5.BackColor != Color.Green)
            {
                roomsNr = Convert.ToInt32(lb5.Text);
                db.homeView(dataGridView4);
            }
            else
            {
                MessageBox.Show($"This room is AVAILABLE");
            }
        }

        private void pnl6_Click(object sender, EventArgs e)
        {
            if (pnl6.BackColor != Color.Green)
            {
                roomsNr = Convert.ToInt32(lb6.Text);
                db.homeView(dataGridView4);
            }
            else
            {
                MessageBox.Show($"This room is AVAILABLE");
            }
        }

        private void pnl7_Click(object sender, EventArgs e)
        {
            if (pnl7.BackColor != Color.Green)
            {
                roomsNr = Convert.ToInt32(lb7.Text);
                db.homeView(dataGridView4);
            }
            else
            {
                MessageBox.Show($"This room is AVAILABLE");
            }
        }

        private void pnl8_Click(object sender, EventArgs e)
        {
            if (pnl8.BackColor != Color.Green)
            {
                roomsNr = Convert.ToInt32(lb8.Text);
                db.homeView(dataGridView4);
            }
            else
            {
                MessageBox.Show($"This room is AVAILABLE");
            }
        }

        private void pnl9_Click(object sender, EventArgs e)
        {
            if (pnl9.BackColor != Color.Green)
            {
                roomsNr = Convert.ToInt32(lb9.Text);
                db.homeView(dataGridView4);
            }
            else
            {
                MessageBox.Show($"This room is AVAILABLE");
            }
        }
    }
}
