using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TouristAgency
{
    public partial class FormStep2 : Form
    {
        private List<string> allTypes = new List<string>
        {
            "Международный туризм",
            "Экскурсионные туры",
            "Культурно-исторические туры",
            "Пляжный отдых",
            "Внутренний туризм",
            "Лечебно-оздоровительные туры"
        };

        public FormStep2()
        {
            InitializeComponent();
            LoadAvailableTypes();
            SetupDragDrop();
        }

        private void LoadAvailableTypes()
        {
            foreach (string type in allTypes)
                lstAvailable.Items.Add(type);
        }

        private void SetupDragDrop()
        {
            lstAvailable.MouseDown += (s, e) =>
            {
                if (lstAvailable.SelectedItem != null)
                    lstAvailable.DoDragDrop(lstAvailable.SelectedItem, DragDropEffects.Move);
            };

            lstPriority.MouseDown += (s, e) =>
            {
                if (lstPriority.SelectedItem != null)
                    lstPriority.DoDragDrop(lstPriority.SelectedItem, DragDropEffects.Move);
            };

            lstAvailable.DragOver += (s, e) => e.Effect = DragDropEffects.Move;
            lstPriority.DragOver += (s, e) => e.Effect = DragDropEffects.Move;

            lstAvailable.DragDrop += (s, e) =>
            {
                string data = e.Data.GetData(typeof(string)).ToString();
                if (!lstAvailable.Items.Contains(data))
                    lstAvailable.Items.Add(data);
                lstPriority.Items.Remove(data);
            };

            lstPriority.DragDrop += (s, e) =>
            {
                string data = e.Data.GetData(typeof(string)).ToString();
                if (!lstPriority.Items.Contains(data))
                    lstPriority.Items.Add(data);
                lstAvailable.Items.Remove(data);
                Reorder();
            };
        }

        private void Reorder()
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
                Reorder();
            }
        }

        private void BtnMoveLeft_Click(object sender, EventArgs e)
        {
            if (lstPriority.SelectedItem != null)
            {
                lstAvailable.Items.Add(lstPriority.SelectedItem);
                lstPriority.Items.Remove(lstPriority.SelectedItem);
                Reorder();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            List<string> priorities = new List<string>();
            foreach (var item in lstPriority.Items)
            {
                string s = item.ToString();
                if (s.Contains(". "))
                    s = s.Substring(s.IndexOf(". ") + 2);
                priorities.Add(s);
            }
            Program.GlobalPreferences.PrioritizedTourTypes = priorities;
            Program.GlobalPreferences.Step2Skipped = false;

            this.Hide();
            FormStep3 form3 = new FormStep3();
            form3.ShowDialog();
            this.Close();
        }

        private void BtnSkip_Click(object sender, EventArgs e)
        {
            Program.GlobalPreferences.Step2Skipped = true;
            this.Hide();
            FormStep3 form3 = new FormStep3();
            form3.ShowDialog();
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStep1 form1 = new FormStep1();
            form1.ShowDialog();
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

        private void FormStep2_Load(object sender, EventArgs e)
        {

        }

        private void lstAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}