using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = cbCities.SelectedItem.ToString();
            switch (city)
            {
                case "Москва":
                    tbInfo.Text = "Население: -13 млн. Достопримечательность: Кремль.";
                    break;
                case "Санкт-Петербург":
                    tbInfo.Text = "Население: -5,6 млн. Достопримечательность: Эрмитаж.";
                    break;
                case "Казань":
                    tbInfo.Text = "Население: -1,3 млн. Достопримечательность: Казанский кремль.";
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbCities.Items.Add("Москва");
            cbCities.Items.Add("Санкт-Петербург");
            cbCities.Items.Add("Казань");
            cbCities.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         cbCities.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cbCities.Items[cbCities.SelectedIndex] = textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string city = (string)cbCities.SelectedItem;
            cbCities.Items.Remove(city);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(cbCities.SelectedItem.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
