using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TouristAgency00
{
    public partial class Form3 : Form
    {
        private SearchParams searchParams;
        private int selectedStars = 0;

        public Form3(SearchParams searchParams)
        {
            InitializeComponent();
            this.searchParams = searchParams;
            InitializeStars();
            InitializePriceSync();
            cmbMeal.SelectedIndex = 0;

            this.btnNext.Click += btnNext_Click;
            this.btnSkip.Click += btnSkip_Click;
        }

        private void InitializeStars()
        {
            lblStar1.Click += (s, e) => SetStars(1);
            lblStar2.Click += (s, e) => SetStars(2);
            lblStar3.Click += (s, e) => SetStars(3);
            lblStar4.Click += (s, e) => SetStars(4);
            lblStar5.Click += (s, e) => SetStars(5);
        }

        private void SetStars(int count)
        {
            selectedStars = count;
            Label[] stars = { lblStar1, lblStar2, lblStar3, lblStar4, lblStar5 };
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].Text = i < count ? "★" : "☆";
                stars[i].ForeColor = i < count ? Color.Gold : Color.Gray;
            }
        }

        private void InitializePriceSync()
        {
            trackPrice.ValueChanged += (s, e) => nudMax.Value = trackPrice.Value;
            nudMax.ValueChanged += (s, e) => trackPrice.Value = (int)nudMax.Value;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var services = new List<string>();
            if (checkBoxSPA.Checked) services.Add("SPA");
            if (checkBoxSport.Checked) services.Add("Спорт");
            if (checkBoxFIT.Checked) services.Add("FIT");
            if (checkBoxSvadba.Checked) services.Add("Свадьба");
            if (checkBoxVIP.Checked) services.Add("VIP");
            if (checkBoxExpirience.Checked) services.Add("Эксклюзив");
            if (checkBoxWiFi.Checked) services.Add("WiFi");
            if (checkBoxKondicioner.Checked) services.Add("Кондиционер");
            if (checkBoxTransfer.Checked) services.Add("Трансфер");

            if (searchParams.HotelFilters == null)
                searchParams.HotelFilters = new HotelFilters();

            searchParams.HotelFilters.Stars = selectedStars == 0 ? null : (int?)selectedStars;
            searchParams.HotelFilters.MealType = cmbMeal.SelectedIndex == 0 ? null : cmbMeal.SelectedItem.ToString();
            searchParams.HotelFilters.ExtraServices = services;
            searchParams.HotelFilters.PriceMin = nudMin.Value;
            searchParams.HotelFilters.PriceMax = nudMax.Value;

            Form4 form4 = new Form4(searchParams);
            form4.Show();
            this.Hide();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(searchParams);
            form4.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}