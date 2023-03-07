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
        public string search;

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

                    //Сортировка по цене
                    if (comboBoxCost.SelectedIndex == 0)
                        rooms = rooms.OrderByDescending(x => x.Cost).ToList();
                    else if (comboBoxCost.SelectedIndex == 1)
                        rooms = rooms.OrderBy(x => x.Cost).ToList();

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

                    labelCount.Text = "Количество записей: " + rooms.Count;
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

                    DataGridViewTextBoxColumn dgvIDguest;
                    dgvIDguest = new DataGridViewTextBoxColumn();
                    dataGridViewData.Columns.Add(dgvIDguest);
                    dataGridViewData.Columns[7].Visible = false;
                    dataGridViewData.Columns[7].HeaderText = "IDguest";

                    DataGridViewTextBoxColumn dgvAddress;
                    dgvAddress = new DataGridViewTextBoxColumn();
                    dataGridViewData.Columns.Add(dgvAddress);
                    dataGridViewData.Columns[8].Visible = false;
                    dataGridViewData.Columns[8].HeaderText = "Address";

                    dataGridViewData.ColumnHeadersVisible = true;
                    DataGridViewCellStyle style = dataGridViewData.ColumnHeadersDefaultCellStyle;
                    style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    List<Models.Booking> bookig = db.Booking.ToList();
                    List<Models.Guest> guest = db.Guest.ToList();
                    List<Models.Room> room = db.Room.ToList();

                    //Поиск
                    if (search != null)
                    {
                        guest = guest.Where(x => x.GuestFullName.Contains(search)).ToList();
                    }

                    int i = 0;
                    int j = 0;
                    foreach (var item in bookig)
                    {
                        dataGridViewData.Rows.Add();

                        dataGridViewData.Rows[i].Cells[0].Value = item.BookingID;
                        dataGridViewData.Rows[i].Cells[1].Value = item.RoomID;
                        if (search != null)
                        {
                            foreach (var name in guest)
                            {
                                dataGridViewData.Rows[j].Cells[2].Value = name.GuestFullName;
                                dataGridViewData.Rows[i].Cells[3].Value = item.Guest.Passport;
                                dataGridViewData.Rows[i].Cells[4].Value = item.ArrivalDate;
                                dataGridViewData.Rows[i].Cells[5].Value = item.DepartureDate;
                                dataGridViewData.Rows[i].Cells[6].Value = (item.DepartureDate - item.ArrivalDate).Days * item.Room.Cost;
                                dataGridViewData.Rows[i].Cells[7].Value = item.GuestID;
                                dataGridViewData.Rows[i].Cells[8].Value = item.Guest.Address;
                                if (item.StatusBookingID == 1)
                                    dataGridViewData.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                                if (j == guest.Count - 1)
                                    return;
                            }
                        }
                        else
                            dataGridViewData.Rows[i].Cells[2].Value = item.Guest.GuestFullName;
                        dataGridViewData.Rows[i].Cells[3].Value = item.Guest.Passport;
                        dataGridViewData.Rows[i].Cells[4].Value = item.ArrivalDate;
                        dataGridViewData.Rows[i].Cells[5].Value = item.DepartureDate;
                        dataGridViewData.Rows[i].Cells[6].Value = (item.DepartureDate - item.ArrivalDate).Days * item.Room.Cost;
                        dataGridViewData.Rows[i].Cells[7].Value = item.GuestID;
                        dataGridViewData.Rows[i].Cells[8].Value = item.Guest.Address;
                        if (item.StatusBookingID == 1)
                            dataGridViewData.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;

                        i++;
                        j++;
                    }

                    labelCount.Text = "Количество записей: " + bookig.Count;
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

        private void comboBoxRoomStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Clear();
            LoadDataDrid();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            search = textBoxName.Text;
            dataGridViewData.Rows.Clear();
            LoadDataDrid();
        }

        private void numericUpDownQuantityOfPeople_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Clear();
            LoadDataDrid();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Clear();
            LoadDataDrid();
        }

        private void dateTimePickerArrival_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Clear();
            LoadDataDrid();
        }

        private void dateTimePickerDeparture_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Clear();
            LoadDataDrid();
        }

        private void comboBoxCost_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Clear();
            LoadDataDrid();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            FormReport report = new FormReport();
            Hide();
            report.ShowDialog();
            Show();
        }
    }
}
