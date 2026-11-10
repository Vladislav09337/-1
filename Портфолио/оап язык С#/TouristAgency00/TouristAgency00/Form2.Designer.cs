namespace TouristAgency00
{
    partial class Form2
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstPriority = new System.Windows.Forms.ListBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.lstAvailable = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.groupBox1.Controls.Add(this.lstPriority);
            this.groupBox1.Controls.Add(this.btnMoveRight);
            this.groupBox1.Controls.Add(this.btnMoveLeft);
            this.groupBox1.Controls.Add(this.lstAvailable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 235);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lstPriority
            // 
            this.lstPriority.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstPriority.ItemHeight = 20;
            this.lstPriority.Location = new System.Drawing.Point(267, 45);
            this.lstPriority.Name = "lstPriority";
            this.lstPriority.Size = new System.Drawing.Size(173, 164);
            this.lstPriority.TabIndex = 18;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveRight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMoveRight.ForeColor = System.Drawing.Color.White;
            this.btnMoveRight.Location = new System.Drawing.Point(196, 65);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(60, 40);
            this.btnMoveRight.TabIndex = 16;
            this.btnMoveRight.Text = "→";
            this.btnMoveRight.UseVisualStyleBackColor = false;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveLeft.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMoveLeft.ForeColor = System.Drawing.Color.White;
            this.btnMoveLeft.Location = new System.Drawing.Point(196, 131);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(60, 40);
            this.btnMoveLeft.TabIndex = 17;
            this.btnMoveLeft.Text = "←";
            this.btnMoveLeft.UseVisualStyleBackColor = false;
            // 
            // lstAvailable
            // 
            this.lstAvailable.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstAvailable.ItemHeight = 20;
            this.lstAvailable.Location = new System.Drawing.Point(9, 45);
            this.lstAvailable.Name = "lstAvailable";
            this.lstAvailable.Size = new System.Drawing.Size(173, 164);
            this.lstAvailable.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите и перетащите в правый столбец в порядке приоритета";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(158, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Предпочтенье ";
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSkip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSkip.Location = new System.Drawing.Point(87, 462);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(107, 27);
            this.btnSkip.TabIndex = 5;
            this.btnSkip.Text = "Пропустить";
            this.btnSkip.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNext.Location = new System.Drawing.Point(252, 462);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 28);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(472, 516);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form2";
            this.Text = "Туристическое агенство";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPriority;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.ListBox lstAvailable;
    }
}

