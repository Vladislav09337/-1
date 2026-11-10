using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TouristAgency00.Models;

namespace TouristAgency00
{
    public partial class Form3 : Form
    {
        private SearchParams searchParams;
        private int selectedStars = 0;

        public Form3()
        {
            InitializeComponent();
            InitializeStars();
            InitializePriceSync();
            InitializeComboBox();
            SubscribeEvents();
        }

        public Form3(SearchParams searchParams) : this()
        {
            this.searchParams = searchParams;

            if (this.searchParams.HotelFilters == null)
                this.searchParams.HotelFilters = new HotelFilters();

            LoadSavedFilters();
        }

        private void InitializeComboBox()
        {
            if (cmbMeal != null && cmbMeal.Items.Count == 0)
            {
                cmbMeal.Items.AddRange(new object[] {
                    "Не имеет значения",
                    "Без завтрака",
                    "Завтрак",
                    "Полупансион",
                    "Всё включено"
                });
                cmbMeal.SelectedIndex = 0;
            }
        }

        private void SubscribeEvents()
        {
            if (btnNext != null)
                this.btnNext.Click += btnNext_Click;
            if (btnSkip != null)
                this.btnSkip.Click += btnSkip_Click;
        }

        private void LoadSavedFilters()
        {
            try
            {
                // Загружаем сохраненные значения фильтров
                if (searchParams.HotelFilters.PriceMin > 0)
                    nudMin.Value = searchParams.HotelFilters.PriceMin;
                if (searchParams.HotelFilters.PriceMax > 0)
                    nudMax.Value = searchParams.HotelFilters.PriceMax;

                if (searchParams.HotelFilters.Stars.HasValue && searchParams.HotelFilters.Stars.Value > 0)
                    SetStars(searchParams.HotelFilters.Stars.Value);

                if (!string.IsNullOrEmpty(searchParams.HotelFilters.MealType))
                {
                    int index = cmbMeal.Items.IndexOf(searchParams.HotelFilters.MealType);
                    if (index >= 0)
                        cmbMeal.SelectedIndex = index;
                }

                // Загружаем дополнительные услуги
                if (searchParams.HotelFilters.ExtraServices != null)
                {
                    checkBoxSPA.Checked = searchParams.HotelFilters.ExtraServices.Contains("SPA");
                    checkBoxSport.Checked = searchParams.HotelFilters.ExtraServices.Contains("Спорт");
                    checkBoxFIT.Checked = searchParams.HotelFilters.ExtraServices.Contains("FIT");
                    checkBoxSvadba.Checked = searchParams.HotelFilters.ExtraServices.Contains("Свадьба");
                    checkBoxVIP.Checked = searchParams.HotelFilters.ExtraServices.Contains("VIP");
                    checkBoxExpirience.Checked = searchParams.HotelFilters.ExtraServices.Contains("Эксклюзив");
                    checkBoxWiFi.Checked = searchParams.HotelFilters.ExtraServices.Contains("WiFi");
                    checkBoxKondicioner.Checked = searchParams.HotelFilters.ExtraServices.Contains("Кондиционер");
                    checkBoxTransfer.Checked = searchParams.HotelFilters.ExtraServices.Contains("Трансфер");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка загрузки фильтров: " + ex.Message);
            }
        }

        private void InitializeStars()
        {
            if (lblStar1 != null) lblStar1.Click += (s, e) => SetStars(1);
            if (lblStar2 != null) lblStar2.Click += (s, e) => SetStars(2);
            if (lblStar3 != null) lblStar3.Click += (s, e) => SetStars(3);
            if (lblStar4 != null) lblStar4.Click += (s, e) => SetStars(4);
            if (lblStar5 != null) lblStar5.Click += (s, e) => SetStars(5);
        }

        private void SetStars(int count)
        {
            selectedStars = count;
            Label[] stars = { lblStar1, lblStar2, lblStar3, lblStar4, lblStar5 };
            for (int i = 0; i < stars.Length; i++)
            {
                if (stars[i] != null)
                {
                    stars[i].Text = i < count ? "★" : "☆";
                    stars[i].ForeColor = i < count ? Color.Gold : Color.Gray;
                }
            }
        }

        private void InitializePriceSync()
        {
            if (trackPrice != null && nudMax != null)
            {
                trackPrice.ValueChanged += (s, e) =>
                {
                    nudMax.Value = trackPrice.Value;
                    UpdatePriceRange();
                };
                nudMax.ValueChanged += (s, e) =>
                {
                    trackPrice.Value = (int)nudMax.Value;
                    UpdatePriceRange();
                };
                nudMin.ValueChanged += (s, e) => UpdatePriceRange();
            }
            UpdatePriceRange();
        }

        private void UpdatePriceRange()
        {
            if (lblPriceRange != null)
            {
                lblPriceRange.Text = $"{nudMin.Value:N0} ---------- {nudMax.Value:N0} ---------- 500000";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFilters();

                Form4 form4 = new Form4(searchParams);
                form4.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении фильтров: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveFilters()
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
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            try
            {
                Form4 form4 = new Form4(searchParams);
                form4.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при переходе: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Дополнительная инициализация при загрузке формы
        }
    }
}