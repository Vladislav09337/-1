namespace TouristAgency00
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxTransfer;
        private System.Windows.Forms.CheckBox checkBoxKondicioner;
        private System.Windows.Forms.CheckBox checkBoxWiFi;
        private System.Windows.Forms.CheckBox checkBoxExpirience;
        private System.Windows.Forms.CheckBox checkBoxVIP;
        private System.Windows.Forms.CheckBox checkBoxSvadba;
        private System.Windows.Forms.CheckBox checkBoxFIT;
        private System.Windows.Forms.CheckBox checkBoxSport;
        private System.Windows.Forms.CheckBox checkBoxSPA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMeal;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.TrackBar trackPrice;
        private System.Windows.Forms.Label lblPriceRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStar1;
        private System.Windows.Forms.Label lblStar2;
        private System.Windows.Forms.Label lblStar3;
        private System.Windows.Forms.Label lblStar4;
        private System.Windows.Forms.Label lblStar5;
        private System.Windows.Forms.Label lblStarsTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.lblTo = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.trackPrice = new System.Windows.Forms.TrackBar();
            this.lblPriceRange = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxTransfer = new System.Windows.Forms.CheckBox();
            this.checkBoxKondicioner = new System.Windows.Forms.CheckBox();
            this.checkBoxWiFi = new System.Windows.Forms.CheckBox();
            this.checkBoxExpirience = new System.Windows.Forms.CheckBox();
            this.checkBoxVIP = new System.Windows.Forms.CheckBox();
            this.checkBoxSvadba = new System.Windows.Forms.CheckBox();
            this.checkBoxFIT = new System.Windows.Forms.CheckBox();
            this.checkBoxSport = new System.Windows.Forms.CheckBox();
            this.checkBoxSPA = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMeal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblStar1 = new System.Windows.Forms.Label();
            this.lblStar2 = new System.Windows.Forms.Label();
            this.lblStar3 = new System.Windows.Forms.Label();
            this.lblStar4 = new System.Windows.Forms.Label();
            this.lblStar5 = new System.Windows.Forms.Label();
            this.lblStarsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPrice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.Location = new System.Drawing.Point(57, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 42);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTop.Location = new System.Drawing.Point(171, 23);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(97, 42);
            this.btnTop.TabIndex = 1;
            this.btnTop.Text = "Избранное";
            this.btnTop.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 71);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Controls.Add(this.nudMin);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.nudMax);
            this.groupBox1.Controls.Add(this.trackPrice);
            this.groupBox1.Controls.Add(this.lblPriceRange);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbMeal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 388);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblFrom
            // 
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFrom.Location = new System.Drawing.Point(136, 250);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 25);
            this.lblFrom.TabIndex = 22;
            this.lblFrom.Text = "от";
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(176, 250);
            this.nudMin.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(100, 20);
            this.nudMin.TabIndex = 23;
            this.nudMin.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // lblTo
            // 
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTo.Location = new System.Drawing.Point(286, 250);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(30, 25);
            this.lblTo.TabIndex = 24;
            this.lblTo.Text = "до";
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(326, 250);
            this.nudMax.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(100, 20);
            this.nudMax.TabIndex = 25;
            this.nudMax.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // trackPrice
            // 
            this.trackPrice.Location = new System.Drawing.Point(136, 290);
            this.trackPrice.Maximum = 500000;
            this.trackPrice.Name = "trackPrice";
            this.trackPrice.Size = new System.Drawing.Size(290, 45);
            this.trackPrice.TabIndex = 26;
            this.trackPrice.TickFrequency = 10000;
            this.trackPrice.Value = 15000;
            // 
            // lblPriceRange
            // 
            this.lblPriceRange.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPriceRange.ForeColor = System.Drawing.Color.Gray;
            this.lblPriceRange.Location = new System.Drawing.Point(136, 335);
            this.lblPriceRange.Name = "lblPriceRange";
            this.lblPriceRange.Size = new System.Drawing.Size(290, 20);
            this.lblPriceRange.TabIndex = 27;
            this.lblPriceRange.Text = "0 -------------------- 15000 -------------------- 500000";
            this.lblPriceRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Стоимость тура";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxTransfer);
            this.groupBox2.Controls.Add(this.checkBoxKondicioner);
            this.groupBox2.Controls.Add(this.checkBoxWiFi);
            this.groupBox2.Controls.Add(this.checkBoxExpirience);
            this.groupBox2.Controls.Add(this.checkBoxVIP);
            this.groupBox2.Controls.Add(this.checkBoxSvadba);
            this.groupBox2.Controls.Add(this.checkBoxFIT);
            this.groupBox2.Controls.Add(this.checkBoxSport);
            this.groupBox2.Controls.Add(this.checkBoxSPA);
            this.groupBox2.Location = new System.Drawing.Point(28, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 128);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // checkBoxTransfer
            // 
            this.checkBoxTransfer.AutoSize = true;
            this.checkBoxTransfer.Location = new System.Drawing.Point(281, 87);
            this.checkBoxTransfer.Name = "checkBoxTransfer";
            this.checkBoxTransfer.Size = new System.Drawing.Size(77, 17);
            this.checkBoxTransfer.TabIndex = 8;
            this.checkBoxTransfer.Text = "Трансфер";
            // 
            // checkBoxKondicioner
            // 
            this.checkBoxKondicioner.AutoSize = true;
            this.checkBoxKondicioner.Location = new System.Drawing.Point(281, 56);
            this.checkBoxKondicioner.Name = "checkBoxKondicioner";
            this.checkBoxKondicioner.Size = new System.Drawing.Size(93, 17);
            this.checkBoxKondicioner.TabIndex = 7;
            this.checkBoxKondicioner.Text = "Кондиционер";
            // 
            // checkBoxWiFi
            // 
            this.checkBoxWiFi.AutoSize = true;
            this.checkBoxWiFi.Location = new System.Drawing.Point(281, 19);
            this.checkBoxWiFi.Name = "checkBoxWiFi";
            this.checkBoxWiFi.Size = new System.Drawing.Size(47, 17);
            this.checkBoxWiFi.TabIndex = 6;
            this.checkBoxWiFi.Text = "WiFi";
            // 
            // checkBoxExpirience
            // 
            this.checkBoxExpirience.AutoSize = true;
            this.checkBoxExpirience.Location = new System.Drawing.Point(160, 87);
            this.checkBoxExpirience.Name = "checkBoxExpirience";
            this.checkBoxExpirience.Size = new System.Drawing.Size(83, 17);
            this.checkBoxExpirience.TabIndex = 5;
            this.checkBoxExpirience.Text = "Эксклюзив";
            // 
            // checkBoxVIP
            // 
            this.checkBoxVIP.AutoSize = true;
            this.checkBoxVIP.Location = new System.Drawing.Point(160, 56);
            this.checkBoxVIP.Name = "checkBoxVIP";
            this.checkBoxVIP.Size = new System.Drawing.Size(43, 17);
            this.checkBoxVIP.TabIndex = 4;
            this.checkBoxVIP.Text = "VIP";
            // 
            // checkBoxSvadba
            // 
            this.checkBoxSvadba.AutoSize = true;
            this.checkBoxSvadba.Location = new System.Drawing.Point(160, 19);
            this.checkBoxSvadba.Name = "checkBoxSvadba";
            this.checkBoxSvadba.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSvadba.TabIndex = 3;
            this.checkBoxSvadba.Text = "Свадьба";
            // 
            // checkBoxFIT
            // 
            this.checkBoxFIT.AutoSize = true;
            this.checkBoxFIT.Location = new System.Drawing.Point(34, 87);
            this.checkBoxFIT.Name = "checkBoxFIT";
            this.checkBoxFIT.Size = new System.Drawing.Size(42, 17);
            this.checkBoxFIT.TabIndex = 2;
            this.checkBoxFIT.Text = "FIT";
            // 
            // checkBoxSport
            // 
            this.checkBoxSport.AutoSize = true;
            this.checkBoxSport.Location = new System.Drawing.Point(34, 56);
            this.checkBoxSport.Name = "checkBoxSport";
            this.checkBoxSport.Size = new System.Drawing.Size(56, 17);
            this.checkBoxSport.TabIndex = 1;
            this.checkBoxSport.Text = "Спорт";
            // 
            // checkBoxSPA
            // 
            this.checkBoxSPA.AutoSize = true;
            this.checkBoxSPA.Location = new System.Drawing.Point(34, 19);
            this.checkBoxSPA.Name = "checkBoxSPA";
            this.checkBoxSPA.Size = new System.Drawing.Size(47, 17);
            this.checkBoxSPA.TabIndex = 0;
            this.checkBoxSPA.Text = "SPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дополнительные услуги";
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
            this.cmbMeal.Location = new System.Drawing.Point(172, 56);
            this.cmbMeal.Name = "cmbMeal";
            this.cmbMeal.Size = new System.Drawing.Size(180, 21);
            this.cmbMeal.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Тип питания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Категории отеля";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(158, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Условия отеля";
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSkip.Location = new System.Drawing.Point(61, 587);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(107, 27);
            this.btnSkip.TabIndex = 5;
            this.btnSkip.Text = "Пропустить";
            this.btnSkip.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNext.Location = new System.Drawing.Point(246, 586);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 28);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // lblStar1
            // 
            this.lblStar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStar1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStar1.ForeColor = System.Drawing.Color.Gray;
            this.lblStar1.Location = new System.Drawing.Point(30, 275);
            this.lblStar1.Name = "lblStar1";
            this.lblStar1.Size = new System.Drawing.Size(35, 40);
            this.lblStar1.TabIndex = 8;
            this.lblStar1.Text = "☆";
            this.lblStar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStar2
            // 
            this.lblStar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStar2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStar2.ForeColor = System.Drawing.Color.Gray;
            this.lblStar2.Location = new System.Drawing.Point(70, 275);
            this.lblStar2.Name = "lblStar2";
            this.lblStar2.Size = new System.Drawing.Size(35, 40);
            this.lblStar2.TabIndex = 9;
            this.lblStar2.Text = "☆";
            this.lblStar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStar3
            // 
            this.lblStar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStar3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStar3.ForeColor = System.Drawing.Color.Gray;
            this.lblStar3.Location = new System.Drawing.Point(110, 275);
            this.lblStar3.Name = "lblStar3";
            this.lblStar3.Size = new System.Drawing.Size(35, 40);
            this.lblStar3.TabIndex = 10;
            this.lblStar3.Text = "☆";
            this.lblStar3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStar4
            // 
            this.lblStar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStar4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStar4.ForeColor = System.Drawing.Color.Gray;
            this.lblStar4.Location = new System.Drawing.Point(150, 275);
            this.lblStar4.Name = "lblStar4";
            this.lblStar4.Size = new System.Drawing.Size(35, 40);
            this.lblStar4.TabIndex = 11;
            this.lblStar4.Text = "☆";
            this.lblStar4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStar5
            // 
            this.lblStar5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStar5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStar5.ForeColor = System.Drawing.Color.Gray;
            this.lblStar5.Location = new System.Drawing.Point(190, 275);
            this.lblStar5.Name = "lblStar5";
            this.lblStar5.Size = new System.Drawing.Size(35, 40);
            this.lblStar5.TabIndex = 12;
            this.lblStar5.Text = "☆";
            this.lblStar5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStarsTitle
            // 
            this.lblStarsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStarsTitle.Location = new System.Drawing.Point(30, 245);
            this.lblStarsTitle.Name = "lblStarsTitle";
            this.lblStarsTitle.Size = new System.Drawing.Size(120, 25);
            this.lblStarsTitle.TabIndex = 7;
            this.lblStarsTitle.Text = "Категория отеля";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(471, 647);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStarsTitle);
            this.Controls.Add(this.lblStar1);
            this.Controls.Add(this.lblStar2);
            this.Controls.Add(this.lblStar3);
            this.Controls.Add(this.lblStar4);
            this.Controls.Add(this.lblStar5);
            this.Name = "Form3";
            this.Text = "Туристическое агенство";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPrice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}