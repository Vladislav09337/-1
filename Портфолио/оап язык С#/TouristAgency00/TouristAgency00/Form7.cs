using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TouristAgency00
{
    public partial class Form7 : Form
    {
        private Tour selectedTour;
        private string fioBooker;
        private List<Dictionary<string, string>> travelersData;
        private string phoneNumber;
        private string emailAddress;
        private string bookingNumber;

        public Form7(Tour tour, string fio, List<Dictionary<string, string>> travelers, string phoneNum, string emailAddr)
        {
            InitializeComponent();
            selectedTour = tour;
            fioBooker = fio;
            travelersData = travelers;
            phoneNumber = phoneNum;
            emailAddress = emailAddr;
            bookingNumber = GenerateNumber();
            LoadTour();
        }

        private string GenerateNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 9999).ToString();
        }

        private void LoadTour()
        {
            lblNum.Text = bookingNumber;
            lblCounty.Text = selectedTour.Country;
            lblCity.Text = selectedTour.City;
            lblDates.Text = $"{selectedTour.StartDate.ToShortDateString()} - {selectedTour.EndDate.ToShortDateString()}";
            lblOnePrice.Text = selectedTour.Price.ToString("N0") + " ₽";
            lblColvo.Text = Form1.PeopleCount.ToString();

            decimal totalPrice = selectedTour.Price * Form1.PeopleCount;
            lblPriceItog.Text = totalPrice.ToString("N0") + " ₽";

            DisplayTravelers();
        }

        private void DisplayTravelers()
        {
            dgvTravelers.Rows.Clear();
            dgvTravelers.Columns.Clear();

            dgvTravelers.Columns.Add("FullName", "ФИО");
            dgvTravelers.Columns.Add("BirthDate", "Дата рождения");
            dgvTravelers.Columns.Add("Email", "Email");
            dgvTravelers.Columns.Add("Phone", "Телефон");

            for (int i = 0; i < travelersData.Count; i++)
            {
                string fullName = travelersData[i].ContainsKey("ФИО") ? travelersData[i]["ФИО"] : "";
                string birthDate = travelersData[i].ContainsKey("Дата рождения") ? travelersData[i]["Дата рождения"] : "";
                string personEmail = travelersData[i].ContainsKey("E-mail") ? travelersData[i]["E-mail"] : "";
                string personPhone = travelersData[i].ContainsKey("Телефон") ? travelersData[i]["Телефон"] : "";

                dgvTravelers.Rows.Add(fullName, birthDate, personEmail, personPhone);
            }

            dgvTravelers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTravelers.AllowUserToAddRows = false;
            dgvTravelers.ReadOnly = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Тур {bookingNumber} успешно оформлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}