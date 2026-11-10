using System.Drawing;
using System.Windows.Forms;

namespace TouristAgency
{
    partial class FormStep1
    {
        private System.ComponentModel.IContainer components = null;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private NumericUpDown nudDays;
        private NumericUpDown nudPeople;
        private CheckBox chkChildren;
        private Button btnSkip;
        private Button btnNext;
        private Button btnSearch;
        private Button btnFavorites;
        private Label lblTitle;
        private Label lblSteps;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private Label lblNum4;
        private Label lblMainTitle;
        private Panel line;
        private Label lblStart;
        private Label lblEnd;
        private Label lblDays;
        private Label lblPeople;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.nudPeople = new System.Windows.Forms.NumericUpDown();
            this.chkChildren = new System.Windows.Forms.CheckBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Panel();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd.MM.yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(180, 240);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(130, 20);
            this.dtpStart.TabIndex = 11;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd.MM.yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(190, 290);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(130, 20);
            this.dtpEnd.TabIndex = 13;
            this.dtpEnd.Value = new System.DateTime(2026, 6, 15, 15, 11, 26, 189);
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(160, 340);
            this.nudDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(80, 20);
            this.nudDays.TabIndex = 15;
            this.nudDays.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // nudPeople
            // 
            this.nudPeople.Location = new System.Drawing.Point(170, 390);
            this.nudPeople.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPeople.Name = "nudPeople";
            this.nudPeople.Size = new System.Drawing.Size(80, 20);
            this.nudPeople.TabIndex = 17;
            this.nudPeople.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // chkChildren
            // 
            this.chkChildren.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkChildren.Location = new System.Drawing.Point(270, 390);
            this.chkChildren.Name = "chkChildren";
            this.chkChildren.Size = new System.Drawing.Size(80, 25);
            this.chkChildren.TabIndex = 18;
            this.chkChildren.Text = "Дети";
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(320, 440);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(100, 35);
            this.btnSkip.TabIndex = 19;
            this.btnSkip.Text = "Пропустить";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.BtnSkip_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(440, 440);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 35);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Blue;
            this.btnSearch.Location = new System.Drawing.Point(48, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnFavorites
            // 
            this.btnFavorites.BackColor = System.Drawing.Color.White;
            this.btnFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorites.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFavorites.ForeColor = System.Drawing.Color.Blue;
            this.btnFavorites.Location = new System.Drawing.Point(134, 65);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(87, 30);
            this.btnFavorites.TabIndex = 2;
            this.btnFavorites.Text = "Избранное";
            this.btnFavorites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorites.UseVisualStyleBackColor = false;
            this.btnFavorites.Click += new System.EventHandler(this.BtnFavorites_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 35);
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
            this.lblNum1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNum1.ForeColor = System.Drawing.Color.Green;
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
            this.lblNum3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNum3.ForeColor = System.Drawing.Color.Gray;
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
            this.lblMainTitle.Size = new System.Drawing.Size(250, 30);
            this.lblMainTitle.TabIndex = 8;
            this.lblMainTitle.Text = "Основная информация";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.line.Location = new System.Drawing.Point(30, 210);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(520, 2);
            this.line.TabIndex = 9;
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStart.Location = new System.Drawing.Point(30, 235);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(140, 30);
            this.lblStart.TabIndex = 10;
            this.lblStart.Text = "Дата начала периода:";
            // 
            // lblEnd
            // 
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEnd.Location = new System.Drawing.Point(30, 285);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(150, 30);
            this.lblEnd.TabIndex = 12;
            this.lblEnd.Text = "Дата окончания периода:";
            // 
            // lblDays
            // 
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDays.Location = new System.Drawing.Point(30, 335);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(120, 30);
            this.lblDays.TabIndex = 14;
            this.lblDays.Text = "Количество дней:";
            // 
            // lblPeople
            // 
            this.lblPeople.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPeople.Location = new System.Drawing.Point(30, 385);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(130, 30);
            this.lblPeople.TabIndex = 16;
            this.lblPeople.Text = "Количество человек:";
            // 
            // FormStep1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 481);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFavorites);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum4);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.line);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.nudDays);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.nudPeople);
            this.Controls.Add(this.chkChildren);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormStep1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Туристическое агентство";
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeople)).EndInit();
            this.ResumeLayout(false);

        }
    }
}