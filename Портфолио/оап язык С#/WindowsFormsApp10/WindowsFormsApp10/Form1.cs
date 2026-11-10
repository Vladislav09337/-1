using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SolarSystemReference
{
    public partial class Form1 : Form
    {
        // поля для хранения данных
        private Star sun;
        private List<Planet> planets;
        private List<Moon> moons;
        private CelestialBody selectedBody;

        public Form1()
        {
            InitializeComponent(); // загрузка дизайна
            InitializeData();      // заполнение данными
            LoadObjects();         // загрузка в список

            // подписка на события
            this.lbObjects.SelectedIndexChanged += lbObjects_SelectedIndexChanged;
            this.btnShowInfo.Click += btnShowInfo_Click;
            this.cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;

            this.cbFilter.SelectedIndex = 0; // по умолчанию показываем все
        }

        // инициализация данных солнечной системы
        private void InitializeData()
        {
            // создаем заглушку для фото (в реальном проекте загружаются реальные картинки)
            Bitmap defaultImg = new Bitmap(150, 150);
            using (Graphics g = Graphics.FromImage(defaultImg))
            {
                g.Clear(Color.LightGray);
                g.DrawEllipse(Pens.Black, 10, 10, 130, 130);
                g.FillEllipse(Brushes.White, 10, 10, 130, 130);
            }

            // создаем солнце
            sun = new Star("солнце", defaultImg, 1.989e30, 695700, 5778);

            planets = new List<Planet>();
            moons = new List<Moon>();

            // земля и луна
            Planet earth = new Planet("земля", defaultImg, 5.972e24, 6371, 149.6, sun);
            planets.Add(earth);
            moons.Add(new Moon("луна", defaultImg, 7.348e22, 1737, 0.384, earth));

            // марс и его спутники
            Planet mars = new Planet("марс", defaultImg, 6.417e23, 3389, 227.9, sun);
            planets.Add(mars);
            moons.Add(new Moon("фобос", defaultImg, 1.0659e16, 11.1, 0.00938, mars));
            moons.Add(new Moon("деймос", defaultImg, 1.4762e15, 6.2, 0.02346, mars));

            // юпитер и его спутники
            Planet jupiter = new Planet("юпитер", defaultImg, 1.898e27, 69911, 778.5, sun);
            planets.Add(jupiter);
            moons.Add(new Moon("ио", defaultImg, 8.9319e22, 1821, 0.422, jupiter));
            moons.Add(new Moon("европа", defaultImg, 4.7998e22, 1561, 0.671, jupiter));
            moons.Add(new Moon("ганимед", defaultImg, 1.4819e23, 2634, 1.070, jupiter));
            moons.Add(new Moon("каллисто", defaultImg, 1.0759e23, 2410, 1.883, jupiter));

            // сатурн и его спутники
            Planet saturn = new Planet("сатурн", defaultImg, 5.683e26, 58232, 1433.5, sun);
            planets.Add(saturn);
            moons.Add(new Moon("титан", defaultImg, 1.345e23, 2575, 1.222, saturn));
            moons.Add(new Moon("рея", defaultImg, 2.306e21, 764, 0.527, saturn));

            // остальные планеты
            planets.Add(new Planet("уран", defaultImg, 8.681e25, 25362, 2872.5, sun));
            planets.Add(new Planet("нептун", defaultImg, 1.024e26, 24622, 4495.1, sun));
        }

        // загрузка объектов в список с учетом фильтра
        private void LoadObjects()
        {
            lbObjects.Items.Clear();
            string filter = cbFilter.SelectedItem.ToString();

            // добавляем звезду если нужно
            if (filter == "все объекты" || filter == "звезды")
                lbObjects.Items.Add(sun.Name);

            // добавляем планеты если нужно
            if (filter == "все объекты" || filter == "планеты")
            {
                foreach (var p in planets)
                    lbObjects.Items.Add(p.Name);
            }

            // добавляем спутники если нужно
            if (filter == "все объекты" || filter == "спутники")
            {
                foreach (var m in moons)
                    lbObjects.Items.Add(m.Name);
            }
        }

        // обработчик выбора объекта из списка
        private void lbObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbObjects.SelectedIndex == -1) return;

            string name = lbObjects.SelectedItem.ToString();
            selectedBody = null;

            // ищем выбранный объект
            if (name == sun.Name)
                selectedBody = sun;
            else
            {
                foreach (var p in planets)
                {
                    if (p.Name == name)
                    {
                        selectedBody = p;
                        break;
                    }
                }
                if (selectedBody == null)
                {
                    foreach (var m in moons)
                    {
                        if (m.Name == name)
                        {
                            selectedBody = m;
                            break;
                        }
                    }
                }
            }

            // отображаем информацию и фото
            if (selectedBody != null)
            {
                txtInfo.Text = selectedBody.GetInfo();
                pbPhoto.Image = selectedBody.Photo;
            }
        }

        // обработчик кнопки показа информации
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (selectedBody != null)
                MessageBox.Show(selectedBody.GetInfo(), selectedBody.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("выберите объект", "внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // обработчик изменения фильтра
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadObjects(); // обновляем список при смене фильтра
        }
    }
}
