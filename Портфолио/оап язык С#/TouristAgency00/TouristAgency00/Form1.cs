using System;
using System.Windows.Forms;

namespace TouristAgency00
{
    public partial class Form1 : Form
    {
        public static DateTime PeriodStart;
        public static DateTime PeriodEnd;
        public static int Days;
        public static int PeopleCount;
        public static bool HasChildren;
        public static bool Step1Skipped;

        public Form1()
        {
            InitializeComponent();

            this.btnSearch.Click += BtnSearch_Click;
            this.btnTop.Click += BtnTop_Click;
            this.btnNext.Click += BtnNext_Click;
            this.btnSkip.Click += BtnSkip_Click;

            dtpStart.Value = new DateTime(2026, 7, 21);
            dtpEnd.Value = new DateTime(2026, 7, 30);
            textBoxDay.Text = "9";
            textBoxPeople.Text = "2";
            checkBoxChild.Checked = true;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы и так находитесь на первом шаге поиска!",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnTop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Избранное", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPeople.Text) || textBoxPeople.Text == "0")
            {
                MessageBox.Show("Заполните количество человек!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int days;
            if (!int.TryParse(textBoxDay.Text, out days) || days <= 0)
            {
                MessageBox.Show("Введите корректное количество дней!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int people;
            if (!int.TryParse(textBoxPeople.Text, out people) || people <= 0)
            {
                MessageBox.Show("Введите корректное количество человек!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpStart.Value > dtpEnd.Value)
            {
                MessageBox.Show("Дата начала не может быть позже даты окончания!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // СОХРАНЯЕМ ДАННЫЕ
            PeriodStart = dtpStart.Value;
            PeriodEnd = dtpEnd.Value;
            Days = days;
            PeopleCount = people;
            HasChildren = checkBoxChild.Checked;
            Step1Skipped = false;

            // ОТЛАДКА
            MessageBox.Show($"СОХРАНЕНО В FORM1:\n" +
                $"Период: {PeriodStart:dd.MM.yyyy} - {PeriodEnd:dd.MM.yyyy}\n" +
                $"Дней: {Days}\n" +
                $"Человек: {PeopleCount}\n" +
                $"Дети: {HasChildren}",
                "Проверка", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void BtnSkip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPeople.Text) || textBoxPeople.Text == "0")
            {
                MessageBox.Show("Нельзя пропустить шаг! Заполните количество человек.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int days;
            if (!int.TryParse(textBoxDay.Text, out days) || days <= 0)
            {
                MessageBox.Show("Введите корректное количество дней!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int people;
            if (!int.TryParse(textBoxPeople.Text, out people) || people <= 0)
            {
                MessageBox.Show("Введите корректное количество человек!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PeriodStart = dtpStart.Value;
            PeriodEnd = dtpEnd.Value;
            Days = days;
            PeopleCount = people;
            HasChildren = checkBoxChild.Checked;
            Step1Skipped = true;

            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e) { }
    }
}