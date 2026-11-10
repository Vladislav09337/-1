using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab15_Variant1_WF
{
    public partial class Form1 : Form
    {
        // Структура STUDENT
        public struct STUDENT : IComparable<STUDENT>
        {
            public string FullName { get; set; }        // Фамилия и инициалы
            public int GroupNumber { get; set; }        // Номер группы
            public int[] Grades { get; set; }           // Успеваемость (массив из 5 элементов)

            // Свойство для вычисления среднего балла
            public double AverageGrade
            {
                get
                {
                    if (Grades == null || Grades.Length == 0)
                        return 0;
                    double sum = 0;
                    for (int i = 0; i < Grades.Length; i++)
                    {
                        sum += Grades[i];
                    }
                    return sum / Grades.Length;
                }
            }

            // Реализация интерфейса IComparable<T> для сортировки по номеру группы
            public int CompareTo(STUDENT other)
            {
                return this.GroupNumber.CompareTo(other.GroupNumber);
            }
        }

        // Поля класса
        private STUDENT[] students = new STUDENT[10];
        private int currentStudentIndex = 0;
        private const string dataFile = "students.txt";
        private const string resultFile = "results.txt";

        public Form1()
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Настройка формы
            this.Text = "Лабораторная работа №15 - Студенты";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Создание элементов управления
            CreateControls();
        }

        private void CreateControls()
        {
            // Вкладки
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            // Вкладка ввода данных
            TabPage inputPage = new TabPage("Ввод данных");
            CreateInputPage(inputPage);
            tabControl.TabPages.Add(inputPage);

            // Вкладка просмотра данных
            TabPage viewPage = new TabPage("Просмотр данных");
            CreateViewPage(viewPage);
            tabControl.TabPages.Add(viewPage);

            // Вкладка обработки данных
            TabPage processPage = new TabPage("Обработка данных");
            CreateProcessPage(processPage);
            tabControl.TabPages.Add(processPage);

            this.Controls.Add(tabControl);
        }

        private void CreateInputPage(TabPage page)
        {
            // Группа ввода данных
            GroupBox inputGroup = new GroupBox();
            inputGroup.Text = "Ввод данных студента";
            inputGroup.Location = new Point(20, 20);
            inputGroup.Size = new Size(400, 300);

            // Метки и поля ввода
            Label lblFullName = new Label();
            lblFullName.Text = "Фамилия и инициалы:";
            lblFullName.Location = new Point(20, 30);
            lblFullName.Size = new Size(120, 20);

            TextBox txtFullName = new TextBox();
            txtFullName.Name = "txtFullName";
            txtFullName.Location = new Point(150, 27);
            txtFullName.Size = new Size(200, 20);

            Label lblGroup = new Label();
            lblGroup.Text = "Номер группы:";
            lblGroup.Location = new Point(20, 60);
            lblGroup.Size = new Size(120, 20);

            TextBox txtGroup = new TextBox();
            txtGroup.Name = "txtGroup";
            txtGroup.Location = new Point(150, 57);
            txtGroup.Size = new Size(100, 20);

            Label lblGrades = new Label();
            lblGrades.Text = "Оценки (5 штук):";
            lblGrades.Location = new Point(20, 90);
            lblGrades.Size = new Size(120, 20);

            TextBox txtGrade1 = new TextBox();
            txtGrade1.Name = "txtGrade1";
            txtGrade1.Location = new Point(150, 87);
            txtGrade1.Size = new Size(40, 20);

            TextBox txtGrade2 = new TextBox();
            txtGrade2.Name = "txtGrade2";
            txtGrade2.Location = new Point(200, 87);
            txtGrade2.Size = new Size(40, 20);

            TextBox txtGrade3 = new TextBox();
            txtGrade3.Name = "txtGrade3";
            txtGrade3.Location = new Point(250, 87);
            txtGrade3.Size = new Size(40, 20);

            TextBox txtGrade4 = new TextBox();
            txtGrade4.Name = "txtGrade4";
            txtGrade4.Location = new Point(300, 87);
            txtGrade4.Size = new Size(40, 20);

            TextBox txtGrade5 = new TextBox();
            txtGrade5.Name = "txtGrade5";
            txtGrade5.Location = new Point(350, 87);
            txtGrade5.Size = new Size(40, 20);

            // Кнопки
            Button btnAddStudent = new Button();
            btnAddStudent.Text = "Добавить студента";
            btnAddStudent.Location = new Point(50, 150);
            btnAddStudent.Size = new Size(150, 30);
            btnAddStudent.Click += (s, e) =>
            {
                AddStudent(txtFullName, txtGroup, txtGrade1, txtGrade2, txtGrade3, txtGrade4, txtGrade5);
            };

            Button btnSaveToFile = new Button();
            btnSaveToFile.Text = "Сохранить в файл";
            btnSaveToFile.Location = new Point(220, 150);
            btnSaveToFile.Size = new Size(150, 30);
            btnSaveToFile.Click += (s, e) =>
            {
                SaveToFile();
            };

            // Счетчик студентов
            Label lblCounter = new Label();
            lblCounter.Name = "lblCounter";
            lblCounter.Text = $"Добавлено студентов: {currentStudentIndex}/10";
            lblCounter.Location = new Point(50, 200);
            lblCounter.Size = new Size(200, 20);

            // DataGridView для отображения введенных данных
            DataGridView dgvInput = new DataGridView();
            dgvInput.Name = "dgvInput";
            dgvInput.Location = new Point(450, 20);
            dgvInput.Size = new Size(400, 300);
            dgvInput.ReadOnly = true;
            dgvInput.AllowUserToAddRows = false;
            dgvInput.ColumnCount = 7;
            dgvInput.Columns[0].Name = "№";
            dgvInput.Columns[1].Name = "ФИО";
            dgvInput.Columns[2].Name = "Группа";
            dgvInput.Columns[3].Name = "Оценка1";
            dgvInput.Columns[4].Name = "Оценка2";
            dgvInput.Columns[5].Name = "Оценка3";
            dgvInput.Columns[6].Name = "Оценка4";
            dgvInput.Columns[7].Name = "Оценка5";

            // Добавляем элементы на страницу
            inputGroup.Controls.AddRange(new Control[] {
                lblFullName, txtFullName, lblGroup, txtGroup, lblGrades,
                txtGrade1, txtGrade2, txtGrade3, txtGrade4, txtGrade5,
                btnAddStudent, btnSaveToFile, lblCounter
            });

            page.Controls.Add(inputGroup);
            page.Controls.Add(dgvInput);

            // Сохраняем ссылки на элементы управления
            this.Controls.Add(txtFullName);
            this.Controls.Add(txtGroup);
            this.Controls.Add(txtGrade1);
            this.Controls.Add(txtGrade2);
            this.Controls.Add(txtGrade3);
            this.Controls.Add(txtGrade4);
            this.Controls.Add(txtGrade5);
            this.Controls.Add(lblCounter);
            this.Controls.Add(dgvInput);
        }

        private void CreateViewPage(TabPage page)
        {
            Button btnLoadFromFile = new Button();
            btnLoadFromFile.Text = "Загрузить из файла";
            btnLoadFromFile.Location = new Point(20, 20);
            btnLoadFromFile.Size = new Size(150, 30);
            btnLoadFromFile.Click += (s, e) =>
            {
                LoadFromFile();
            };

            DataGridView dgvView = new DataGridView();
            dgvView.Name = "dgvView";
            dgvView.Location = new Point(20, 70);
            dgvView.Size = new Size(800, 400);
            dgvView.ReadOnly = true;
            dgvView.AllowUserToAddRows = false;
            dgvView.ColumnCount = 8;
            dgvView.Columns[0].Name = "№";
            dgvView.Columns[1].Name = "ФИО";
            dgvView.Columns[2].Name = "Группа";
            dgvView.Columns[3].Name = "Оценка1";
            dgvView.Columns[4].Name = "Оценка2";
            dgvView.Columns[5].Name = "Оценка3";
            dgvView.Columns[6].Name = "Оценка4";
            dgvView.Columns[7].Name = "Оценка5";
            dgvView.Columns[8].Name = "Ср. балл";

            page.Controls.Add(btnLoadFromFile);
            page.Controls.Add(dgvView);

            this.Controls.Add(dgvView);
        }

        private void CreateProcessPage(TabPage page)
        {
            Label lblMinAvg = new Label();
            lblMinAvg.Text = "Минимальный средний балл:";
            lblMinAvg.Location = new Point(20, 30);
            lblMinAvg.Size = new Size(150, 20);

            TextBox txtMinAvg = new TextBox();
            txtMinAvg.Name = "txtMinAvg";
            txtMinAvg.Location = new Point(180, 27);
            txtMinAvg.Size = new Size(100, 20);

            Button btnProcess = new Button();
            btnProcess.Text = "Обработать данные";
            btnProcess.Location = new Point(300, 25);
            btnProcess.Size = new Size(150, 30);
            btnProcess.Click += (s, e) =>
            {
                ProcessData(txtMinAvg);
            };

            DataGridView dgvResult = new DataGridView();
            dgvResult.Name = "dgvResult";
            dgvResult.Location = new Point(20, 80);
            dgvResult.Size = new Size(800, 300);
            dgvResult.ReadOnly = true;
            dgvResult.AllowUserToAddRows = false;
            dgvResult.ColumnCount = 8;
            dgvResult.Columns[0].Name = "№";
            dgvResult.Columns[1].Name = "ФИО";
            dgvResult.Columns[2].Name = "Группа";
            dgvResult.Columns[3].Name = "Оценка1";
            dgvResult.Columns[4].Name = "Оценка2";
            dgvResult.Columns[5].Name = "Оценка3";
            dgvResult.Columns[6].Name = "Оценка4";
            dgvResult.Columns[7].Name = "Оценка5";
            dgvResult.Columns[8].Name = "Ср. балл";

            Button btnSaveResult = new Button();
            btnSaveResult.Text = "Сохранить результаты";
            btnSaveResult.Location = new Point(20, 400);
            btnSaveResult.Size = new Size(150, 30);
            btnSaveResult.Click += (s, e) =>
            {
                SaveResultsToFile();
            };

            page.Controls.Add(lblMinAvg);
            page.Controls.Add(txtMinAvg);
            page.Controls.Add(btnProcess);
            page.Controls.Add(dgvResult);
            page.Controls.Add(btnSaveResult);

            this.Controls.Add(txtMinAvg);
            this.Controls.Add(dgvResult);
        }

        // Методы обработки данных
        private void AddStudent(TextBox txtFullName, TextBox txtGroup,
            TextBox g1, TextBox g2, TextBox g3, TextBox g4, TextBox g5)
        {
            if (currentStudentIndex >= 10)
            {
                MessageBox.Show("Достигнуто максимальное количество студентов (10)", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                students[currentStudentIndex].FullName = txtFullName.Text;
                students[currentStudentIndex].GroupNumber = Convert.ToInt32(txtGroup.Text);
                students[currentStudentIndex].Grades = new int[5];
                students[currentStudentIndex].Grades[0] = Convert.ToInt32(g1.Text);
                students[currentStudentIndex].Grades[1] = Convert.ToInt32(g2.Text);
                students[currentStudentIndex].Grades[2] = Convert.ToInt32(g3.Text);
                students[currentStudentIndex].Grades[3] = Convert.ToInt32(g4.Text);
                students[currentStudentIndex].Grades[4] = Convert.ToInt32(g5.Text);

                // Обновление DataGridView
                DataGridView dgv = (DataGridView)this.Controls["dgvInput"];
                dgv.Rows.Add(
                    currentStudentIndex + 1,
                    students[currentStudentIndex].FullName,
                    students[currentStudentIndex].GroupNumber,
                    students[currentStudentIndex].Grades[0],
                    students[currentStudentIndex].Grades[1],
                    students[currentStudentIndex].Grades[2],
                    students[currentStudentIndex].Grades[3],
                    students[currentStudentIndex].Grades[4]
                );

                currentStudentIndex++;

                // Обновление счетчика
                Label lblCounter = (Label)this.Controls["lblCounter"];
                lblCounter.Text = $"Добавлено студентов: {currentStudentIndex}/10";

                // Очистка полей ввода
                txtFullName.Clear();
                txtGroup.Clear();
                g1.Clear();
                g2.Clear();
                g3.Clear();
                g4.Clear();
                g5.Clear();

                MessageBox.Show("Студент успешно добавлен", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при вводе данных: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveToFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(dataFile))
                {
                    for (int i = 0; i < currentStudentIndex; i++)
                    {
                        string line = students[i].FullName + ";" + students[i].GroupNumber + ";";
                        for (int j = 0; j < 5; j++)
                        {
                            line += students[i].Grades[j];
                            if (j < 4) line += ";";
                        }
                        sw.WriteLine(line);
                    }
                }
                MessageBox.Show($"Данные сохранены в файл {dataFile}", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFromFile()
        {
            try
            {
                if (!File.Exists(dataFile))
                {
                    MessageBox.Show($"Файл {dataFile} не найден", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string[] lines = File.ReadAllLines(dataFile);
                students = new STUDENT[10];
                currentStudentIndex = lines.Length;

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(';');
                    students[i].FullName = fields[0];
                    students[i].GroupNumber = Convert.ToInt32(fields[1]);
                    students[i].Grades = new int[5];
                    for (int j = 0; j < 5; j++)
                    {
                        students[i].Grades[j] = Convert.ToInt32(fields[2 + j]);
                    }
                }

                // Обновление DataGridView на странице просмотра
                DataGridView dgvView = (DataGridView)this.Controls["dgvView"];
                dgvView.Rows.Clear();

                for (int i = 0; i < currentStudentIndex; i++)
                {
                    double avg = students[i].AverageGrade;
                    dgvView.Rows.Add(
                        i + 1,
                        students[i].FullName,
                        students[i].GroupNumber,
                        students[i].Grades[0],
                        students[i].Grades[1],
                        students[i].Grades[2],
                        students[i].Grades[3],
                        students[i].Grades[4],
                        avg.ToString("F2")
                    );
                }

                MessageBox.Show($"Данные загружены из файла {dataFile}", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessData(TextBox txtMinAvg)
        {
            try
            {
                if (currentStudentIndex == 0)
                {
                    MessageBox.Show("Нет данных для обработки", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double minAvg = Convert.ToDouble(txtMinAvg.Text);

                // Поиск студентов с средним баллом больше заданного
                List<STUDENT> resultList = new List<STUDENT>();
                for (int i = 0; i < currentStudentIndex; i++)
                {
                    if (students[i].AverageGrade > minAvg)
                    {
                        resultList.Add(students[i]);
                    }
                }

                STUDENT[] result = resultList.ToArray();

                // Сортировка по номеру группы
                Array.Sort(result);

                // Обновление DataGridView результатов
                DataGridView dgvResult = (DataGridView)this.Controls["dgvResult"];
                dgvResult.Rows.Clear();

                if (result.Length == 0)
                {
                    MessageBox.Show("Студенты с заданным средним баллом не найдены", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        dgvResult.Rows.Add(
                            i + 1,
                            result[i].FullName,
                            result[i].GroupNumber,
                            result[i].Grades[0],
                            result[i].Grades[1],
                            result[i].Grades[2],
                            result[i].Grades[3],
                            result[i].Grades[4],
                            result[i].AverageGrade.ToString("F2")
                        );
                    }
                }

                // Сохраняем результаты в поле класса для последующего сохранения в файл
                this.Tag = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveResultsToFile()
        {
            try
            {
                STUDENT[] result = (STUDENT[])this.Tag;
                if (result == null || result.Length == 0)
                {
                    MessageBox.Show("Нет результатов для сохранения", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (StreamWriter sw = new StreamWriter(resultFile))
                {
                    sw.WriteLine("==================================================================================================");
                    sw.WriteLine($"|{"Фамилия и инициалы",-20}|{"Группа",-10}|{"Оценки",-25}|{"Ср.балл",-10}|");
                    sw.WriteLine("==================================================================================================");

                    for (int i = 0; i < result.Length; i++)
                    {
                        string gradesStr = "";
                        for (int j = 0; j < 5; j++)
                        {
                            gradesStr += result[i].Grades[j] + " ";
                        }
                        sw.WriteLine($"|{result[i].FullName,-20}|{result[i].GroupNumber,-10}|{gradesStr,-25}|{result[i].AverageGrade,-10:F2}|");
                    }

                    sw.WriteLine("==================================================================================================");
                }

                MessageBox.Show($"Результаты сохранены в файл {resultFile}", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении результатов: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

