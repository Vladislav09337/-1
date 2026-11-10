namespace WindowsFormsApp3
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
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.lbRED = new System.Windows.Forms.Label();
            this.lbGREEN = new System.Windows.Forms.Label();
            this.lbBLUE = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarAlpha = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarGrey = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrey)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(194, 12);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(412, 45);
            this.trackBarRed.TabIndex = 0;
            this.trackBarRed.TickFrequency = 15;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(194, 63);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(412, 45);
            this.trackBarGreen.TabIndex = 1;
            this.trackBarGreen.TickFrequency = 15;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(194, 114);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(412, 45);
            this.trackBarBlue.TabIndex = 2;
            this.trackBarBlue.TickFrequency = 15;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lbRED
            // 
            this.lbRED.AutoSize = true;
            this.lbRED.Location = new System.Drawing.Point(112, 23);
            this.lbRED.Name = "lbRED";
            this.lbRED.Size = new System.Drawing.Size(30, 13);
            this.lbRED.TabIndex = 3;
            this.lbRED.Text = "RED";
            // 
            // lbGREEN
            // 
            this.lbGREEN.AutoSize = true;
            this.lbGREEN.Location = new System.Drawing.Point(112, 73);
            this.lbGREEN.Name = "lbGREEN";
            this.lbGREEN.Size = new System.Drawing.Size(45, 13);
            this.lbGREEN.TabIndex = 4;
            this.lbGREEN.Text = "GREEN";
            // 
            // lbBLUE
            // 
            this.lbBLUE.AutoSize = true;
            this.lbBLUE.Location = new System.Drawing.Point(112, 123);
            this.lbBLUE.Name = "lbBLUE";
            this.lbBLUE.Size = new System.Drawing.Size(35, 13);
            this.lbBLUE.TabIndex = 5;
            this.lbBLUE.Text = "BLUE";
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.Location = new System.Drawing.Point(115, 267);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(491, 356);
            this.panelColor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ALFA";
            // 
            // trackBarAlpha
            // 
            this.trackBarAlpha.Location = new System.Drawing.Point(194, 165);
            this.trackBarAlpha.Maximum = 255;
            this.trackBarAlpha.Name = "trackBarAlpha";
            this.trackBarAlpha.Size = new System.Drawing.Size(412, 45);
            this.trackBarAlpha.TabIndex = 7;
            this.trackBarAlpha.TickFrequency = 15;
            this.trackBarAlpha.Value = 255;
            this.trackBarAlpha.Scroll += new System.EventHandler(this.trackBar_Scroll1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "GREY";
            // 
            // trackBarGrey
            // 
            this.trackBarGrey.Location = new System.Drawing.Point(194, 216);
            this.trackBarGrey.Maximum = 255;
            this.trackBarGrey.Name = "trackBarGrey";
            this.trackBarGrey.Size = new System.Drawing.Size(412, 45);
            this.trackBarGrey.TabIndex = 9;
            this.trackBarGrey.TickFrequency = 15;
            this.trackBarGrey.Scroll += new System.EventHandler(this.trackBar_Scroll1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 737);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarGrey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarAlpha);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.lbBLUE);
            this.Controls.Add(this.lbGREEN);
            this.Controls.Add(this.lbRED);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label lbRED;
        private System.Windows.Forms.Label lbGREEN;
        private System.Windows.Forms.Label lbBLUE;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarAlpha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarGrey;
    }
}

