namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            panelColor = new Panel();
            lbRED = new Label();
            lbGREEN = new Label();
            lbBLUE = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            SuspendLayout();
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(206, 60);
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(467, 45);
            trackBarRed.TabIndex = 0;
            trackBarRed.Scroll += trackBar_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(206, 111);
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(467, 45);
            trackBarGreen.TabIndex = 1;
            trackBarGreen.Scroll += trackBar_Scroll;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(206, 162);
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(467, 45);
            trackBarBlue.TabIndex = 2;
            trackBarBlue.Scroll += trackBar_Scroll;
            // 
            // panelColor
            // 
            panelColor.BackColor = SystemColors.Desktop;
            panelColor.ForeColor = Color.DarkSlateGray;
            panelColor.Location = new Point(111, 235);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(562, 174);
            panelColor.TabIndex = 3;
            // 
            // lbRED
            // 
            lbRED.AutoSize = true;
            lbRED.Location = new Point(111, 71);
            lbRED.Name = "lbRED";
            lbRED.Size = new Size(28, 15);
            lbRED.TabIndex = 4;
            lbRED.Text = "RED";
            // 
            // lbGREEN
            // 
            lbGREEN.AutoSize = true;
            lbGREEN.Location = new Point(111, 122);
            lbGREEN.Name = "lbGREEN";
            lbGREEN.Size = new Size(43, 15);
            lbGREEN.TabIndex = 5;
            lbGREEN.Text = "GREEN";
            // 
            // lbBLUE
            // 
            lbBLUE.AutoSize = true;
            lbBLUE.Location = new Point(111, 172);
            lbBLUE.Name = "lbBLUE";
            lbBLUE.Size = new Size(34, 15);
            lbBLUE.TabIndex = 6;
            lbBLUE.Text = "BLUE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbBLUE);
            Controls.Add(lbGREEN);
            Controls.Add(lbRED);
            Controls.Add(panelColor);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarRed);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private Panel panelColor;
        private Label lbRED;
        private Label lbGREEN;
        private Label lbBLUE;
    }
}
