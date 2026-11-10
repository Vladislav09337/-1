using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void trackBar_Scroll(object source, EventArgs e)
        {
            int red = trackBarRed.Value;
            int green = trackBarGreen.Value;
            int blue = trackBarBlue.Value;
            Color color = Color.FromArgb(red, green, blue);
            panelColor.BackColor = color;
        }
    }
}
