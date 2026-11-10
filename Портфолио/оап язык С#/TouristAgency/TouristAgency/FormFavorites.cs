using System;
using System.Windows.Forms;

namespace TouristAgency
{
    public partial class FormFavorites : Form
    {
        public FormFavorites()
        {
            InitializeComponent();
            LoadFavorites();
        }

        private void LoadFavorites()
        {
            dgvFavorites.Rows.Clear();
            foreach (var t in FormStep4.FavoriteTours)
            {
                string stars = new string('★', t.Stars);
                string services = string.Join(", ", t.Services);
                string dates = $"{t.StartDate:dd.MM.yyyy} - {t.EndDate:dd.MM.yyyy}";
                dgvFavorites.Rows.Add(t.Country, t.City, $"{t.BasePrice:N0}", stars, services, dates);
            }
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            if (dgvFavorites.SelectedRows.Count > 0)
            {
                int idx = dgvFavorites.SelectedRows[0].Index;
                if (idx < FormStep4.FavoriteTours.Count)
                {
                    var t = FormStep4.FavoriteTours[idx];
                    MessageBox.Show($"Бронирование тура\n\nСтрана: {t.Country}\nГород: {t.City}\nОтель: {t.HotelName}\nСтоимость: {t.BasePrice:N0} руб.", "Бронирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите тур для бронирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}