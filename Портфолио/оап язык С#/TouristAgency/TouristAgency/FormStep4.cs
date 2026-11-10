using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TouristAgency
{
    public partial class FormStep4 : Form
    {
        public static List<Tour> FavoriteTours = new List<Tour>();
        private List<Tour> allTours = new List<Tour>();
        private List<Tour> filteredTours = new List<Tour>();

        public FormStep4()
        {
            InitializeComponent();
            LoadSampleTours();
            SetupGrid();
            FilterTours();
        }

        private void LoadSampleTours()
        {
            Tour t1 = new Tour();
            t1.Id = 1;
            t1.Country = "Россия";
            t1.City = "Сочи";
            t1.HotelName = "Отель \"Роза хутор\"";
            t1.Address = "ул. Вишневского 13";
            t1.StartDate = new DateTime(2025, 7, 21);
            t1.EndDate = new DateTime(2025, 7, 30);
            t1.BasePrice = 34000;
            t1.Stars = 4;
            t1.MealType = "Завтрак";
            t1.Services = new List<string> { "WiFi", "Спорт" };
            t1.TourTypes = new List<string> { "Внутренний туризм", "Экскурсионные туры" };
            t1.IsChildrenTour = true;
            t1.TotalCount = 50;
            t1.SoldCount = 10;
            allTours.Add(t1);

            Tour t2 = new Tour();
            t2.Id = 2;
            t2.Country = "Россия";
            t2.City = "Сочи";
            t2.HotelName = "Отель \"Парк Инн\"";
            t2.Address = "ул. Ленина 14";
            t2.StartDate = new DateTime(2025, 7, 21);
            t2.EndDate = new DateTime(2025, 7, 30);
            t2.BasePrice = 54000;
            t2.Stars = 5;
            t2.MealType = "Всё включено";
            t2.Services = new List<string> { "SPA", "WiFi", "Бассейн" };
            t2.TourTypes = new List<string> { "Внутренний туризм", "Пляжный отдых" };
            t2.IsChildrenTour = true;
            t2.TotalCount = 30;
            t2.SoldCount = 5;
            allTours.Add(t2);

            Tour t3 = new Tour();
            t3.Id = 3;
            t3.Country = "Италия";
            t3.City = "Рим";
            t3.HotelName = "Hotel Roma";
            t3.Address = "Via Veneto 50";
            t3.StartDate = new DateTime(2025, 8, 10);
            t3.EndDate = new DateTime(2025, 8, 20);
            t3.BasePrice = 85000;
            t3.Stars = 5;
            t3.MealType = "Всё включено";
            t3.Services = new List<string> { "SPA", "WiFi", "Трансфер" };
            t3.TourTypes = new List<string> { "Международный туризм", "Экскурсионные туры" };
            t3.IsChildrenTour = true;
            t3.TotalCount = 25;
            t3.SoldCount = 8;
            allTours.Add(t3);
        }

        private void SetupGrid()
        {
            dgvResults.Columns.Clear();
            dgvResults.Columns.Add("Country", "Страна");
            dgvResults.Columns.Add("City", "Город");
            dgvResults.Columns.Add("Hotel", "Отель");
            dgvResults.Columns.Add("Dates", "Даты");
            dgvResults.Columns.Add("Price", "Стоимость");
            dgvResults.Columns.Add("Fav", "Избран");
            dgvResults.Columns.Add("Book", "Бронь");

            dgvResults.Columns["Country"].Width = 80;
            dgvResults.Columns["City"].Width = 80;
            dgvResults.Columns["Hotel"].Width = 250;
            dgvResults.Columns["Dates"].Width = 150;
            dgvResults.Columns["Price"].Width = 100;
            dgvResults.Columns["Fav"].Width = 60;
            dgvResults.Columns["Book"].Width = 100;
        }

        private int CalculatePriority(Tour tour)
        {
            var prefs = Program.GlobalPreferences;
            if (prefs.Step2Skipped || prefs.PrioritizedTourTypes == null || prefs.PrioritizedTourTypes.Count == 0)
                return 0;

            int score = 0;
            foreach (var tourType in tour.TourTypes)
            {
                int index = prefs.PrioritizedTourTypes.FindIndex(t => t == tourType);
                if (index >= 0)
                    score += (index + 1);
                else
                    score += 100;
            }
            return score;
        }

        private void FilterTours()
        {
            var prefs = Program.GlobalPreferences;
            var filtered = allTours.AsEnumerable();

            if (!prefs.Step1Skipped)
            {
                filtered = filtered.Where(t => t.AvailableCount >= prefs.PeopleCount);
                filtered = filtered.Where(t => t.StartDate >= prefs.PeriodStart && t.EndDate <= prefs.PeriodEnd);
                filtered = filtered.Where(t => t.Duration == prefs.Days);
                if (prefs.HasChildren)
                    filtered = filtered.Where(t => t.IsChildrenTour);
            }

            if (!prefs.Step3Skipped && prefs.HotelStars > 0)
            {
                if (prefs.HotelStars > 0)
                    filtered = filtered.Where(t => t.Stars == prefs.HotelStars);
                if (prefs.MealType != "Не имеет значения")
                    filtered = filtered.Where(t => t.MealType == prefs.MealType);
                if (prefs.SelectedServices.Count > 0)
                    filtered = filtered.Where(t => prefs.SelectedServices.All(s => t.Services.Contains(s)));
                filtered = filtered.Where(t => t.BasePrice >= prefs.MinPrice && t.BasePrice <= prefs.MaxPrice);
            }

            filteredTours = filtered.ToList();
            filteredTours = filteredTours.OrderBy(t => CalculatePriority(t)).ToList();

            dgvResults.Rows.Clear();
            foreach (var t in filteredTours)
            {
                bool isFav = FavoriteTours.Any(f => f.Id == t.Id);
                string hotel = $"{t.HotelName}, {t.Address}";
                string dates = $"{t.StartDate:dd.MM.yyyy} - {t.EndDate:dd.MM.yyyy}";
                dgvResults.Rows.Add(t.Country, t.City, hotel, dates, $"{t.BasePrice:N0}", isFav ? "★" : "☆", "Забронировать");
            }
        }

        private void DgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= filteredTours.Count) return;

            var tour = filteredTours[e.RowIndex];

            if (e.ColumnIndex == 5)
            {
                if (FavoriteTours.Any(f => f.Id == tour.Id))
                    FavoriteTours.RemoveAll(f => f.Id == tour.Id);
                else
                    FavoriteTours.Add(tour);
                FilterTours();
            }
            else if (e.ColumnIndex == 6)
            {
                MessageBox.Show($"Бронирование тура\n\nСтрана: {tour.Country}\nГород: {tour.City}\nОтель: {tour.HotelName}\nСтоимость: {tour.BasePrice:N0} руб.", "Бронирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStep3 form3 = new FormStep3();
            form3.ShowDialog();
            this.Close();
        }

        private void BtnFavoritesList_Click(object sender, EventArgs e)
        {
            FormFavorites fav = new FormFavorites();
            fav.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStep1 form1 = new FormStep1();
            form1.ShowDialog();
            this.Close();
        }

        private void BtnFavoritesMenu_Click(object sender, EventArgs e)
        {
            FormFavorites fav = new FormFavorites();
            fav.ShowDialog();
        }
    }
}