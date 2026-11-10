using System;
using System.Windows.Forms;
using TouristAgency00.Models;

namespace TouristAgency00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.btnSearch.Click += BtnSearch_Click;
            this.btnTop.Click += BtnTop_Click;
            this.btnNext.Click += BtnNext_Click;
            this.btnSkip.Click += BtnSkip_Click;

            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now.AddDays(7);
            textBoxDay.Text = "7";
            textBoxPeople.Text = "2";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Перезапуск поиска
            DialogResult result = MessageBox.Show("Вы уверены, что хотите начать новый поиск?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 newForm1 = new Form1();
                newForm1.ShowDialog();
                this.Close();
            }
        }

        private void BtnTop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Избранное будет доступно в следующей версии!",
                "Избранное", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            // СОЗДАЕМ ОБЪЕКТ SearchParams
            SearchParams searchParams = CreateSearchParams();

            this.Hide();
            Form2 form2 = new Form2(searchParams);
            form2.ShowDialog();
            this.Close();
        }

        private void BtnSkip_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            // СОЗДАЕМ ОБЪЕКТ SearchParams
            SearchParams searchParams = CreateSearchParams();

            this.Hide();
            Form2 form2 = new Form2(searchParams);
            form2.ShowDialog();
            this.Close();
        }

        private SearchParams CreateSearchParams()
        {
            int days = int.Parse(textBoxDay.Text);
            int people = int.Parse(textBoxPeople.Text);

            SearchParams searchParams = new SearchParams();
            searchParams.StartDate = dtpStart.Value;
            searchParams.EndDate = dtpEnd.Value;
            searchParams.Duration = days;
            searchParams.TravelersCount = people;
            searchParams.HasChildren = checkBoxChild.Checked;


            return searchParams;
        }

        private bool ValidateInput()
        {
            // Проверка количества человек
            if (string.IsNullOrWhiteSpace(textBoxPeople.Text) || textBoxPeople.Text == "0")
            {
                MessageBox.Show("Заполните количество человек!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Проверка дней
            int days;
            if (!int.TryParse(textBoxDay.Text, out days) || days <= 0)
            {
                MessageBox.Show("Введите корректное количество дней!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Проверка количества человек
            int people;
            if (!int.TryParse(textBoxPeople.Text, out people) || people <= 0)
            {
                MessageBox.Show("Введите корректное количество человек!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Проверка дат
            if (dtpStart.Value > dtpEnd.Value)
            {
                MessageBox.Show("Дата начала не может быть позже даты окончания!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Проверка длительности поездки
            TimeSpan duration = dtpEnd.Value - dtpStart.Value;
            if (duration.Days != days)
            {
                MessageBox.Show($"Количество дней ({days}) не соответствует разнице между датами ({duration.Days} дней)!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Вспомогательные методы для синхронизации полей
        private void UpdateDaysFromDates()
        {
            TimeSpan duration = dtpEnd.Value - dtpStart.Value;
            textBoxDay.Text = duration.Days.ToString();
        }

        private void UpdateEndDateFromDays()
        {
            if (int.TryParse(textBoxDay.Text, out int days) && days > 0)
            {
                dtpEnd.Value = dtpStart.Value.AddDays(days);
            }
        }

        // Обработчики событий для синхронизации
        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            UpdateDaysFromDates();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            UpdateDaysFromDates();
        }

        private void textBoxDay_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDay.Text, out int days) && days > 0)
            {
                dtpEnd.Value = dtpStart.Value.AddDays(days);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}