namespace Практическая_работа_20
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblVid = new System.Windows.Forms.Label();
            this.lblForm = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox.Location = new System.Drawing.Point(38, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(892, 457);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // lblVid
            // 
            this.lblVid.AutoSize = true;
            this.lblVid.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblVid.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblVid.Location = new System.Drawing.Point(65, 484);
            this.lblVid.Name = "lblVid";
            this.lblVid.Size = new System.Drawing.Size(56, 29);
            this.lblVid.TabIndex = 1;
            this.lblVid.Text = "Вид";
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblForm.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblForm.Location = new System.Drawing.Point(332, 484);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(90, 29);
            this.lblForm.TabIndex = 2;
            this.lblForm.Text = "Форма";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblInfo.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInfo.Location = new System.Drawing.Point(620, 484);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(162, 29);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Информация";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 633);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblForm);
            this.Controls.Add(this.lblVid);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblVid;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Label lblInfo;
    }
}

