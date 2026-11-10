using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TouristAgency00
{
    public partial class Form5 : Form
    {
        private DataGridView dgvFavorites;
        private List<Tour> favoriteTours;

        public Form5(List<Tour> favorites)
        {
            InitializeComponent();
            favoriteTours = favorites;
            CreateDataGridView();
            DisplayFavorites();
            btnClose.Click += (s, e) => this.Close();
        }

        private void CreateDataGridView()
        {
            dgvFavorites = new DataGridView();
            dgvFavorites.Location = new Point(20, 70);
            dgvFavorites.Size = new Size(740, 370);
            dgvFavorites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFavorites.AllowUserToAddRows = false;
            dgvFavorites.ReadOnly = true;
            dgvFavorites.RowHeadersVisible = false;
            dgvFavorites.BackgroundColor = Color.White;
            dgvFavorites.BorderStyle = BorderStyle.Fixed3D;
            dgvFavorites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvFavorites.Columns.Add("Col1", "Страна");
            dgvFavorites.Columns.Add("Col2", "Город");
            dgvFavorites.Columns.Add("Col3", "Отель и адрес");
            dgvFavorites.Columns.Add("Col4", "Даты тура");
            dgvFavorites.Columns.Add("Col5", "Стоимость");
            dgvFavorites.Columns.Add("Col6", "★");

            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.Name = "Remove";
            btnRemove.HeaderText = "";
            btnRemove.Text = "✖ Удалить";
            btnRemove.UseColumnTextForButtonValue = true;
            btnRemove.Width = 80;
            dgvFavorites.Columns.Add(btnRemove);

            dgvFavorites.CellClick += DgvFavorites_CellClick;
            this.Controls.Add(dgvFavorites);
        }

        private void DisplayFavorites()
        {
            dgvFavorites.Rows.Clear();

            if (favoriteTours.Count == 0)
            {
                dgvFavorites.Rows.Add("НЕТ", "ИЗБРАННЫХ", "ТУРОВ", "", "", "", "✖ Удалить");
                dgvFavorites.Enabled = false;
                return;
            }

            dgvFavorites.Enabled = true;

            foreach (var t in favoriteTours)
            {
                string stars = new string('★', t.Stars);
                dgvFavorites.Rows.Add(
                    t.Country,
                    t.City,
                    t.HotelName + "\n" + t.Address,
                    t.DatesString,
                    t.PriceString,
                    stars,
                    "✖ Удалить"
                );
            }
        }

        private void DgvFavorites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= favoriteTours.Count) return;

            if (e.ColumnIndex == dgvFavorites.Columns["Remove"].Index)
            {
                var tour = favoriteTours[e.RowIndex];
                DialogResult result = MessageBox.Show($"Удалить тур \"{tour.HotelName}\" из избранного?",
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    favoriteTours.RemoveAt(e.RowIndex);
                    DisplayFavorites();
                    MessageBox.Show("Тур удалён из избранного", "Избранное",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}