

using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp6
{
    // Создаем структуру STUDENT
    public struct STUDENT : IComparable<STUDENT>
    {
        public string Name;
        public int numberGrup;
        public int[] Grades;
        public double averageGrade;

        public int CompareTo(STUDENT obj)
        {
            if (this.numberGrup > obj.numberGrup)
                return 1;
            if (this.numberGrup < obj.numberGrup)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            string grades = "";
            for (int i = 0; i < Grades.Length; i++)
            {
                grades += Grades[i] + " ";
            }
            return $"{Name,-20} | Группа: {numberGrup,-8} | Оценки: {grades,-15} | Средний балл: {averageGrade:F2}";
        }

        public string ToFileString()
        {
            string grades = "";
            for (int i = 0; i < Grades.Length; i++)
            {
                grades += Grades[i] + " ";
            }
            return $"{Name};{numberGrup};{grades.Trim()}";
        }

        public void CalculateAverage()
        {
            if (Grades == null || Grades.Length == 0)
            {
                averageGrade = 0;
                return;
            }

            double sum = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                sum += Grades[i];
            }
            averageGrade = sum / Grades.Length;
        }
    }

    public partial class Form1 : Form
    {
        // Константы
        private const int STUDENT_COUNT = 10;
        private string dataFile = "students_data.txt";
        private string resultFile = "students_result.txt";

        // Массив студентов
        private STUDENT[] students = new STUDENT[STUDENT_COUNT];
        private int currentStudentIndex = 0;

        // Элементы управления
        private Label titleLabel;
        private Label studentNumberLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label groupLabel;
        private TextBox groupTextBox;
        private Label gradesLabel;
        private TextBox gradesTextBox;
        private Button prevButton;
        private Button nextButton;
        private Button saveButton;
        private Button loadButton;
        private Button searchButton;
        private TextBox minAverageTextBox;
        private ListBox resultsListBox;
        private Label statusLabel;
        private Button clearButton;

        public Form1()
        {
            InitializeComponent();
            InitializeStudents();
        }

        private void InitializeComponent()
        {
            this.Text = "Студенты";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Заголовок
            titleLabel = new Label()
            {
                Text = "Ввод данных о студентах",
                Location = new Point(20, 20),
                Size = new Size(300, 30),
                Font = new Font("Arial", 14, FontStyle.Bold)
            };

            // Номер студента
            studentNumberLabel = new Label()
            {
                Text = "Студент 1 из 10",
                Location = new Point(20, 60),
                Size = new Size(200, 20),
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            // Поле для имени
            nameLabel = new Label()
            {
                Text = "Фамилия и инициалы:",
                Location = new Point(20, 90),
                Size = new Size(150, 20)
            };

            nameTextBox = new TextBox()
            {
                Location = new Point(180, 87),
                Size = new Size(300, 20)
            };

            // Поле для группы
            groupLabel = new Label()
            {
                Text = "Номер группы:",
                Location = new Point(20, 120),
                Size = new Size(150, 20)
            };

            groupTextBox = new TextBox()
            {
                Location = new Point(180, 117),
                Size = new Size(100, 20)
            };

            // Поле для оценок
            gradesLabel = new Label()
            {
                Text = "Оценки (5 через пробел):",
                Location = new Point(20, 150),
                Size = new Size(150, 20)
            };

            gradesTextBox = new TextBox()
            {
                Location = new Point(180, 147),
                Size = new Size(300, 20)
            };

            // Кнопки навигации
            prevButton = new Button()
            {
                Text = "Предыдущий",
                Location = new Point(20, 190),
                Size = new Size(100, 30)
            };
            prevButton.Click += PrevButton_Click;

            nextButton = new Button()
            {
                Text = "Следующий",
                Location = new Point(130, 190),
                Size = new Size(100, 30)
            };
            nextButton.Click += NextButton_Click;

            // Кнопка сохранения
            saveButton = new Button()
            {
                Text = "Сохранить в файл",
                Location = new Point(250, 190),
                Size = new Size(120, 30)
            };
            saveButton.Click += SaveButton_Click;

            // Кнопка загрузки
            loadButton = new Button()
            {
                Text = "Загрузить из файла",
                Location = new Point(380, 190),
                Size = new Size(120, 30)
            };
            loadButton.Click += LoadButton_Click;

            // Поле для поиска
            Label searchLabel = new Label()
            {
                Text = "Минимальный средний балл:",
                Location = new Point(20, 240),
                Size = new Size(150, 20)
            };

            minAverageTextBox = new TextBox()
            {
                Location = new Point(180, 237),
                Size = new Size(80, 20),
                Text = "4.0"
            };

            searchButton = new Button()
            {
                Text = "Поиск",
                Location = new Point(270, 235),
                Size = new Size(80, 25)
            };
            searchButton.Click += SearchButton_Click;

            // Кнопка очистки
            clearButton = new Button()
            {
                Text = "Очистить результаты",
                Location = new Point(360, 235),
                Size = new Size(120, 25)
            };
            clearButton.Click += ClearButton_Click;

            // Список для результатов
            resultsListBox = new ListBox()
            {
                Location = new Point(20, 280),
                Size = new Size(740, 250),
                Font = new Font("Courier New", 9)
            };
            resultsListBox.HorizontalScrollbar = true;

            // Строка статуса
            statusLabel = new Label()
            {
                Text = "Готов к работе",
                Location = new Point(20, 540),
                Size = new Size(740, 20),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Добавляем элементы на форму
            this.Controls.AddRange(new Control[] {
                titleLabel, studentNumberLabel, nameLabel, nameTextBox,
                groupLabel, groupTextBox, gradesLabel, gradesTextBox,
                prevButton, nextButton, saveButton, loadButton,
                searchLabel, minAverageTextBox, searchButton, clearButton,
                resultsListBox, statusLabel
            });
        }

        private void InitializeStudents()
        {
            for (int i = 0; i < STUDENT_COUNT; i++)
            {
                students[i] = new STUDENT();
            }
            currentStudentIndex = 0;
            DisplayCurrentStudent();
        }

        private void DisplayCurrentStudent()
        {
            studentNumberLabel.Text = $"Студент {currentStudentIndex + 1} из {STUDENT_COUNT}";
            nameTextBox.Text = students[currentStudentIndex].Name ?? "";

            if (students[currentStudentIndex].numberGrup != 0)
                groupTextBox.Text = students[currentStudentIndex].numberGrup.ToString();
            else
                groupTextBox.Text = "";

            if (students[currentStudentIndex].Grades != null)
            {
                gradesTextBox.Text = string.Join(" ", students[currentStudentIndex].Grades);
            }
            else
            {
                gradesTextBox.Text = "";
            }
        }

        private void SaveCurrentStudent()
        {
            try
            {
                students[currentStudentIndex].Name = nameTextBox.Text;

                if (!string.IsNullOrWhiteSpace(groupTextBox.Text))
                    students[currentStudentIndex].numberGrup = Convert.ToInt32(groupTextBox.Text);

                if (!string.IsNullOrWhiteSpace(gradesTextBox.Text))
                {
                    string[] gradesInput = gradesTextBox.Text.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    students[currentStudentIndex].Grades = new int[5];

                    for (int j = 0; j < 5; j++)
                    {
                        if (j < gradesInput.Length)
                            students[currentStudentIndex].Grades[j] = Convert.ToInt32(gradesInput[j]);
                        else
                            students[currentStudentIndex].Grades[j] = 0;
                    }
                }

                students[currentStudentIndex].CalculateAverage();
                statusLabel.Text = $"Студент {currentStudentIndex + 1} сохранен";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка");
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            SaveCurrentStudent();
            if (currentStudentIndex > 0)
            {
                currentStudentIndex--;
                DisplayCurrentStudent();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            SaveCurrentStudent();
            if (currentStudentIndex < STUDENT_COUNT - 1)
            {
                currentStudentIndex++;
                DisplayCurrentStudent();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveCurrentStudent();
                using (StreamWriter sw = new StreamWriter(dataFile))
                {
                    for (int i = 0; i < students.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(students[i].Name))
                            sw.WriteLine(students[i].ToFileString());
                    }
                }
                statusLabel.Text = $"Данные сохранены в файл {dataFile}";
                MessageBox.Show($"Данные сохранены в файл {dataFile}", "Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка");
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(dataFile))
                {
                    MessageBox.Show($"Файл {dataFile} не найден!", "Ошибка");
                    return;
                }

                string[] lines = File.ReadAllLines(dataFile);

                // Сбросим массив студентов
                for (int i = 0; i < STUDENT_COUNT; i++)
                {
                    students[i] = new STUDENT();
                }

                for (int i = 0; i < Math.Min(lines.Length, STUDENT_COUNT); i++)
                {
                    string[] studentFields = lines[i].Split(new[] { ';' });

                    students[i].Name = studentFields[0];
                    students[i].numberGrup = Convert.ToInt32(studentFields[1]);

                    string[] gradesStr = studentFields[2].Split(' ');
                    students[i].Grades = new int[gradesStr.Length];

                    for (int j = 0; j < gradesStr.Length; j++)
                    {
                        students[i].Grades[j] = Convert.ToInt32(gradesStr[j]);
                    }

                    students[i].CalculateAverage();
                }

                currentStudentIndex = 0;
                DisplayCurrentStudent();

                // Отображаем загруженные данные в списке
                resultsListBox.Items.Clear();
                resultsListBox.Items.Add("=== Загруженные данные ===");
                for (int i = 0; i < students.Length; i++)
                {
                    if (!string.IsNullOrEmpty(students[i].Name))
                    {
                        resultsListBox.Items.Add(students[i].ToString());
                    }
                }

                statusLabel.Text = $"Данные загружены из файла {dataFile}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                double minAverage = Convert.ToDouble(minAverageTextBox.Text);
                resultsListBox.Items.Clear();

                // Сначала сохраняем текущего студента
                SaveCurrentStudent();

                // Находим студентов с нужным средним баллом
                int count = 0;
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].averageGrade > minAverage && !string.IsNullOrEmpty(students[i].Name))
                    {
                        count++;
                    }
                }

                STUDENT[] result = new STUDENT[count];
                int index = 0;
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].averageGrade > minAverage && !string.IsNullOrEmpty(students[i].Name))
                    {
                        result[index] = students[i];
                        index++;
                    }
                }

                // Сортируем по группам
                Array.Sort(result);

                // Выводим результаты
                resultsListBox.Items.Add($"=== Студенты со средним баллом больше {minAverage:F2} ===");
                resultsListBox.Items.Add("==================================================");

                if (result.Length == 0)
                {
                    resultsListBox.Items.Add($"Нет студентов со средним баллом больше {minAverage:F2}");
                }
                else
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        resultsListBox.Items.Add(result[i].ToString());
                    }
                }

                resultsListBox.Items.Add("==================================================");
                resultsListBox.Items.Add($"Всего найдено: {result.Length} студентов");

                // Сохраняем результаты в файл
                using (StreamWriter sw = new StreamWriter(resultFile))
                {
                    sw.WriteLine($"Студенты со средним баллом больше {minAverage:F2}");
                    sw.WriteLine("==================================================");

                    if (result.Length == 0)
                    {
                        sw.WriteLine($"Нет студентов со средним баллом больше {minAverage:F2}");
                    }
                    else
                    {
                        for (int i = 0; i < result.Length; i++)
                        {
                            sw.WriteLine(result[i].ToString());
                        }
                    }

                    sw.WriteLine("==================================================");
                    sw.WriteLine($"Всего найдено: {result.Length} студентов");
                }

                statusLabel.Text = $"Найдено {result.Length} студентов. Результаты сохранены в {resultFile}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при поиске: {ex.Message}", "Ошибка");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            statusLabel.Text = "Результаты очищены";
        }
    }
}
