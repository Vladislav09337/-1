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

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Очищаем предыдущий график
            chart1.Series["Function"].Points.Clear();

            // Интервал от 0 до 8
            double XMin = 0;
            double XMax = 8;
            double Step = 0.05;  // шаг для плавности
            double y = 0;

            // Заголовок графика
            chart1.Titles.Clear();
            chart1.Titles.Add("График функции f(x) на интервале [0; 8]");
            chart1.Titles[0].Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            chart1.Titles[0].ForeColor = System.Drawing.Color.DarkBlue;

            // Настройка оси X (целые числа от 0 до 8)
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 8;
            chart1.ChartAreas[0].AxisX.Interval = 1;           // шаг 1
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "F0";  // целые числа
            chart1.ChartAreas[0].AxisX.Title = "X";
            chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            // Настройка оси Y
            chart1.ChartAreas[0].AxisY.Title = "Y";
            chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 10;

            // Цвет и толщина линии
            chart1.Series["Function"].Color = System.Drawing.Color.Red;
            chart1.Series["Function"].BorderWidth = 2;
            chart1.Series["Function"].ChartType = SeriesChartType.Line;

            // Расчёт и добавление точек
            for (double x = XMin; x <= XMax; x += Step)
            {
                // Функция
                y = x * x * Math.Cos(x);

                // Добавляем точку
                chart1.Series["Function"].Points.AddXY(x, y);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Дополнительная настройка при загрузке формы
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
        }
    }
}
