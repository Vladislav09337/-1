using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        // Структура студента
        string[] names = new string[10];
        int[] groups = new int[10];
        int[,] marks = new int[10, 5]; // [10, 5] - 10 студентов, у каждого 5 оценок
        double[] avg = new double[10];                   
        int count = 0;

        public Form1()
        {
            InitializeComponent();

            // Группы
            for (int i = 1; i <= 10; i++)
            {
                cmbGroup.Items.Add(i);
                cmbGroup.SelectedIndex = 0;
            }
            SetupGrid(dgvAll);// dgvAll - таблица для всех студентов
            SetupGrid(dgvFound);// dgvFound - таблица для найденных студентов

            // Кнопки
            btnAdd.Click += AddStudent;
            btnFind.Click += FindStudents;
            btnClear.Click += ClearAll;
            btnExit.Click += (s, e) => Close();
        }

        // Настройка таблицы
        void SetupGrid(DataGridView g)
        {
            g.Columns.Clear();
            g.Columns.Add("n", "ФИО");
            g.Columns.Add("g", "Группа");
            for (int i = 1; i <= 5; i++)
            {
                g.Columns.Add("o" + i, i + "");
            }
            g.Columns.Add("s", "Ср.балл");

            g.Columns["n"].Width = 200;
            g.Columns["g"].Width = 60;
        }

        // Проверка оценки
        bool GoodGrade(string s)
        {
            if (s == "")
            {
                return false;
            }
            int x = int.Parse(s);
            return x >= 2 && x <= 5;
        }

        // Обновление таблицы
        void UpdateAll()
        {
            dgvAll.Rows.Clear();
            for (int i = 0; i < count; i++)
            {
                dgvAll.Rows.Add(
                    names[i], groups[i],
                    marks[i, 0], marks[i, 1], marks[i, 2], marks[i, 3], marks[i, 4],
                    avg[i].ToString("F2")
                );
            }
            lblCounter.Text = count + "/10";
        }

        // Добавить студента
        void AddStudent(object s, EventArgs e)
        {
            if (count >= 10)
            {
                MessageBox.Show("10 студентов!");
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Введите ФИО!");
                return;
            }

            try
            {
                if (!GoodGrade(txtGrade1.Text) || !GoodGrade(txtGrade2.Text) ||
                    !GoodGrade(txtGrade3.Text) || !GoodGrade(txtGrade4.Text) ||
                    !GoodGrade(txtGrade5.Text))
                {
                    MessageBox.Show("Оценки 2-5!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в оценках!");
                return;
            }

            // Сохраняем
            names[count] = txtName.Text;
            groups[count] = int.Parse(cmbGroup.Text);

            marks[count, 0] = int.Parse(txtGrade1.Text);
            marks[count, 1] = int.Parse(txtGrade2.Text);
            marks[count, 2] = int.Parse(txtGrade3.Text);
            marks[count, 3] = int.Parse(txtGrade4.Text);
            marks[count, 4] = int.Parse(txtGrade5.Text);

            double sum = marks[count, 0] + marks[count, 1] + marks[count, 2] +
                        marks[count, 3] + marks[count, 4];
            avg[count] = sum / 5;

            count++;
            UpdateAll();

            // Очистка
            txtName.Text = "";
            txtGrade1.Text = txtGrade2.Text = txtGrade3.Text =
            txtGrade4.Text = txtGrade5.Text = "";
            cmbGroup.SelectedIndex = 0;
        }

        // Найти студентов
        void FindStudents(object s, EventArgs e)
        {
            dgvFound.Rows.Clear();
            if (count == 0)
            {
                MessageBox.Show("Нет студентов!");
                return;
            }

            double min = 4.0;
            try
            {
                min = double.Parse(txtMinBall.Text);
            }
            catch
            {
                MessageBox.Show("Введите число!");
                return;
            }

            int found = 0;
            for (int i = 0; i < count; i++)
            {
                if (avg[i] > min)
                {
                    dgvFound.Rows.Add(
                        names[i], groups[i],
                        marks[i, 0], marks[i, 1], marks[i, 2], marks[i, 3], marks[i, 4],
                        avg[i].ToString("F2")
                    );
                    found++;
                }
            }

            if (found == 0)
            {
                MessageBox.Show("Никого нет");
            }
            else
            {
                MessageBox.Show("Найдено: " + found);
            }
        }

        // Очистить всё
        void ClearAll(object s, EventArgs e)
        {
            count = 0;
            dgvAll.Rows.Clear();
            dgvFound.Rows.Clear();
            lblCounter.Text = "0/10";
        }
    }
}
