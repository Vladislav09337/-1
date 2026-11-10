using System.Drawing;
using System.Windows.Forms;

namespace TouristAgency
{
    partial class FormStep2
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox lstAvailable;
        private ListBox lstPriority;
        private Button btnMoveRight;
        private Button btnMoveLeft;
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
        private Label lblSubTitle;
        private Label lblLeftColumn;
        private Label lblRightColumn;
        private Label lblNumbers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstAvailable = new System.Windows.Forms.ListBox();
            this.lstPriority = new System.Windows.Forms.ListBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
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
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblLeftColumn = new System.Windows.Forms.Label();
            this.lblRightColumn = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAvailable
            // 
            this.lstAvailable.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstAvailable.ItemHeight = 20;
            this.lstAvailable.Location = new System.Drawing.Point(30, 280);
            this.lstAvailable.Name = "lstAvailable";
            this.lstAvailable.Size = new System.Drawing.Size(320, 264);
            this.lstAvailable.TabIndex = 11;
            this.lstAvailable.SelectedIndexChanged += new System.EventHandler(this.lstAvailable_SelectedIndexChanged);
            // 
            // lstPriority
            // 
            this.lstPriority.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstPriority.ItemHeight = 20;
            this.lstPriority.Location = new System.Drawing.Point(450, 280);
            this.lstPriority.Name = "lstPriority";
            this.lstPriority.Size = new System.Drawing.Size(350, 264);
            this.lstPriority.TabIndex = 15;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveRight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMoveRight.ForeColor = System.Drawing.Color.White;
            this.btnMoveRight.Location = new System.Drawing.Point(370, 370);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(60, 40);
            this.btnMoveRight.TabIndex = 12;
            this.btnMoveRight.Text = "→";
            this.btnMoveRight.UseVisualStyleBackColor = false;
            this.btnMoveRight.Click += new System.EventHandler(this.BtnMoveRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveLeft.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMoveLeft.ForeColor = System.Drawing.Color.White;
            this.btnMoveLeft.Location = new System.Drawing.Point(370, 430);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(60, 40);
            this.btnMoveLeft.TabIndex = 13;
            this.btnMoveLeft.Text = "←";
            this.btnMoveLeft.UseVisualStyleBackColor = false;
            this.btnMoveLeft.Click += new System.EventHandler(this.BtnMoveLeft_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(680, 580);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 35);
            this.btnNext.TabIndex = 19;
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
            this.btnSkip.TabIndex = 18;
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
            this.btnBack.TabIndex = 17;
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
            this.lblNum2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNum2.ForeColor = System.Drawing.Color.Green;
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
            this.lblMainTitle.Size = new System.Drawing.Size(200, 30);
            this.lblMainTitle.TabIndex = 8;
            this.lblMainTitle.Text = "Предпочтения";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitle.Location = new System.Drawing.Point(30, 210);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(500, 25);
            this.lblSubTitle.TabIndex = 9;
            this.lblSubTitle.Text = "Выберите и перетащите предпочтения в правый столбец в порядке приоритета";
            // 
            // lblLeftColumn
            // 
            this.lblLeftColumn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLeftColumn.Location = new System.Drawing.Point(30, 250);
            this.lblLeftColumn.Name = "lblLeftColumn";
            this.lblLeftColumn.Size = new System.Drawing.Size(200, 25);
            this.lblLeftColumn.TabIndex = 10;
            this.lblLeftColumn.Text = "Доступные предпочтения";
            // 
            // lblRightColumn
            // 
            this.lblRightColumn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRightColumn.Location = new System.Drawing.Point(450, 250);
            this.lblRightColumn.Name = "lblRightColumn";
            this.lblRightColumn.Size = new System.Drawing.Size(250, 25);
            this.lblRightColumn.TabIndex = 14;
            this.lblRightColumn.Text = "Приоритет (1 - наивысший)";
            // 
            // lblNumbers
            // 
            this.lblNumbers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblNumbers.Location = new System.Drawing.Point(450, 565);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(350, 20);
            this.lblNumbers.TabIndex = 16;
            this.lblNumbers.Text = "1        2        3        4        5        6";
            this.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormStep2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFavorites);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum4);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblLeftColumn);
            this.Controls.Add(this.lstAvailable);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.lblRightColumn);
            this.Controls.Add(this.lstPriority);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormStep2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Туристическое агентство";
            this.Load += new System.EventHandler(this.FormStep2_Load);
            this.ResumeLayout(false);

        }
    }
}