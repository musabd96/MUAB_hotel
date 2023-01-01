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
        public static string roomsStatus;

        public u_Home()
        {
            InitializeComponent();
        }

        private void u_Home_Load(object sender, EventArgs e)
        {

            roomsStatus = "King";
            dbHelper dbKing = new dbHelper();
            dbKing.showRoom(dgvKing);
            
            roomsStatus = "Ocean View";
            dbHelper dbOceanView = new dbHelper();
            dbOceanView.showRoom(dgvOceanView);
            
            roomsStatus = "Garden View";
            dbHelper dbGardenView = new dbHelper();
            dbGardenView.showRoom(dgvGardenView);
            
            roomsStatus = "Balcony";
            dbHelper dbBalcony = new dbHelper();
            dbBalcony.showRoom(dgvBalcony);
            
            roomsStatus = "Double";
            dbHelper dbDouble = new dbHelper();
            dbDouble.showRoom(dgvDouble);
            
            roomsStatus = "Family";
            dbHelper dbFamily = new dbHelper();
            dbFamily.showRoom(dgvFamily);
            
            roomsStatus = "Single";
            dbHelper dbSingle = new dbHelper();
            dbSingle.showRoom(dgvSingle);

        }

    }
}
