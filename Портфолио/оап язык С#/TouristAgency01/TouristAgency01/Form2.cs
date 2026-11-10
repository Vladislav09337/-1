using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TouristAgency00.Models;

namespace TouristAgency00
{
    public partial class Form2 : Form
    {
        private SearchParams searchParams;

        public Form2()
        {
            InitializeComponent();
            this.searchParams = new SearchParams();
            LoadAvailableTypes();
            SubscribeEvents();
        }

        public Form2(SearchParams searchParams)
        {
            InitializeComponent();
            this.searchParams = searchParams;
            LoadAvailableTypes();
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            this.btnMoveRight.Click += btnMoveRight_Click;
            this.btnMoveLeft.Click += btnMoveLeft_Click;
            this.btnNext.Click += btnNext_Click;
            this.btnSkip.Click += btnSkip_Click;
            this.btnSearch.Click += btnSearch_Click;
            this.btnTop.Click += btnTop_Click;
        }

        private void LoadAvailableTypes()
        {
            lstAvailable.Items.Clear();
            lstAvailable.Items.AddRange(new string[]
            {
                "Международный туризм",
                "Экскурсионные туры",
                "Культурно-исторические туры",
                "Пляжный отдых",
                "Лечебно-оздоровительные туры",
                "Внутренний туризм"
            });
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (lstAvailable.SelectedItem != null)
            {
                object item = lstAvailable.SelectedItem;
                lstAvailable.Items.Remove(item);
                lstPriority.Items.Add(item);
            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (lstPriority.SelectedItem != null)
            {
                object item = lstPriority.SelectedItem;
                lstPriority.Items.Remove(item);
                lstAvailable.Items.Add(item);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                searchParams.RankedPreferences = GetRankedPreferences();

                Form3 form3 = new Form3(searchParams);
                form3.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при переходе: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> GetRankedPreferences()
        {
            List<string> preferences = new List<string>();

            // Добавляем выбранные типы в порядке приоритета
            foreach (var item in lstPriority.Items)
            {
                preferences.Add(item.ToString());
            }

            // Если ничего не выбрано, добавляем все доступные типы
            if (preferences.Count == 0)
            {
                foreach (var item in lstAvailable.Items)
                {
                    preferences.Add(item.ToString());
                }
            }

            return preferences;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 form3 = new Form3(searchParams);
                form3.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при переходе: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите начать поиск заново?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция избранного будет доступна в следующей версии!",
                "Избранное", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Дополнительная инициализация при загрузке формы
        }
    }
}