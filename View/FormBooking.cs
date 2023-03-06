using Cosiness.Classes;
using Cosiness.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Cosiness.View
{
    public partial class FormBooking : Form
    {
        string roomID;
        public FormBooking(string roomID)
        {
            InitializeComponent();
            this.roomID = roomID;
        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            using (Models.HotelEntities db = new Models.HotelEntities())
            {
                textBoxRoomNumber.Text = roomID; ;
                textBoxRoomNumber.Enabled = false;
            }
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
