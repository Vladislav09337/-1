using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FuzzyStudentSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== НЕЧЕТКИЙ ПОИСК СТУДЕНТОВ ПО ФИО ===");
            Console.WriteLine("Расстояние Левенштейна не более 3\n");

            // Создаем тестовый файл со студентами
            string filePath = "students.txt";
            CreateSampleFile(filePath);

            // Загружаем студентов из файла
            var students = LoadStudentsFromFile(filePath);

            if (students.Count == 0)
            {
                Console.WriteLine("Не удалось загрузить студентов из файла!");
                return;
            }

            Console.WriteLine($"Загружено студентов: {students.Count}\n");

            // Основной цикл поиска
            while (true)
            {
                Console.Write("Введите ФИО для поиска (или 'exit' для выхода): ");
                string query = Console.ReadLine();

                if (query?.ToLower() == "exit")
                    break;

                if (string.IsNullOrWhiteSpace(query))
                {
                    Console.WriteLine("Введите текст для поиска!");
                    continue;
                }

                // Выполняем нечеткий поиск
                var results = FuzzySearch(students, query);

                // Выводим результаты
                Console.WriteLine($"\nРезультаты поиска для '{query}':");
                Console.WriteLine($"Найдено студентов: {results.Count}");

                if (results.Any())
                {
                    foreach (var result in results)
                    {
                        Console.WriteLine($"  {result.Student} (расстояние: {result.Distance})");
                    }
                }
                else
                {
                    Console.WriteLine("  Студенты не найдены");
                }
                Console.WriteLine();
            }
        }

        // Класс студента
        public class Student
        {
            public int Id { get; set; }
            public string FullName { get; set; }

            public override string ToString()
            {
                return $"ID: {Id}, ФИО: {FullName}";
            }
        }

        // Класс для результата поиска
        public class SearchResult
        {
            public Student Student { get; set; }
            public int Distance { get; set; }
        }

        // Создание тестового файла
        static void CreateSampleFile(string filePath)
        {
            var students = new List<string>
            {
                "1,Иванов Иван Иванович",
                "2,Петров Петр Петрович",
                "3,Сидоров Сидор Сидорович",
                "4,Иванова Мария Ивановна",
                "5,Кузнецов Алексей Михайлович",
                "6,Соколова Анна Дмитриевна",
                "7,Морозов Дмитрий Александрович",
                "8,Васильев Василий Васильевич",
                "9,Козлова Елена Владимировна",
                "10,Новиков Павел Сергеевич",
                "11,Иванов Иван Петрович",
                "12,Петрова Ольга Николаевна"
            };

            File.WriteAllLines(filePath, students);
            Console.WriteLine($"Файл {filePath} создан с {students.Count} студентами");
        }

        // Загрузка студентов из файла
        static List<Student> LoadStudentsFromFile(string filePath)
        {
            var students = new List<Student>();

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Файл {filePath} не найден!");
                    return students;
                }

                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var parts = line.Split(',');
                    if (parts.Length >= 2 && int.TryParse(parts[0].Trim(), out int id))
                    {
                        students.Add(new Student
                        {
                            Id = id,
                            FullName = parts[1].Trim()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке файла: {ex.Message}");
            }

            return students;
        }

        // Расчет расстояния Левенштейна
        static int LevenshteinDistance(string source, string target)
        {
            if (string.IsNullOrEmpty(source))
                return string.IsNullOrEmpty(target) ? 0 : target.Length;

            if (string.IsNullOrEmpty(target))
                return source.Length;

            // Приводим к нижнему регистру для регистронезависимости
            source = source.ToLower();
            target = target.ToLower();

            int sourceLength = source.Length;
            int targetLength = target.Length;

            // Создаем матрицу расстояний
            int[,] distance = new int[sourceLength + 1, targetLength + 1];

            // Инициализируем первую строку и первый столбец
            for (int i = 0; i <= sourceLength; distance[i, 0] = i++) { }
            for (int j = 0; j <= targetLength; distance[0, j] = j++) { }

            // Заполняем матрицу
            for (int i = 1; i <= sourceLength; i++)
            {
                for (int j = 1; j <= targetLength; j++)
                {
                    // Стоимость замены (0 если символы равны, иначе 1)
                    int cost = (target[j - 1] == source[i - 1]) ? 0 : 1;

                    // Минимальное значение из трех возможных операций
                    distance[i, j] = Math.Min(
                        Math.Min(distance[i - 1, j] + 1,     // удаление
                                distance[i, j - 1] + 1),     // вставка
                        distance[i - 1, j - 1] + cost);      // замена
                }
            }

            return distance[sourceLength, targetLength];
        }

        // Нечеткий поиск студентов
        static List<SearchResult> FuzzySearch(List<Student> students, string query, int maxDistance = 3)
        {
            var results = new List<SearchResult>();

            foreach (var student in students)
            {
                int distance = LevenshteinDistance(query, student.FullName);

                if (distance <= maxDistance)
                {
                    results.Add(new SearchResult
                    {
                        Student = student,
                        Distance = distance
                    });
                }
            }

            // Сортируем по расстоянию (ближе - выше)
            return results.OrderBy(r => r.Distance).ToList();
        }
    }
}