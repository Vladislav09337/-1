using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TouristAgency00
{
    public partial class Form3 : Form
    {
        // Статические данные для передачи в Form4
        public static int HotelStars = 0;
        public static string MealType = "";
        public static List<string> SelectedServices = new List<string>();
        public static int MinPrice = 0;
        public static int MaxPrice = 500000;
        public static bool Step3Skipped = false;

        public Form3()
        {
            InitializeComponent();

            // Заполняем ComboBox для звёзд (если используете ComboBox)
            if (cmdStar != null)
            {
                cmdStar.Items.Clear();
                cmdStar.Items.Add("Не имеет значения");
                cmdStar.Items.Add("★ 1 звезда");
                cmdStar.Items.Add("★★ 2 звезды");
                cmdStar.Items.Add("★★★ 3 звезды");
                cmdStar.Items.Add("★★★★ 4 звезды");
                cmdStar.Items.Add("★★★★★ 5 звёзд");
                cmdStar.DropDownStyle = ComboBoxStyle.DropDownList;
                cmdStar.SelectedIndex = 0;
                cmdStar.SelectedIndexChanged += CmdStar_SelectedIndexChanged;
            }

            // Подписываем события
            this.btnSearch.Click += BtnSearch_Click;
            this.btnTop.Click += BtnTop_Click;
            this.btnNext.Click += BtnNext_Click;
            this.btnSkip.Click += BtnSkip_Click;
            this.trackPrice.ValueChanged += TrackPrice_ValueChanged;

            // Подписываем NumericUpDown
            this.nudMin.ValueChanged += NudMin_ValueChanged;
            this.nudMax.ValueChanged += NudMax_ValueChanged;

            // Загружаем сохраненные значения
            LoadSavedValues();
        }

        private void LoadSavedValues()
        {
            // Звезды через ComboBox (если есть)
            if (cmdStar != null && HotelStars > 0 && HotelStars <= 5)
            {
                cmdStar.SelectedIndex = HotelStars;
            }
            else if (cmdStar != null)
            {
                cmdStar.SelectedIndex = 0;
            }

            // Тип питания
            if (!string.IsNullOrEmpty(MealType))
            {
                int index = cmbMeal.FindStringExact(MealType);
                if (index >= 0) cmbMeal.SelectedIndex = index;
            }
            else
                cmbMeal.SelectedIndex = 0;

            // Цена
            int maxTrack = trackPrice.Maximum;
            int minVal = MinPrice > maxTrack ? maxTrack : MinPrice;
            int maxVal = MaxPrice > maxTrack ? maxTrack : MaxPrice;

            nudMin.Value = minVal;
            nudMax.Value = maxVal;
            trackPrice.Value = maxVal;

            // Услуги
            if (SelectedServices.Count > 0)
            {
                CheckBox[] services = { checkBoxSPA, checkBoxSvadba, checkBoxWiFi, checkBoxSport,
                                        checkBoxVIP, checkBoxKondicioner, checkBoxFIT, checkBoxExpirience, checkBoxTransfer };
                foreach (var service in services)
                {
                    if (SelectedServices.Contains(service.Text))
                        service.Checked = true;
                }
            }
        }

        private void CmdStar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdStar != null)
            {
                HotelStars = cmdStar.SelectedIndex;
            }
        }

        private void UpdateStarsDisplay(int rating)
        {
            // Если используете звёзды Label, обновите их
            HotelStars = rating;
            if (cmdStar != null && rating >= 0 && rating <= 5)
            {
                cmdStar.SelectedIndex = rating;
            }
        }

        private void TrackPrice_ValueChanged(object sender, EventArgs e)
        {
            nudMax.Value = trackPrice.Value;
        }

        private void NudMin_ValueChanged(object sender, EventArgs e)
        {
            if (nudMin.Value > nudMax.Value)
                nudMax.Value = nudMin.Value;
        }

        private void NudMax_ValueChanged(object sender, EventArgs e)
        {
            if (nudMax.Value < nudMin.Value)
                nudMin.Value = nudMax.Value;
            trackPrice.Value = (int)nudMax.Value;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы и так находитесь на третьем шаге поиска!",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnTop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Избранное", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ГЛАВНОЕ: переход на Form4 при нажатии "Далее"
        private void BtnNext_Click(object sender, EventArgs e)
        {
            // Сохраняем выбранные данные
            MealType = cmbMeal.SelectedItem.ToString();
            MinPrice = (int)nudMin.Value;
            MaxPrice = (int)nudMax.Value;
            Step3Skipped = false;

            // Сохраняем услуги
            SelectedServices.Clear();
            CheckBox[] services = { checkBoxSPA, checkBoxSvadba, checkBoxWiFi, checkBoxSport,
                                    checkBoxVIP, checkBoxKondicioner, checkBoxFIT, checkBoxExpirience, checkBoxTransfer };
            foreach (var service in services)
                if (service.Checked) SelectedServices.Add(service.Text);

            // Показываем сообщение о сохранении
            MessageBox.Show($"Сохранено!\nЗвезды: {HotelStars}\nПитание: {MealType}\nУслуг: {SelectedServices.Count}\nЦена: от {MinPrice} до {MaxPrice}",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ПЕРЕХОД НА FORM4
            this.Hide();           // Скрываем текущую форму
            Form4 form4 = new Form4();  // Создаём Form4
            form4.ShowDialog();     // Показываем Form4
            this.Close();           // Закрываем Form3
        }

        // ГЛАВНОЕ: переход на Form4 при нажатии "Пропустить"
        private void BtnSkip_Click(object sender, EventArgs e)
        {
            Step3Skipped = true;
            MessageBox.Show("Шаг 3 пропущен. Будут использованы значения по умолчанию.",
                "Пропуск", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ПЕРЕХОД НА FORM4
            this.Hide();           // Скрываем текущую форму
            Form4 form4 = new Form4();  // Создаём Form4
            form4.ShowDialog();     // Показываем Form4
            this.Close();           // Закрываем Form3
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}