using System.Drawing;
using System.Windows.Forms;

namespace TouristAgency
{
    partial class FormStep3
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbStars;
        private CheckedListBox clbServices;
        private NumericUpDown nudMin;
        private NumericUpDown nudMax;
        private TrackBar trackPrice;
        private Button btnNext;
        private Button btnSkip;
        private Button btnBack;
        private Button btnSearch;
        private Button btnFavorites;
        private Label lblTitle;
        private Label lblSteps;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private Label lblNum4;
        private Label lblMainTitle;
        private Label lblStars;
        private Label lblMeal;
        private Label lblServices;
        private Label lblPrice;
        private Label lblFrom;
        private Label lblTo;
        private Label lblPriceRange;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbStars = new System.Windows.Forms.ComboBox();
            this.clbServices = new System.Windows.Forms.CheckedListBox();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.trackPrice = new System.Windows.Forms.TrackBar();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblStars = new System.Windows.Forms.Label();
            this.lblMeal = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblPriceRange = new System.Windows.Forms.Label();
            this.cmbMeal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStars
            // 
            this.cmbStars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStars.Items.AddRange(new object[] {
            "Не имеет значения",
            "1 звезда",
            "2 звезды",
            "3 звезды",
            "4 звезды",
            "5 звезд"});
            this.cmbStars.Location = new System.Drawing.Point(160, 220);
            this.cmbStars.Name = "cmbStars";
            this.cmbStars.Size = new System.Drawing.Size(180, 21);
            this.cmbStars.TabIndex = 10;
            // 
            // clbServices
            // 
            this.clbServices.CheckOnClick = true;
            this.clbServices.Location = new System.Drawing.Point(30, 350);
            this.clbServices.MultiColumn = true;
            this.clbServices.Name = "clbServices";
            this.clbServices.Size = new System.Drawing.Size(350, 169);
            this.clbServices.TabIndex = 14;
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(490, 260);
            this.nudMin.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(100, 20);
            this.nudMin.TabIndex = 17;
            this.nudMin.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(640, 260);
            this.nudMax.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(100, 20);
            this.nudMax.TabIndex = 19;
            this.nudMax.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // trackPrice
            // 
            this.trackPrice.Location = new System.Drawing.Point(450, 300);
            this.trackPrice.Maximum = 50000;
            this.trackPrice.Name = "trackPrice";
            this.trackPrice.Size = new System.Drawing.Size(290, 45);
            this.trackPrice.TabIndex = 20;
            this.trackPrice.TickFrequency = 5000;
            this.trackPrice.Value = 15000;
            this.trackPrice.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(670, 580);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 35);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(550, 580);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(100, 35);
            this.btnSkip.TabIndex = 23;
            this.btnSkip.Text = "Пропустить";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.BtnSkip_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(30, 580);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Blue;
            this.btnSearch.Location = new System.Drawing.Point(30, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnFavorites
            // 
            this.btnFavorites.BackColor = System.Drawing.Color.White;
            this.btnFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorites.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFavorites.ForeColor = System.Drawing.Color.Blue;
            this.btnFavorites.Location = new System.Drawing.Point(100, 65);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(80, 30);
            this.btnFavorites.TabIndex = 2;
            this.btnFavorites.Text = "Избранное";
            this.btnFavorites.UseVisualStyleBackColor = false;
            this.btnFavorites.Click += new System.EventHandler(this.BtnFavorites_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Туристическое агентство";
            // 
            // lblSteps
            // 
            this.lblSteps.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSteps.ForeColor = System.Drawing.Color.Gray;
            this.lblSteps.Location = new System.Drawing.Point(30, 105);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(250, 25);
            this.lblSteps.TabIndex = 3;
            this.lblSteps.Text = "Шаг 1 | Шаг 2 | Шаг 3 | Шаг 4";
            // 
            // lblNum1
            // 
            this.lblNum1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNum1.ForeColor = System.Drawing.Color.Gray;
            this.lblNum1.Location = new System.Drawing.Point(30, 130);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(20, 25);
            this.lblNum1.TabIndex = 4;
            this.lblNum1.Text = "1";
            // 
            // lblNum2
            // 
            this.lblNum2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNum2.ForeColor = System.Drawing.Color.Gray;
            this.lblNum2.Location = new System.Drawing.Point(80, 130);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(20, 25);
            this.lblNum2.TabIndex = 5;
            this.lblNum2.Text = "2";
            // 
            // lblNum3
            // 
            this.lblNum3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNum3.ForeColor = System.Drawing.Color.Green;
            this.lblNum3.Location = new System.Drawing.Point(130, 130);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(20, 25);
            this.lblNum3.TabIndex = 6;
            this.lblNum3.Text = "3";
            // 
            // lblNum4
            // 
            this.lblNum4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNum4.ForeColor = System.Drawing.Color.Gray;
            this.lblNum4.Location = new System.Drawing.Point(180, 130);
            this.lblNum4.Name = "lblNum4";
            this.lblNum4.Size = new System.Drawing.Size(20, 25);
            this.lblNum4.TabIndex = 7;
            this.lblNum4.Text = "4";
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMainTitle.Location = new System.Drawing.Point(30, 175);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(200, 30);
            this.lblMainTitle.TabIndex = 8;
            this.lblMainTitle.Text = "Условия отеля";
            // 
            // lblStars
            // 
            this.lblStars.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStars.Location = new System.Drawing.Point(30, 220);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(120, 25);
            this.lblStars.TabIndex = 9;
            this.lblStars.Text = "Категория отеля";
            // 
            // lblMeal
            // 
            this.lblMeal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMeal.Location = new System.Drawing.Point(30, 270);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(120, 25);
            this.lblMeal.TabIndex = 11;
            this.lblMeal.Text = "Тип питания";
            // 
            // lblServices
            // 
            this.lblServices.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblServices.Location = new System.Drawing.Point(30, 320);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(150, 25);
            this.lblServices.TabIndex = 13;
            this.lblServices.Text = "Дополнительные услуги";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(450, 220);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(120, 25);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Стоимость тура";
            // 
            // lblFrom
            // 
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFrom.Location = new System.Drawing.Point(450, 260);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 25);
            this.lblFrom.TabIndex = 16;
            this.lblFrom.Text = "от";
            // 
            // lblTo
            // 
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTo.Location = new System.Drawing.Point(600, 260);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(30, 25);
            this.lblTo.TabIndex = 18;
            this.lblTo.Text = "до";
            // 
            // lblPriceRange
            // 
            this.lblPriceRange.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPriceRange.ForeColor = System.Drawing.Color.Gray;
            this.lblPriceRange.Location = new System.Drawing.Point(450, 345);
            this.lblPriceRange.Name = "lblPriceRange";
            this.lblPriceRange.Size = new System.Drawing.Size(290, 20);
            this.lblPriceRange.TabIndex = 21;
            this.lblPriceRange.Text = "0 -------------------- 15000 -------------------- 50000";
            this.lblPriceRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMeal
            // 
            this.cmbMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeal.Items.AddRange(new object[] {
            "Не имеет значения",
            "Без завтрака",
            "Завтрак",
            "Полупансион",
            "Всё включено"});
            this.cmbMeal.Location = new System.Drawing.Point(160, 270);
            this.cmbMeal.Name = "cmbMeal";
            this.cmbMeal.Size = new System.Drawing.Size(180, 21);
            this.cmbMeal.TabIndex = 12;
            // 
            // FormStep3
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFavorites);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum4);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.lblStars);
            this.Controls.Add(this.cmbStars);
            this.Controls.Add(this.lblMeal);
            this.Controls.Add(this.cmbMeal);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.clbServices);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.trackPrice);
            this.Controls.Add(this.lblPriceRange);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormStep3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Туристическое агентство";
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ComboBox cmbMeal;
    }
}