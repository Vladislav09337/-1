namespace WinFormsApp1
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
            lbRed = new Label();
            lbGreen = new Label();
            lbBlue = new Label();
            panelColor = new Panel();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            SuspendLayout();
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(186, 40);
            trackBarRed.MaximumSize = new Size(250, 0);
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(250, 45);
            trackBarRed.TabIndex = 0;
            trackBarRed.TickFrequency = 15;
            trackBarRed.Scroll += trackBar_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(186, 91);
            trackBarGreen.MaximumSize = new Size(250, 0);
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(250, 45);
            trackBarGreen.TabIndex = 1;
            trackBarGreen.TickFrequency = 15;
            trackBarGreen.Scroll += trackBar_Scroll;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(186, 142);
            trackBarBlue.MaximumSize = new Size(250, 0);
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(250, 45);
            trackBarBlue.TabIndex = 2;
            trackBarBlue.TickFrequency = 15;
            trackBarBlue.Scroll += trackBar_Scroll;
            // 
            // lbRed
            // 
            lbRed.AutoSize = true;
            lbRed.Location = new Point(102, 52);
            lbRed.Name = "lbRed";
            lbRed.Size = new Size(27, 15);
            lbRed.TabIndex = 3;
            lbRed.Text = "Red";
            // 
            // lbGreen
            // 
            lbGreen.AutoSize = true;
            lbGreen.Location = new Point(102, 104);
            lbGreen.Name = "lbGreen";
            lbGreen.Size = new Size(38, 15);
            lbGreen.TabIndex = 4;
            lbGreen.Text = "Green";
            // 
            // lbBlue
            // 
            lbBlue.AutoSize = true;
            lbBlue.Location = new Point(102, 151);
            lbBlue.Name = "lbBlue";
            lbBlue.Size = new Size(30, 15);
            lbBlue.TabIndex = 5;
            lbBlue.Text = "Blue";
            // 
            // panelColor
            // 
            panelColor.BackColor = Color.Black;
            panelColor.Location = new Point(186, 235);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(330, 168);
            panelColor.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelColor);
            Controls.Add(lbBlue);
            Controls.Add(lbGreen);
            Controls.Add(lbRed);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarRed);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private Label lbRed;
        private Label lbGreen;
        private Label lbBlue;
        private Panel panelColor;
    }
}
