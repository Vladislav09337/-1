using System;
using System.Windows.Forms;

namespace TextProcessor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form1 Main = this.Owner as Form1;
            if (textBox1.Text != "")
            {
                if (this.radioButton1.Checked == true)
                    Main.listBox1.Items.Add(this.textBox1.Text);
                else
                    Main.listBox2.Items.Add(this.textBox1.Text);
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}