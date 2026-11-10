using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PochtaAdres
{
    public partial class Form1 : Form
    {
        //класс адресов
        public class PostalAddress
        {
            private int index;
            private string city;
            private string street;
            private string house;
            private int apartment;

            //открытый доступ к закрытым полям
            public int Index
            {
                get { return index; }//получаем значение
                set { index = value; }//устанавливаем значение
            }

            public string City
            {
                get { return city; }
                set { city = value; }
            }

            public string Street
            {
                get { return street; }
                set { street = value; }
            }

            public string House
            {
                get { return house; }
                set { house = value; }
            }

            public int Apartment
            {
                get { return apartment; }
                set { apartment = value; }
            }

            public PostalAddress() { }

            public PostalAddress(int index, string city, string street, string house, int apartment)
            {
                this.index = index;
                this.city = city;
                this.street = street;
                this.house = house;
                this.apartment = apartment;
            }

            //метод для изменения адреса
            public void UpdateAddress(int newIndex, string newCity, string newStreet, string newHouse, int newApartment)
            {
                index = newIndex;
                city = newCity;
                street = newStreet;
                house = newHouse;
                apartment = newApartment;
            }

            public string GetFullAddress()
            {
                return $"Индекс: {index}, г. {city}, ул. {street}, д. {house}, кв. {apartment}";
            }
        }

        //список адресов
        private List<PostalAddress> addresses = new List<PostalAddress>();

        public Form1()
        {
            InitializeComponent();
            CreateTestData();
            UpdatehList();
            this.Text = "Почтовый адрес организации";
        }

        //вводим свои данные
        private void CreateTestData()
        {
            addresses.Clear();
            addresses.Add(new PostalAddress(101000, "Москва", "Тверская", "12", 34));
            addresses.Add(new PostalAddress(190000, "Санкт-Петербург", "Невский", "45", 12));
            addresses.Add(new PostalAddress(630000, "Новосибирск", "Ленина", "23", 56));
            addresses.Add(new PostalAddress(614000, "Пермь", "Комсомольский", "78", 89));
            addresses.Add(new PostalAddress(620000, "Екатеринбург", "Малышева", "15", 45));
            addresses.Add(new PostalAddress(350000, "Краснодар", "Красная", "67", 23));
            addresses.Add(new PostalAddress(603000, "Нижний Новгород", "Большая", "34", 78));
        }

        //обновление списка
        private void UpdatehList()
        {
            listBox1.Items.Clear();
            foreach (var a in addresses)
            {
                listBox1.Items.Add(a.GetFullAddress());
            }
            lblCount.Text = $"Всего адресов: {addresses.Count}";// Обновляем счетчик
        }

        //очищяем поле
        private void ClearFields()
        {
            txtIndex.Clear();
            txtCity.Clear();
            txtStreet.Clear();
            txtHouse.Clear();
            txtApartment.Clear();
        }

        //проверяем поля
        private bool CheckFields()
        {
            if (string.IsNullOrWhiteSpace(txtIndex.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text) ||
                string.IsNullOrWhiteSpace(txtStreet.Text) ||
                string.IsNullOrWhiteSpace(txtHouse.Text) ||
                string.IsNullOrWhiteSpace(txtApartment.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return false;
            }

            return true;
        }

        //добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {

            addresses.Add(new PostalAddress(
                int.Parse(txtIndex.Text),
                txtCity.Text,
                txtStreet.Text,
                txtHouse.Text,
                int.Parse(txtApartment.Text)
            ));

            UpdatehList();
            ClearFields();
        }

        //удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите адрес для удаления!");
                return;
            }

            if (MessageBox.Show("Удалить выбранный адрес?", "Подтверждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                addresses.RemoveAt(listBox1.SelectedIndex);
                UpdatehList();
                ClearFields();
            }
        }

        //найти
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Введите текст для поиска!");
                return;
            }

            string search = txtSearch.Text.ToLower();
            List<PostalAddress> results = new List<PostalAddress>();

            //ищем по всем полям
            foreach (var a in addresses)
            {
                if (a.Index.ToString().Contains(search) ||
                    a.City.ToLower().Contains(search) ||
                    a.Street.ToLower().Contains(search) ||
                    a.House.ToLower().Contains(search) ||
                    a.Apartment.ToString().Contains(search))
                {
                    results.Add(a);
                }
            }

            //показываем результаты
            listBox1.Items.Clear();
            if (results.Count > 0)
            {
                foreach (var a in results)
                {
                    listBox1.Items.Add(a.GetFullAddress());
                }
                MessageBox.Show($"Найдено адресов: {results.Count}");
            }
            else
            {
                listBox1.Items.Add("Ничего не найдено");
            }
        }

        //обновить
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите адрес для обновления!");
                return;
            }

            if (!CheckFields())
            {
                return;
            }
            int index = listBox1.SelectedIndex;
            addresses[index] = new PostalAddress(
                int.Parse(txtIndex.Text),
                txtCity.Text,
                txtStreet.Text,
                txtHouse.Text,
                int.Parse(txtApartment.Text)
            );

            UpdatehList();
            listBox1.SelectedIndex = index;
        }

        //выбираем из списка
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 &&
                listBox1.SelectedItem.ToString() != "Ничего не найдено" &&
                listBox1.SelectedIndex < addresses.Count)
            {
                var a = addresses[listBox1.SelectedIndex]; //берем выбранный адрес
                txtIndex.Text = a.Index.ToString();
                txtCity.Text = a.City;
                txtStreet.Text = a.Street;
                txtHouse.Text = a.House;
                txtApartment.Text = a.Apartment.ToString();
            }
        }
    }
}
