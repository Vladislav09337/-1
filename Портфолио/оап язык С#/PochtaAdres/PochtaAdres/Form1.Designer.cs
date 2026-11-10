using System;
using System.Drawing;
using System.Windows.Forms;

namespace PochtaAdres
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы управления
        private ListBox listBox1;
        private TextBox txtIndex;
        private TextBox txtCity;
        private TextBox txtStreet;
        private TextBox txtHouse;
        private TextBox txtApartment;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnUpdate;
        private Label lblCount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;

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
            this.listBox1 = new ListBox();
            this.txtIndex = new TextBox();
            this.txtCity = new TextBox();
            this.txtStreet = new TextBox();
            this.txtHouse = new TextBox();
            this.txtApartment = new TextBox();
            this.txtSearch = new TextBox();
            this.btnAdd = new Button();
            this.btnDelete = new Button();
            this.btnSearch = new Button();
            this.btnUpdate = new Button();
            this.lblCount = new Label();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.groupBox1 = new GroupBox();
            this.groupBox2 = new GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();

            // Form1
            this.Text = "Почтовый адрес организации";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 10F);

            // groupBox1 (Данные адреса)
            this.groupBox1.Text = "Данные адреса";
            this.groupBox1.Location = new Point(20, 20);
            this.groupBox1.Size = new Size(400, 280);

            // label1 - Индекс
            this.label1.Text = "Индекс:";
            this.label1.Location = new Point(20, 30);
            this.label1.Size = new Size(80, 25);
            this.txtIndex.Location = new Point(120, 27);
            this.txtIndex.Size = new Size(250, 25);

            // label2 - Город
            this.label2.Text = "Город:";
            this.label2.Location = new Point(20, 65);
            this.label2.Size = new Size(80, 25);
            this.txtCity.Location = new Point(120, 62);
            this.txtCity.Size = new Size(250, 25);

            // label3 - Улица
            this.label3.Text = "Улица:";
            this.label3.Location = new Point(20, 100);
            this.label3.Size = new Size(80, 25);
            this.txtStreet.Location = new Point(120, 97);
            this.txtStreet.Size = new Size(250, 25);

            // label4 - Дом
            this.label4.Text = "Дом:";
            this.label4.Location = new Point(20, 135);
            this.label4.Size = new Size(80, 25);
            this.txtHouse.Location = new Point(120, 132);
            this.txtHouse.Size = new Size(250, 25);

            // label5 - Квартира
            this.label5.Text = "Квартира:";
            this.label5.Location = new Point(20, 170);
            this.label5.Size = new Size(80, 25);
            this.txtApartment.Location = new Point(120, 167);
            this.txtApartment.Size = new Size(250, 25);

            // Кнопки (только нужные)
            this.btnAdd.Text = "ДОБАВИТЬ";
            this.btnAdd.Location = new Point(20, 210);
            this.btnAdd.Size = new Size(110, 35);
            this.btnAdd.BackColor = Color.LightGreen;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            this.btnDelete.Text = "УДАЛИТЬ";
            this.btnDelete.Location = new Point(140, 210);
            this.btnDelete.Size = new Size(110, 35);
            this.btnDelete.BackColor = Color.LightCoral;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            this.btnUpdate.Text = "ОБНОВИТЬ";
            this.btnUpdate.Location = new Point(260, 210);
            this.btnUpdate.Size = new Size(110, 35);
            this.btnUpdate.BackColor = Color.LightBlue;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);

            // groupBox1.Controls
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIndex);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStreet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHouse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApartment);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);

            // groupBox2 (Поиск)
            this.groupBox2.Text = "Поиск";
            this.groupBox2.Location = new Point(20, 320);
            this.groupBox2.Size = new Size(400, 120);

            // label6 - Поиск
            this.label6.Text = "Поиск:";
            this.label6.Location = new Point(20, 30);
            this.label6.Size = new Size(80, 25);
            this.txtSearch.Location = new Point(120, 27);
            this.txtSearch.Size = new Size(250, 25);

            this.btnSearch.Text = "НАЙТИ";
            this.btnSearch.Location = new Point(120, 65);
            this.btnSearch.Size = new Size(170, 35);
            this.btnSearch.BackColor = Color.LightYellow;
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // groupBox2.Controls
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);

            // listBox1 (Список адресов)
            this.listBox1.Location = new Point(440, 20);
            this.listBox1.Size = new Size(430, 430);
            this.listBox1.Font = new Font("Consolas", 10F);
            this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);

            // lblCount (Счетчик)
            this.lblCount.Text = "Всего адресов: 0";
            this.lblCount.Location = new Point(440, 460);
            this.lblCount.Size = new Size(430, 30);
            this.lblCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblCount.TextAlign = ContentAlignment.MiddleCenter;
            this.lblCount.BackColor = Color.LightYellow;
            this.lblCount.BorderStyle = BorderStyle.FixedSingle;

            // Добавление всех элементов на форму
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblCount);

            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
