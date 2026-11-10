using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Левая граница графика (изменено под Ваш вариант)
        private double XMin = -2.8;
        // Правая граница графика (изменено под Ваш вариант)
        private double XMax = 8.2;
        // Шаг графика (выберем 0.1, чтобы линия была гладкой)
        private double Step = 0.1;
        // Массив значений X - общий для обоих графиков
        private double[] x;
        // Массив Y - нам нужен только один для Варианта 1
        private double[] y1;

        Chart chart;

        // Расчёт значений графика
        private void CalcFunction()
        {
            // Количество точек графика
            int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;
            // Создаём массивы нужных размеров
            x = new double[count];
            y1 = new double[count];

            // Расчитываем точки для графика функции
            for (int i = 0; i < count; i++)
            {
                // Вычисляем значение X
                x[i] = XMin + Step * i;
                // Вычисляем значение функции в точке X: y = x^2 * cos(x)
                y1[i] = Math.Pow(x[i], 2) * Math.Cos(x[i]);
            }
        }

        // Создаём элемент управления Chart и настраиваем его
        private void CreateChart()
        {
            // Создаём новый элемент управления Chart
            chart = new Chart();
            // Помещаем его на форму
            chart.Parent = this;
            // Задаём размеры элемента
            chart.SetBounds(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
            // Создаём новую область для построения графика
            ChartArea area = new ChartArea();
            // Даём ей имя (чтобы потом добавлять графики)
            area.Name = "myGraph";
            // Задаём левую и правую границы оси X
            area.AxisX.Minimum = XMin;
            area.AxisX.Maximum = XMax;
            // Определяем шаг сетки (поставим 1.0, чтобы сетка не сливалась)
            area.AxisX.MajorGrid.Interval = 1.0;
            // Добавляем область в диаграмму
            chart.ChartAreas.Add(area);

            // Создаём объект для первого графика
            Series series1 = new Series();
            // Ссылаемся на область для построения графика
            series1.ChartArea = "myGraph";
            // Задаём тип графика - сплайны
            series1.ChartType = SeriesChartType.Spline;
            // Указываем ширину линии графика
            series1.BorderWidth = 3;
            // Название графика для отображения в легенде
            series1.LegendText = "x^2 * cos(x)";
            // Добавляем в список графиков диаграммы
            chart.Series.Add(series1);

            // Создаём легенду, которая будет показывать названия
            Legend legend = new Legend();
            chart.Legends.Add(legend);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создаём элемент управления
            CreateChart();
            // Расчитываем значения точек графиков функций
            CalcFunction();
            // Добавляем вычисленные значения в графики
            chart.Series[0].Points.DataBindXY(x, y1);
        }
    }
}