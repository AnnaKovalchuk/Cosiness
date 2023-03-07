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
using System.Windows.Forms.DataVisualization.Charting;

namespace Cosiness.View
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            int free = 0;
            int busy = 0;
            int remont = 0;

            chartBooking.Series.Clear();
            // Форматировать диаграмму
            chartBooking.BackColor = Color.Gray;
            chartBooking.BackSecondaryColor = Color.WhiteSmoke;
            chartBooking.BackGradientStyle = GradientStyle.DiagonalRight;

            chartBooking.BorderlineDashStyle = ChartDashStyle.Solid;
            chartBooking.BorderlineColor = Color.Gray;
            chartBooking.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            // Форматировать область диаграммы
            chartBooking.ChartAreas[0].BackColor = Color.Wheat;

            chartBooking.Titles.Add("Диаграмма загруженности");
            chartBooking.Titles[0].Font = new Font("Candara Light", 10);

            chartBooking.Series.Add(new Series("ColumnSeries")
            {
                ChartType = SeriesChartType.Pie
            });

            using (Models.HotelEntities db = new Models.HotelEntities())
            {
                List<Models.Room> room = db.Room.ToList();
                
                room = db.Room.Where(x => x.StatusID == 1).ToList();
                free = room.Count;

                room = db.Room.Where(x => x.StatusID == 2).ToList();
                busy = room.Count;

                room = db.Room.Where(x => x.StatusID == 3).ToList();
                remont = room.Count;
            }

            int[] yValues = { free, busy, remont };
            string[] xValues = { "Свободные", "Занятые", "На ремонте"};
            chartBooking.Series["ColumnSeries"].Points.DataBindXY(xValues, yValues);

            chartBooking.ChartAreas[0].Area3DStyle.Enable3D = false;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
