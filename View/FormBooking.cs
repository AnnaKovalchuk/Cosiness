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
        int roomID;
        DateTime arrival;
        DateTime departure;
        string fullname;
        string address;
        int idGuest;
        int cost;
        int idbooking;
        public FormBooking(int roomID, string arrival, string departure, string fullname, int idGuest, string address, int cost, int idbooking)
        {
            InitializeComponent();
            this.roomID = roomID;
            this.arrival = DateTime.Parse(arrival);
            this.departure = DateTime.Parse(departure);
            this.fullname = fullname;
            this.idGuest = idGuest;
            this.address = address;
            this.cost = cost;
            this.idbooking = idbooking;
        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            textBoxRoomNumber.Text = roomID.ToString(); 
            textBoxRoomNumber.Enabled = false;

            dateTimePickerArrival.Value = arrival;
            dateTimePickerDeparture.Value = departure;

            textBoxSurename.Text = fullname;
            textBoxCost.Text = cost.ToString();

            using (Models.HotelEntities db = new Models.HotelEntities())
            {
                List<Models.Guest> guest = db.Guest.Where(x => x.GuestID == idGuest).ToList();
                foreach(var passport in guest)
                {
                    textBoxPassport.Text = passport.Passport;
                }
                foreach (var address in guest)
                {
                    textBoxAddress.Text = address.Address;
                }
            }
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            using (Models.HotelEntities db = new Models.HotelEntities())
            {
                Guest guest = new Guest
                {
                    GuestFullName = textBoxSurename.Text,
                    Passport = textBoxPassport.Text,
                    Address = textBoxAddress.Text
                };
                db.Guest.Add(guest);
                db.SaveChanges();

                Booking booking = new Booking
                {
                    RoomID = Convert.ToInt32(textBoxRoomNumber.Text),
                    GuestID = (from m in db.Guest select m.GuestID).ToList().Last(),
                    ArrivalDate = dateTimePickerArrival.Value,
                    DepartureDate = dateTimePickerDeparture.Value,
                    StatusBookingID = 0
                };
                db.Booking.Add(booking);
                db.SaveChanges();

                var room = db.Room.Where(x => x.RoomID == roomID).FirstOrDefault();
                room.StatusID = 2;
                db.SaveChanges();
                db.SaveChanges();
            }

            FormAdmin formAdmin = new FormAdmin();
            Hide();
            formAdmin.ShowDialog();
            Show();
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            using (HotelEntities db = new HotelEntities())
            {
                var booking = db.Booking.Where(x => x.BookingID == idbooking).FirstOrDefault();
                booking.StatusBookingID = 1;
                db.SaveChanges();

                var room = db.Room.Where(x => x.RoomID == roomID).FirstOrDefault();
                room.StatusID = 1;
                db.SaveChanges();
                db.SaveChanges();
            }
            FormAdmin formAdmin = new FormAdmin();
            Hide();
            formAdmin.ShowDialog();
            Show();
        }

        private void dateTimePickerDeparture_ValueChanged(object sender, EventArgs e)
        {
            DateTime arr = dateTimePickerArrival.Value;
            DateTime dep = dateTimePickerDeparture.Value;

            int days = (dep - arr).Days;

            using (Models.HotelEntities db = new Models.HotelEntities())
            {
                var room = db.Room.Where(x => x.RoomID == roomID).FirstOrDefault();

                textBoxCost.Text = (days * room.Cost).ToString();
            }            
        }
    }
}
