using System;
using System.Windows.Forms;

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
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
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

            // СОЗДАЕМ ОБЪЕКТ SearchParams
            SearchParams searchParams = new SearchParams();
            searchParams.StartDate = dtpStart.Value;
            searchParams.EndDate = dtpEnd.Value;
            searchParams.Duration = days;
            searchParams.TravelersCount = people;
            searchParams.HasChildren = checkBoxChild.Checked;

            this.Hide();
            Form2 form2 = new Form2(searchParams);  // ← ПЕРЕДАЕМ ПАРАМЕТР
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

            // СОЗДАЕМ ОБЪЕКТ SearchParams
            SearchParams searchParams = new SearchParams();
            searchParams.StartDate = dtpStart.Value;
            searchParams.EndDate = dtpEnd.Value;
            searchParams.Duration = days;
            searchParams.TravelersCount = people;
            searchParams.HasChildren = checkBoxChild.Checked;

            this.Hide();
            Form2 form2 = new Form2(searchParams);  // ← ПЕРЕДАЕМ ПАРАМЕТР
            form2.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}