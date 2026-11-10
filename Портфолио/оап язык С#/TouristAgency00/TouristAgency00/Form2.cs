using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TouristAgency00
{
    public partial class Form2 : Form
    {
        public static List<string> PrioritizedTourTypes = new List<string>();
        public static bool Step2Skipped = false;

        private List<string> allTourTypes = new List<string>
        {
            "Международный туризм",
            "Экскурсионные туры",
            "Культурно-исторические туры",
            "Пляжный отдых",
            "Внутренний туризм",
            "Лечебно-оздоровительные туры"
        };

        public Form2()
        {
            InitializeComponent();

            this.btnSearch.Click += BtnSearch_Click;
            this.btnTop.Click += BtnTop_Click;
            this.btnNext.Click += BtnNext_Click;
            this.btnSkip.Click += BtnSkip_Click;
            this.btnMoveRight.Click += BtnMoveRight_Click;
            this.btnMoveLeft.Click += BtnMoveLeft_Click;

            LoadAvailableTypes();
            SetupDragDrop();
        }

        private void LoadAvailableTypes()
        {
            foreach (string type in allTourTypes)
                lstAvailable.Items.Add(type);
        }

        private void SetupDragDrop()
        {
            // 1. НАЧАЛО ПЕРЕТАСКИВАНИЯ - MouseDown
            // Когда нажимаем кнопку мыши на lstAvailable
            lstAvailable.MouseDown += (s, e) => {
                if (lstAvailable.SelectedItem != null)
                    lstAvailable.DoDragDrop(lstAvailable.SelectedItem, DragDropEffects.Move);
            };

            // То же самое для lstPriority
            lstPriority.MouseDown += (s, e) => {
                if (lstPriority.SelectedItem != null)
                    lstPriority.DoDragDrop(lstPriority.SelectedItem, DragDropEffects.Move);
            };

            // 2. ВО ВРЕМЯ ПЕРЕТАСКИВАНИЯ - DragOver
            // Разрешаем перетаскивание (меняем курсор на "+")
            lstAvailable.DragOver += (s, e) => e.Effect = DragDropEffects.Move;
            lstPriority.DragOver += (s, e) => e.Effect = DragDropEffects.Move;

            // 3. ЗАВЕРШЕНИЕ ПЕРЕТАСКИВАНИЯ - DragDrop (когда отпустили мышь)

            // Если перетащили элемент в lstAvailable
            lstAvailable.DragDrop += (s, e) => {
                string data = e.Data.GetData(typeof(string)).ToString();
                if (!lstAvailable.Items.Contains(data))
                    lstAvailable.Items.Add(data);  // Добавляем в левый список
                lstPriority.Items.Remove(data);     // Удаляем из правого
            };

            // Если перетащили элемент в lstPriority
            lstPriority.DragDrop += (s, e) => {
                string data = e.Data.GetData(typeof(string)).ToString();
                if (!lstPriority.Items.Contains(data))
                    lstPriority.Items.Add(data);    // Добавляем в правый список
                lstAvailable.Items.Remove(data);     // Удаляем из левого
                ReorderPriority();                   // Обновляем нумерацию
            };
        }
        private void ReorderPriority()
        {
            List<string> items = new List<string>();
            foreach (var item in lstPriority.Items)
                items.Add(item.ToString());
            lstPriority.Items.Clear();
            for (int i = 0; i < items.Count; i++)
                lstPriority.Items.Add((i + 1) + ". " + items[i]);
        }

        private void BtnMoveRight_Click(object sender, EventArgs e)
        {
            if (lstAvailable.SelectedItem != null)
            {
                lstPriority.Items.Add(lstAvailable.SelectedItem);
                lstAvailable.Items.Remove(lstAvailable.SelectedItem);
                ReorderPriority();
            }
        }

        private void BtnMoveLeft_Click(object sender, EventArgs e)
        {
            if (lstPriority.SelectedItem != null)
            {
                string item = lstPriority.SelectedItem.ToString();
                if (item.Contains(". "))
                    item = item.Substring(item.IndexOf(". ") + 2);
                lstAvailable.Items.Add(item);
                lstPriority.Items.Remove(lstPriority.SelectedItem);
                ReorderPriority();
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
            MessageBox.Show("Избранное", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Кнопка "Далее" - переход на Form3
        private void BtnNext_Click(object sender, EventArgs e)
        {
            // Сохраняем приоритеты
            PrioritizedTourTypes.Clear();
            foreach (var item in lstPriority.Items)
            {
                string s = item.ToString();
                if (s.Contains(". "))
                    s = s.Substring(s.IndexOf(". ") + 2);
                PrioritizedTourTypes.Add(s);
            }
            Step2Skipped = false;

            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }

        // Кнопка "Пропустить"
        private void BtnSkip_Click(object sender, EventArgs e)
        {
            Step2Skipped = true;

            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}