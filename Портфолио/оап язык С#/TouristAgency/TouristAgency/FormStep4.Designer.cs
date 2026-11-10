using System.Drawing;
using System.Windows.Forms;

namespace TouristAgency
{
    partial class FormStep4
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvResults;
        private Button btnBack;
        private Button btnFavoritesList;
        private Button btnSearch;
        private Button btnFavoritesMenu;
        private Label lblTitle;
        private Label lblSteps;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private Label lblNum4;
        private Label lblMainTitle;
        private Label lblResultsTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvResults = new DataGridView();
            this.btnBack = new Button();
            this.btnFavoritesList = new Button();
            this.btnSearch = new Button();
            this.btnFavoritesMenu = new Button();
            this.lblTitle = new Label();
            this.lblSteps = new Label();
            this.lblNum1 = new Label();
            this.lblNum2 = new Label();
            this.lblNum3 = new Label();
            this.lblNum4 = new Label();
            this.lblMainTitle = new Label();
            this.lblResultsTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();

            // Form
            this.Text = "Туристическое агентство";
            this.Size = new Size(1000, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // lblTitle
            this.lblTitle.Text = "Туристическое агентство";
            this.lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            this.lblTitle.Location = new Point(30, 20);
            this.lblTitle.Size = new Size(250, 35);

            // btnSearch
            this.btnSearch.Text = "Поиск";
            this.btnSearch.Font = new Font("Segoe UI", 9);
            this.btnSearch.ForeColor = Color.Blue;
            this.btnSearch.BackColor = Color.White;
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.Location = new Point(30, 65);
            this.btnSearch.Size = new Size(60, 30);
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);

            // btnFavoritesMenu
            this.btnFavoritesMenu.Text = "Избранное";
            this.btnFavoritesMenu.Font = new Font("Segoe UI", 9);
            this.btnFavoritesMenu.ForeColor = Color.Blue;
            this.btnFavoritesMenu.BackColor = Color.White;
            this.btnFavoritesMenu.FlatStyle = FlatStyle.Flat;
            this.btnFavoritesMenu.Location = new Point(100, 65);
            this.btnFavoritesMenu.Size = new Size(80, 30);
            this.btnFavoritesMenu.Click += new System.EventHandler(this.BtnFavoritesMenu_Click);

            // lblSteps
            this.lblSteps.Text = "Шаг 1 | Шаг 2 | Шаг 3 | Шаг 4";
            this.lblSteps.Font = new Font("Segoe UI", 10);
            this.lblSteps.ForeColor = Color.Gray;
            this.lblSteps.Location = new Point(30, 105);
            this.lblSteps.Size = new Size(250, 25);

            // lblNum1
            this.lblNum1.Text = "1";
            this.lblNum1.Font = new Font("Segoe UI", 10);
            this.lblNum1.ForeColor = Color.Gray;
            this.lblNum1.Location = new Point(30, 130);
            this.lblNum1.Size = new Size(20, 25);

            // lblNum2
            this.lblNum2.Text = "2";
            this.lblNum2.Font = new Font("Segoe UI", 10);
            this.lblNum2.ForeColor = Color.Gray;
            this.lblNum2.Location = new Point(80, 130);
            this.lblNum2.Size = new Size(20, 25);

            // lblNum3
            this.lblNum3.Text = "3";
            this.lblNum3.Font = new Font("Segoe UI", 10);
            this.lblNum3.ForeColor = Color.Gray;
            this.lblNum3.Location = new Point(130, 130);
            this.lblNum3.Size = new Size(20, 25);

            // lblNum4 - текущий шаг (зеленый)
            this.lblNum4.Text = "4";
            this.lblNum4.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.lblNum4.ForeColor = Color.Green;
            this.lblNum4.Location = new Point(180, 130);
            this.lblNum4.Size = new Size(20, 25);

            // lblMainTitle
            this.lblMainTitle.Text = "Результаты поиска";
            this.lblMainTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            this.lblMainTitle.Location = new Point(30, 175);
            this.lblMainTitle.Size = new Size(200, 30);

            // btnFavoritesList
            this.btnFavoritesList.Text = "Избранное";
            this.btnFavoritesList.Location = new Point(830, 170);
            this.btnFavoritesList.Size = new Size(120, 35);
            this.btnFavoritesList.BackColor = Color.FromArgb(231, 76, 60);
            this.btnFavoritesList.ForeColor = Color.White;
            this.btnFavoritesList.FlatStyle = FlatStyle.Flat;
            this.btnFavoritesList.Click += new System.EventHandler(this.BtnFavoritesList_Click);

            // dgvResults
            this.dgvResults.Location = new Point(30, 220);
            this.dgvResults.Size = new Size(920, 350);
            this.dgvResults.ReadOnly = true;
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.BackgroundColor = Color.White;
            this.dgvResults.BorderStyle = BorderStyle.Fixed3D;
            this.dgvResults.CellClick += new DataGridViewCellEventHandler(this.DgvResults_CellClick);

            // btnBack
            this.btnBack.Text = "Назад";
            this.btnBack.Location = new Point(30, 580);
            this.btnBack.Size = new Size(100, 35);
            this.btnBack.BackColor = Color.FromArgb(149, 165, 166);
            this.btnBack.ForeColor = Color.White;
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            // Controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFavoritesMenu);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum4);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.btnFavoritesList);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnBack);

            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
        }
    }
}