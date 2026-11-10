using System.Drawing;
using System.Windows.Forms;

namespace TouristAgency
{
    partial class FormFavorites
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvFavorites;
        private Button btnBook;
        private Button btnClose;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvFavorites = new DataGridView();
            this.btnBook = new Button();
            this.btnClose = new Button();
            this.lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorites)).BeginInit();
            this.SuspendLayout();

            this.Text = "Избранное";
            this.Size = new Size(900, 520);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.lblTitle.Text = "Избранные туры";
            this.lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(300, 35);

            this.dgvFavorites.Location = new Point(20, 70);
            this.dgvFavorites.Size = new Size(840, 340);
            this.dgvFavorites.ReadOnly = true;
            this.dgvFavorites.AllowUserToAddRows = false;
            this.dgvFavorites.RowHeadersVisible = false;
            this.dgvFavorites.BackgroundColor = Color.White;
            this.dgvFavorites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvFavorites.Columns.Add("Country", "Страна");
            this.dgvFavorites.Columns.Add("City", "Город");
            this.dgvFavorites.Columns.Add("Price", "Стоимость");
            this.dgvFavorites.Columns.Add("Stars", "Звездность отеля");
            this.dgvFavorites.Columns.Add("Services", "Дополнительные услуги");
            this.dgvFavorites.Columns.Add("Dates", "Даты тура");

            this.btnBook.Text = "Забронировать";
            this.btnBook.Location = new Point(20, 430);
            this.btnBook.Size = new Size(140, 35);
            this.btnBook.BackColor = Color.FromArgb(46, 204, 113);
            this.btnBook.ForeColor = Color.White;
            this.btnBook.FlatStyle = FlatStyle.Flat;
            this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);

            this.btnClose.Text = "Закрыть";
            this.btnClose.Location = new Point(720, 430);
            this.btnClose.Size = new Size(140, 35);
            this.btnClose.BackColor = Color.FromArgb(149, 165, 166);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvFavorites);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnClose);

            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorites)).EndInit();
            this.ResumeLayout(false);
        }
    }
}