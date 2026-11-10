using System;
using System.Windows.Forms;

namespace TouristAgency
{
    public partial class FormStep1 : Form
    {
        public FormStep1()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (nudPeople.Value == 0)
            {
                MessageBox.Show("Заполните количество человек!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.GlobalPreferences.PeriodStart = dtpStart.Value;
            Program.GlobalPreferences.PeriodEnd = dtpEnd.Value;
            Program.GlobalPreferences.Days = (int)nudDays.Value;
            Program.GlobalPreferences.PeopleCount = (int)nudPeople.Value;
            Program.GlobalPreferences.HasChildren = chkChildren.Checked;

            this.Hide();
            FormStep2 form2 = new FormStep2();
            form2.ShowDialog();
            this.Close();
        }

        private void BtnSkip_Click(object sender, EventArgs e)
        {
            if (nudPeople.Value == 0)
            {
                MessageBox.Show("Нельзя пропустить шаг! Заполните количество человек.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.GlobalPreferences.PeriodStart = dtpStart.Value;
            Program.GlobalPreferences.PeriodEnd = dtpEnd.Value;
            Program.GlobalPreferences.Days = (int)nudDays.Value;
            Program.GlobalPreferences.PeopleCount = (int)nudPeople.Value;
            Program.GlobalPreferences.HasChildren = chkChildren.Checked;
            Program.GlobalPreferences.Step1Skipped = true;

            this.Hide();
            FormStep2 form2 = new FormStep2();
            form2.ShowDialog();
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уже на шаге 1", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnFavorites_Click(object sender, EventArgs e)
        {
            FormFavorites fav = new FormFavorites();
            fav.ShowDialog();
        }

        private void FormStep1_Load(object sender, EventArgs e)
        {

        }
    }
}