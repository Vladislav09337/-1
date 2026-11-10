using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TouristAgency00
{
    public partial class Form6 : Form
    {
        int travelersCount;
        private Tour selectedTour;

        public Form6(Tour tour)
        {
            InitializeComponent();
            selectedTour = tour;
            travelersCount = Form1.PeopleCount;

            dgvTravelers.Columns.Clear();
            dgvTravelers.Columns.Add("FullName", "ФИО");
            dgvTravelers.Columns.Add("BirthDate", "Дата рождения");
            dgvTravelers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < travelersCount - 1; i++)
            {
                dgvTravelers.Rows.Add();
            }
        }

        private void btnPodtverzd_Click(object sender, EventArgs e)
        {
            // Проверки
            for (int i = 0; i < travelersCount - 1; i++)
            {
                if (string.IsNullOrWhiteSpace(dgvTravelers.Rows[i].Cells["FullName"].Value?.ToString()))
                {
                    MessageBox.Show($"Заполните ФИО для путешествующего {i + 1}");
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(tbFIO.Text))
            {
                MessageBox.Show("Введите ФИО бронирующего");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Введите телефон");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Введите E-mail");
                return;
            }

            // Собираем данные
            List<Dictionary<string, string>> travelersList = new List<Dictionary<string, string>>();

            var bookerData = new Dictionary<string, string>();
            bookerData["ФИО"] = tbFIO.Text;
            bookerData["Дата рождения"] = dtpBirth.Value.Date.ToShortDateString();
            bookerData["E-mail"] = tbEmail.Text;
            bookerData["Телефон"] = tbPhone.Text;
            travelersList.Add(bookerData);

            for (int i = 0; i < travelersCount - 1; i++)
            {
                var data = new Dictionary<string, string>();
                data["ФИО"] = dgvTravelers.Rows[i].Cells["FullName"].Value?.ToString() ?? "";
                data["Дата рождения"] = dgvTravelers.Rows[i].Cells["BirthDate"].Value?.ToString() ?? "";
                travelersList.Add(data);
            }

            // Открываем Form7
            Form7 form7 = new Form7(selectedTour, tbFIO.Text, travelersList, tbPhone.Text, tbEmail.Text);
            form7.Show();
            this.Close();
        }
    }
}