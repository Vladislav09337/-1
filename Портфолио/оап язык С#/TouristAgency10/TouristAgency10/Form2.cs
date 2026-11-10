using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace TouristAgency00
{
    public partial class Form2 : Form
    {
        private SearchParams searchParams;

        public Form2(SearchParams searchParams)
        {
            InitializeComponent();
            this.searchParams = searchParams;
            LoadAvailableTypes();

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
            this.Hide();
            Form3 form3 = new Form3(searchParams);  // ← ПЕРЕДАЕМ ПАРАМЕТР
            form3.ShowDialog();
            this.Close();
        }


        private void btnSkip_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(searchParams);
            form3.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Избранное", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}