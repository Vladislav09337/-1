using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TouristAgency
{
    public partial class FormStep3 : Form
    {
        private string[] servicesList = { "SPA", "Свадьба", "WiFi", "Спорт", "VIP", "Кондиционер", "FIT", "Эксклюзив", "Трансфер" };

        public FormStep3()
        {
            InitializeComponent();
            LoadServices();
        }

        private void LoadServices()
        {
            foreach (string s in servicesList)
                clbServices.Items.Add(s);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Program.GlobalPreferences.HotelStars = cmbStars.SelectedIndex;
            Program.GlobalPreferences.MealType = cmbMeal.SelectedItem.ToString();

            List<string> selected = new List<string>();
            foreach (var item in clbServices.CheckedItems)
                selected.Add(item.ToString());
            Program.GlobalPreferences.SelectedServices = selected;
            Program.GlobalPreferences.MinPrice = (int)nudMin.Value;
            Program.GlobalPreferences.MaxPrice = (int)nudMax.Value;
            Program.GlobalPreferences.Step3Skipped = false;

            this.Hide();
            FormStep4 form4 = new FormStep4();
            form4.ShowDialog();
            this.Close();
        }

        private void BtnSkip_Click(object sender, EventArgs e)
        {
            Program.GlobalPreferences.Step3Skipped = true;
            this.Hide();
            FormStep4 form4 = new FormStep4();
            form4.ShowDialog();
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStep2 form2 = new FormStep2();
            form2.ShowDialog();
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStep1 form1 = new FormStep1();
            form1.ShowDialog();
            this.Close();
        }

        private void BtnFavorites_Click(object sender, EventArgs e)
        {
            FormFavorites fav = new FormFavorites();
            fav.ShowDialog();
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            nudMax.Value = trackPrice.Value;
        }
    }
}