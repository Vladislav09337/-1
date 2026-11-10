using System;
using System.Windows.Forms;
using TouristAgency00.Models;

namespace TouristAgency00
{
    public partial class Form4 : Form
    {
        private SearchParams searchParams;

        public Form4(SearchParams searchParams)
        {
            InitializeComponent();
            this.searchParams = searchParams;
            SetupDataGridView();
            LoadMockData();

            this.btnBack.Click += btnBack_Click;
            this.btnSearch.Click += btnSearch_Click;
            this.btnTop.Click += btnTop_Click;
            this.btnReset.Click += btnReset_Click;
        }

        private void SetupDataGridView()
        {
            dgvTours.Columns.Clear();
            dgvTours.Columns.Add("Country", "Страна");
            dgvTours.Columns.Add("City", "Город");
            dgvTours.Columns.Add("Hotel", "Отель");
            dgvTours.Columns.Add("Dates", "Даты");
            dgvTours.Columns.Add("Price", "Стоимость");
            dgvTours.Columns.Add("Favorite", "Избран");
            dgvTours.Columns.Add("Book", "Бронь");

            dgvTours.Columns["Country"].Width = 100;
            dgvTours.Columns["City"].Width = 100;
            dgvTours.Columns["Hotel"].Width = 200;
            dgvTours.Columns["Dates"].Width = 150;
            dgvTours.Columns["Price"].Width = 100;
            dgvTours.Columns["Favorite"].Width = 60;
            dgvTours.Columns["Book"].Width = 80;

            dgvTours.RowTemplate.Height = 40;
            dgvTours.AllowUserToAddRows = false;
            dgvTours.ReadOnly = true;
            dgvTours.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadMockData()
        {
            dgvTours.Rows.Clear();
            dgvTours.Rows.Add("Россия", "Сочи", "Отель Роза хутор\nул. Вишневского 13", "21.07.2018 -\n30.07.2018", "34 000 руб.", "★", "Забронировать");
            dgvTours.Rows.Add("Россия", "Сочи", "Отель ПаркИнн\nул. Ленина 14", "21.07.2018 -\n30.07.2018", "54 000 руб.", "★", "Забронировать");
            dgvTours.Rows.Add("Италия", "Рим", "Hotel Roma\nVia Veneto, 10", "01.08.2018 -\n10.08.2018", "85 000 руб.", "★", "Забронировать");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Избранное", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadMockData();
        }
    }
}