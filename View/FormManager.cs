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

namespace Cosiness.View
{
    public partial class FormManager : Form
    {
        private BindingSource category;
        private BindingSource status;
        public FormManager()
        {
            InitializeComponent();
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            comboBoxData.SelectedIndex = 0;
            using (Models.HotelEntities db = new Models.HotelEntities())
            {
                comboBoxRoomStatus.Enabled = true;
                comboBoxCategory.Enabled = true;
                numericUpDownQuantityOfPeople.Enabled = true;

                List<Models.Category> categories = db.Category.ToList();
                category = new BindingSource() { DataSource = categories };
                comboBoxCategory.DataSource = category;
                comboBoxCategory.DisplayMember = "CategoryName";
                var newCat = new Category() { CategoryName = "Все" };
                comboBoxCategory.ValueMember = "CategoryID";
                category.Insert(0, newCat);
                comboBoxCategory.SelectedIndex = 0;

                List<Models.Status> statuses = db.Status.ToList();
                status = new BindingSource() { DataSource = statuses };
                comboBoxRoomStatus.DataSource = status;
                comboBoxRoomStatus.DisplayMember = "StatusName";
                var newStatus = new Status() { StatusName = "Все" };
                comboBoxRoomStatus.ValueMember = "StatusID";
                status.Insert(0, newStatus);
                comboBoxRoomStatus.SelectedIndex = 0;

                dataGridViewData.Rows.Clear();
                LoadDataDrid();
            }
        }

        public static string picName;
        public static string path = Application.StartupPath + "/Pict/";
        public static Bitmap bitmap;
        private void LoadDataDrid()
        {
            dataGridViewData.Columns.Clear();
            dataGridViewData.Rows.Clear();

            using (Models.HotelEntities db = new Models.HotelEntities())
            {
                List<Models.Room> rooms = db.Room.ToList();
                List<Models.Category> category = db.Category.ToList();

                if (comboBoxData.SelectedIndex == 0)
                {
                    DataGridViewTextBoxColumn dgvID;
                    dgvID = new DataGridViewTextBoxColumn();
                    dataGridViewData.Columns.Add(dgvID);
                    dgvID.Visible = false;

                    DataGridViewImageColumn dgvPhoto;
                    dgvPhoto = new DataGridViewImageColumn();
                    dataGridViewData.Columns.Add(dgvPhoto);
                    dgvPhoto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvPhoto.Width = 150;
                    dgvPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;

                    DataGridViewTextBoxColumn dgvDesc;
                    dgvDesc = new DataGridViewTextBoxColumn();
                    dataGridViewData.Columns.Add(dgvDesc);

                    //Сортировка по категориям
                    if (comboBoxCategory.SelectedIndex == 1)
                        rooms = rooms.Where(x => (x.RoomCategoryID == 1)).ToList();
                    else if (comboBoxCategory.SelectedIndex == 2)
                        rooms = rooms.Where(x => (x.RoomCategoryID == 2)).ToList();
                    else if (comboBoxCategory.SelectedIndex == 3)
                        rooms = rooms.Where(x => (x.RoomCategoryID == 3)).ToList();
                    else if (comboBoxCategory.SelectedIndex == 4)
                        rooms = rooms.Where(x => (x.RoomCategoryID == 4)).ToList();
                    else if (comboBoxCategory.SelectedIndex == 5)
                        rooms = rooms.Where(x => (x.RoomCategoryID == 5)).ToList();
                    else if (comboBoxCategory.SelectedIndex == 6)
                        rooms = rooms.Where(x => (x.RoomCategoryID == 6)).ToList();

                    //Сортировка по статусу
                    if (comboBoxRoomStatus.SelectedIndex == 1)
                        rooms = rooms.Where(x => (x.StatusID == 1)).ToList();
                    else if (comboBoxRoomStatus.SelectedIndex == 2)
                        rooms = rooms.Where(x => (x.StatusID == 2)).ToList();
                    else if (comboBoxRoomStatus.SelectedIndex == 3)
                        rooms = rooms.Where(x => (x.StatusID == 3)).ToList();

                    //Сортировка по количеству гостей
                    int people = (int)numericUpDownQuantityOfPeople.Value;
                    if (people == 1)
                        rooms = rooms.Where(x => (x.QuantityOfPeople == 1)).ToList();
                    else if (people == 2)
                        rooms = rooms.Where(x => (x.QuantityOfPeople == 2)).ToList();
                    else if (people == 3)
                        rooms = rooms.Where(x => (x.QuantityOfPeople == 3)).ToList();
                    else if (people == 4)
                        rooms = rooms.Where(x => (x.QuantityOfPeople == 4)).ToList();

                    int i = 0;
                    foreach (var item in rooms)
                    {
                        dataGridViewData.Rows.Add();

                        dataGridViewData.Rows[i].Cells[0].Value = item.RoomID;

                        picName = item.Photo;

                        if (String.IsNullOrEmpty(picName))
                            dataGridViewData.Rows[i].Cells[1].Value = Properties.Resources.nophoto;
                        else
                        {
                            bitmap = new Bitmap(path + picName);
                            dataGridViewData.Rows[i].Cells[1].Value = bitmap;
                        }

                        dataGridViewData.Rows[i].Cells[2].Value =
                            $"Номер комнаты: {item.RoomID}" +
                            $"\nКатегория: {item.Category.CategoryName}" +
                            $"\nОписание: {item.Category.CategoryDescription}" +
                            $"\nВместимость номера: {item.QuantityOfPeople}" + " чел." +
                            $"\nСтоимость номера: {item.Cost}" + " руб.";
                        i++;
                    }
                }
                else if (comboBoxData.SelectedIndex == 1)
                {
                    DataGridViewTextBoxColumn dgvID;
                    dgvID = new DataGridViewTextBoxColumn();
                    dataGridViewData.Columns.Add(dgvID);
                    dataGridViewData.Columns[0].HeaderText = "ID";

                    DataGridViewTextBoxColumn dgvRoomID;
                    dgvRoomID = new DataGridViewTextBoxColumn();
                    dataGridViewData.Columns.Add(dgvRoomID);
                    dataGridViewData.Columns[1].HeaderText = "Room";

                    DataGridViewTextBoxColumn dgvFullName;
                    dgvFullName = new DataGridViewTextBoxColumn();
                    dataGridViewData.Columns.Add(dgvFullName);
                    dataGridViewData.Columns[2].HeaderText = "Fullname";

                    DataGridViewTextBoxColumn dgvPassport;
                    dgvPassport = new DataGridViewTextBoxColumn();
                    dataGridViewData.Columns.Add(dgvPassport);
                    dataGridViewData.Columns[3].HeaderText = "Passport";

                    DataGridViewTextBoxColumn dgvArrival;
                    dgvArrival = new DataGridViewTextBoxColumn();
                    dataGridViewData.Columns.Add(dgvArrival);
                    dataGridViewData.Columns[4].HeaderText = "Arrival date";

                    DataGridViewTextBoxColumn dgvDeparture;
                    dgvDeparture = new DataGridViewTextBoxColumn();
                    dataGridViewData.Columns.Add(dgvDeparture);
                    dataGridViewData.Columns[5].HeaderText = "Departure date";

                    DataGridViewTextBoxColumn dgvCost;
                    dgvCost = new DataGridViewTextBoxColumn();
                    dataGridViewData.Columns.Add(dgvCost);
                    dataGridViewData.Columns[6].HeaderText = "Cost";

                    dataGridViewData.ColumnHeadersVisible = true;
                    DataGridViewCellStyle style = dataGridViewData.ColumnHeadersDefaultCellStyle;
                    style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    List<Models.Booking> bookig = db.Booking.ToList();
                    List<Models.Guest> guest = db.Guest.ToList();
                    List<Models.Room> room = db.Room.ToList();

                    int i = 0;
                    foreach (var item in bookig)
                    {
                        dataGridViewData.Rows.Add();

                        dataGridViewData.Rows[i].Cells[0].Value = item.BookingID;
                        dataGridViewData.Rows[i].Cells[1].Value = item.RoomID;
                        dataGridViewData.Rows[i].Cells[2].Value = item.Guest.GuestFullName;
                        dataGridViewData.Rows[i].Cells[3].Value = item.Guest.Passport;
                        dataGridViewData.Rows[i].Cells[4].Value = item.ArrivalDate;
                        dataGridViewData.Rows[i].Cells[5].Value = item.DepartureDate;
                        dataGridViewData.Rows[i].Cells[6].Value = (item.DepartureDate - item.ArrivalDate).Days * item.Room.Cost;

                        i++;
                    }
                }
            }
        }

        private void comboBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (comboBoxData.SelectedIndex == 0)
                {
                    comboBoxRoomStatus.Enabled = true;
                    comboBoxCategory.Enabled = true;
                    numericUpDownQuantityOfPeople.Enabled = true;

                    textBoxName.Enabled = false;
                    dateTimePickerArrival.Enabled = false;
                    dateTimePickerDeparture.Enabled = false;
                }
                else if (comboBoxData.SelectedIndex == 1)
                {
                    comboBoxRoomStatus.Enabled = false;
                    comboBoxCategory.Enabled = false;
                    numericUpDownQuantityOfPeople.Enabled = false;

                    textBoxName.Enabled = true;
                    dateTimePickerArrival.Enabled = true;
                    dateTimePickerDeparture.Enabled = true;
                }
                LoadDataDrid();
        }
    }
}
