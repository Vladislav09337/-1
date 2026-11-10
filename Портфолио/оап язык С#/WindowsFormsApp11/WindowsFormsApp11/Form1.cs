using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SolarSystemGuide
{
    public partial class Form1 : Form
    {
        private Sun sun;
        private List<Planet> planets;
        private List<Moon> moons;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            SetupDataGridView();
            UpdateDataGridView();
        }

        private void InitializeData()
        {
            planets = new List<Planet>();
            moons = new List<Moon>();

            // Создаем планеты
            Planet mercury = new Planet("Меркурий", 3.301e23, 2439.7, 57.9);
            Planet venus = new Planet("Венера", 4.867e24, 6051.8, 108.2);
            Planet earth = new Planet("Земля", 5.972e24, 6371, 149.6);
            Planet mars = new Planet("Марс", 6.417e23, 3389.5, 227.9);
            Planet jupiter = new Planet("Юпитер", 1.898e27, 69911, 778.5);
            Planet saturn = new Planet("Сатурн", 5.683e26, 58232, 1433.5);
            Planet uranus = new Planet("Уран", 8.681e25, 25362, 2872.5);
            Planet neptune = new Planet("Нептун", 1.024e26, 24622, 4495.1);

            // Создаем спутники
            Moon moon = new Moon("Луна", 7.348e22, 1737.4, earth, 384.4);
            Moon phobos = new Moon("Фобос", 1.065e16, 11.1, mars, 9.4);
            Moon deimos = new Moon("Деймос", 1.476e15, 6.2, mars, 23.5);
            Moon europa = new Moon("Европа", 4.80e22, 1560.8, jupiter, 670.9);
            Moon ganymede = new Moon("Ганимед", 1.48e23, 2634.1, jupiter, 1070.4);
            Moon titan = new Moon("Титан", 1.345e23, 2574.7, saturn, 1221.8);
            Moon enceladus = new Moon("Энцелад", 1.08e20, 252.1, saturn, 238.0);
            Moon titania = new Moon("Титания", 3.53e21, 788.9, uranus, 436.3);
            Moon triton = new Moon("Тритон", 2.14e22, 1353.4, neptune, 354.8);

            // Добавляем спутники к планетам
            earth.AddMoon(moon);
            mars.AddMoon(phobos);
            mars.AddMoon(deimos);
            jupiter.AddMoon(europa);
            jupiter.AddMoon(ganymede);
            saturn.AddMoon(titan);
            saturn.AddMoon(enceladus);
            uranus.AddMoon(titania);
            neptune.AddMoon(triton);

            // Добавляем планеты в список
            planets.Add(mercury);
            planets.Add(venus);
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);

            // Добавляем спутники в список
            moons.Add(moon);
            moons.Add(phobos);
            moons.Add(deimos);
            moons.Add(europa);
            moons.Add(ganymede);
            moons.Add(titan);
            moons.Add(enceladus);
            moons.Add(titania);
            moons.Add(triton);

            // Создаем Солнце
            sun = new Sun("Солнце", 1.989e30, 695700, 5778);

            // Выводим информацию о Солнце
            lblSunInfo.Text = sun.GetInfo();
        }

        private void SetupDataGridView()
        {
            // Таблица планет
            dgvPlanets.Columns.Clear();
            dgvPlanets.Columns.Add("Name", "Название");
            dgvPlanets.Columns.Add("Mass", "Масса (кг)");
            dgvPlanets.Columns.Add("Radius", "Радиус (км)");
            dgvPlanets.Columns.Add("Distance", "Расстояние от Солнца (млн км)");
            dgvPlanets.Columns.Add("MoonsCount", "Спутников");

            // Таблица спутников
            dgvMoons.Columns.Clear();
            dgvMoons.Columns.Add("Name", "Название");
            dgvMoons.Columns.Add("ParentPlanet", "Родительская планета");
            dgvMoons.Columns.Add("Mass", "Масса (кг)");
            dgvMoons.Columns.Add("Radius", "Радиус (км)");
            dgvMoons.Columns.Add("Distance", "Расстояние от планеты (тыс км)");
        }

        private void UpdateDataGridView()
        {
            // Заполняем таблицу планет
            dgvPlanets.Rows.Clear();
            foreach (var planet in planets)
            {
                dgvPlanets.Rows.Add(
                    planet.Name,
                    planet.Mass.ToString("E2"),
                    planet.Radius.ToString("N0"),
                    planet.DistanceFromSun.ToString("N1"),
                    planet.Moons.Count.ToString()
                );
            }

            // Заполняем таблицу спутников
            dgvMoons.Rows.Clear();
            foreach (var moon in moons)
            {
                dgvMoons.Rows.Add(
                    moon.Name,
                    moon.ParentPlanet.Name,
                    moon.Mass.ToString("E2"),
                    moon.Radius.ToString("N0"),
                    moon.DistanceFromPlanet.ToString("N1")
                );
            }

            lblStatus.Text = $"Готов к работе | Планет: {planets.Count} | Спутников: {moons.Count}";
        }

        private void BtnPlanetInfo_Click(object sender, EventArgs e)
        {
            if (dgvPlanets.SelectedRows.Count > 0)
            {
                int index = dgvPlanets.SelectedRows[0].Index;
                if (index < planets.Count)
                {
                    MessageBox.Show(planets[index].GetInfo(), "Информация о планете",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите планету из списка", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnMoonInfo_Click(object sender, EventArgs e)
        {
            if (dgvMoons.SelectedRows.Count > 0)
            {
                int index = dgvMoons.SelectedRows[0].Index;
                if (index < moons.Count)
                {
                    MessageBox.Show(moons[index].GetInfo(), "Информация о спутнике",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите спутник из списка", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}