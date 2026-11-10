using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace TouristAgency00
{
    public partial class Form4 : Form
    {
        private DataGridView dgv;
        private static List<Tour> favoriteTours = new List<Tour>();
        public Form4()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            label1.Visible = false;
            CreateDataGridView();
            LoadAndShowTours();
            btnSearch.Click
 += BtnSearch_Click;
            btnTop.Click
 += BtnTop_Click;
        }
        private void CreateDataGridView()
        {
            dgv = new DataGridView();
            dgv.Location = new Point(30, 150);
            dgv.Size = new Size(740, 450);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.Columns.Add("ColCountry", "Страна");
            dgv.Columns.Add("ColCity", "Город");
            dgv.Columns.Add("ColHotel", "Отель и адрес");
            dgv.Columns.Add("ColDates", "Даты тура");
            dgv.Columns.Add("ColPrice", "Стоимость");
            dgv.Columns.Add("ColStars", "★");
            DataGridViewButtonColumn btnFav = new DataGridViewButtonColumn();
            btnFav.Name
 = "Favorite";
            btnFav.HeaderText = "Избранное";
            btnFav.Text = "☆";
            btnFav.UseColumnTextForButtonValue = true;
            btnFav.Width = 80;
            dgv.Columns.Add(btnFav);
            DataGridViewButtonColumn btnBook = new DataGridViewButtonColumn();
            btnBook.Name
 = "Book";
            btnBook.HeaderText = "Бронь";
            btnBook.Text = "Забронировать";
            btnBook.UseColumnTextForButtonValue = true;
            btnBook.Width = 100;
            dgv.Columns.Add(btnBook);
            dgv.CellClick += Dgv_CellClick;
            this.Controls.Add(dgv);
        }
        private void LoadAndShowTours()
        {
            var allTours = LoadTours();
            var filteredTours = FilterTours(allTours);
            DisplayTours(filteredTours);
        }
        private List<Tour> LoadTours()
        {
            List<Tour> tours = new List<Tour>();
            tours.Add(new Tour
            {
                Id = 1,
                Country = "Россия",
                City = "Сочи",
                HotelName = "Роза Хутор",
                Address = "ул. Вишневского 13",
                StartDate = new DateTime(2026, 7, 21),
                EndDate = new DateTime(2026, 7, 30),
                Days = 9,
                AvailableSeats = 5,
                IsChildFriendly = true,
                Stars = 4,
                MealType = "Полупансион",
                Services = new List<string> { "WiFi", "Спорт" },
                Price = 34000,
                TourType = "Внутренний туризм"
            });
            tours.Add(new Tour
            {
                Id = 2,
                Country = "Россия",
                City = "Сочи",
                HotelName = "Парк Инн",
                Address = "ул. Ленина 14",
                StartDate = new DateTime(2026, 7, 21),
                EndDate = new DateTime(2026, 7, 30),
                Days = 9,
                AvailableSeats = 3,
                IsChildFriendly = false,
                Stars = 4,
                MealType = "Завтрак",
                Services = new List<string> { "WiFi", "Кондиционер" },
                Price = 54000,
                TourType = "Внутренний туризм"
            });
            tours.Add(new Tour
            {
                Id = 3,
                Country = "Турция",
                City = "Анталия",
                HotelName = "Rixos Premium Belek",
                Address = "Belek Mahallesi, 07500",
                StartDate = new DateTime(2026, 7, 21),
                EndDate = new DateTime(2026, 7, 30),
                Days = 9,
                AvailableSeats = 8,
                IsChildFriendly = true,
                Stars = 5,
                MealType = "Всё включено",
                Services = new List<string> { "SPA", "WiFi", "Спорт", "Трансфер" },
                Price = 85000,
                TourType = "Международный туризм"
            });
            tours.Add(new Tour
            {
                Id = 4,
                Country = "Египет",
                City = "Хургада",
                HotelName = "Steigenberger Aqua Magic",
                Address = "Sahl Hasheesh Road",
                StartDate = new DateTime(2026, 7, 21),
                EndDate = new DateTime(2026, 7, 30),
                Days = 9,
                AvailableSeats = 4,
                IsChildFriendly = true,
                Stars = 4,
                MealType = "Всё включено",
                Services = new List<string> { "WiFi", "Спорт" },
                Price = 65000,
                TourType = "Пляжный отдых"
            });
            return tours;
        }
        private List<Tour> FilterTours(List<Tour> allTours)
        {
            var query = allTours.AsEnumerable();
            query = query.Where(t => t.Days == Form1.Days);
            query = query.Where(t => t.StartDate >= Form1.PeriodStart && t.EndDate <= Form1.PeriodEnd);
            query = query.Where(t => t.AvailableSeats >= Form1.PeopleCount);
            if (Form1.HasChildren)
            {
                query = query.Where(t => t.IsChildFriendly == true);
            }
            if (!Form2.Step2Skipped && Form2.PrioritizedTourTypes.Count > 0)
            {
                query = query.Where(t => Form2.PrioritizedTourTypes.Contains(t.TourType));
            }
            if (!Form3.Step3Skipped)
            {
                if (Form3.HotelStars > 0)
                {
                    query = query.Where(t => t.Stars >= Form3.HotelStars);
                }
                if (Form3.MealType != "Не имеет значения")
                {
                    query = query.Where(t => t.MealType == Form3.MealType);
                }
                query = query.Where(t => t.Price >= Form3.MinPrice && t.Price <= Form3.MaxPrice);
                if (Form3.SelectedServices.Count > 0)
                {
                    query = query.Where(t => Form3.SelectedServices.All(s => t.Services.Contains(s)));
                }
            }
            return query.ToList();
        }
        private void DisplayTours(List<Tour> tours)
        {
            dgv.Rows.Clear();
            if (tours.Count == 0)
            {
                dgv.Rows.Add("НЕТ", "ТУРОВ", "ПО", "ВАШЕМУ", "ЗАПРОСУ", "", "☆", "Забронировать");
                return;
            }
            foreach (var t in tours)
            {
                string stars = new string('★', t.Stars);
                bool isFavorite = favoriteTours.Any(f => f.Id
 == t.Id
);
                dgv.Rows.Add(
                    t.Country
,
                    t.City
,
                    t.HotelName + "\n" + t.Address,
                    t.DatesString,
                    t.PriceString,
                    stars,
                    isFavorite ? "★" : "☆",
                    "Забронировать"
                );
            }
        }
        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var allTours = LoadTours();
            var filteredTours = FilterTours(allTours);
            if (e.RowIndex >= filteredTours.Count) return;
            var tour = filteredTours[e.RowIndex];
            if (e.ColumnIndex == dgv.Columns["Favorite"].Index)
            {
                if (favoriteTours.Any(f => f.Id == tour.Id
))
                {
                    favoriteTours.RemoveAll(f => f.Id== tour.Id
);
                    dgv.Rows[e.RowIndex].Cells["Favorite"].Value = "☆";
                    MessageBox.Show
($"Тур \"{tour.HotelName}\" удалён из избранного",
                        "Избранное", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    favoriteTours.Add(tour);
                    dgv.Rows[e.RowIndex].Cells["Favorite"].Value = "★";
                    MessageBox.Show
($"Тур \"{tour.HotelName}\" добавлен в избранное",
                        "Избранное", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (e.ColumnIndex == dgv.Columns["Book"].Index)
            {
                Form6 form6 = new Form6(tour);
                form6.ShowDialog();
                // Обновляем список туров
                LoadAndShowTours();
            }
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
            Form5 favForm = new Form5(favoriteTours);
            favForm.ShowDialog();
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
        }
    }
}