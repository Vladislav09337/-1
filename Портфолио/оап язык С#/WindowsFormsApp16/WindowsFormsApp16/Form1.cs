using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа_20
{
    public partial class Form20 : Form
    {
        // ========== ОБЪЯВЛЕНИЕ ФИГУР ==========
        // Все фигуры хранятся как прямоугольники (Rectangle), которые задают положение и размер
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);      // Жёлтый прямоугольник (x, y, ширина, высота)
        Rectangle Circle = new Rectangle(220, 10, 150, 150);       // Красная окружность (круг вписан в квадрат)
        Rectangle Square = new Rectangle(380, 10, 150, 150);       // Синий квадрат
        Rectangle Triangle = new Rectangle(10, 170, 150, 150);     // Фиолетовый треугольник

        // ========== ФЛАГИ ПЕРЕТАСКИВАНИЯ ==========
        // Определяют, какую фигуру сейчас перетаскивает пользователь
        bool clickRec = false;      // Перетаскивается ли прямоугольник
        bool clickCir = false;      // Перетаскивается ли окружность
        bool clickSq = false;       // Перетаскивается ли квадрат
        bool clickTri = false;      // Перетаскивается ли треугольник

        // ========== КООРДИНАТЫ ТОЧКИ КЛИКА ВНУТРИ ФИГУРЫ ==========
        // Хранят смещение от верхнего левого угла фигуры до места клика мыши
        // Нужны для плавного перетаскивания без "прыжков"
        int RecX = 0, RecY = 0;     // Смещение для прямоугольника
        int CirX = 0, CirY = 0;     // Смещение для окружности
        int SqX = 0, SqY = 0;       // Смещение для квадрата
        int TriX = 0, TriY = 0;     // Смещение для треугольника

        // ========== ВСПОМОГАТЕЛЬНЫЕ ПЕРЕМЕННЫЕ ДЛЯ ОБМЕНА ФИГУР ==========
        int X, Y, dX, dY;           // Используются при обмене позициями фигур
        int LastClicked = 0;        // Хранит последнюю кликнутую фигуру (1-прям, 2-круг, 3-квад, 4-треуг)

        // ========== ПЕРЕМЕННЫЕ ДЛЯ Z-ИНДЕКСА (ПОРЯДОК ОТРИСОВКИ) ==========
        // Чем больше число, тем выше фигура на экране (рисуется последней)
        int recOrder = 0;     // Приоритет прямоугольника
        int cirOrder = 0;     // Приоритет окружности
        int sqOrder = 0;      // Приоритет квадрата
        int triOrder = 0;     // Приоритет треугольника

        public Form20()
        {
            InitializeComponent();
        }

        // ========== ОТРИСОВКА ВСЕХ ФИГУР ==========
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Формируем точки для треугольника (равнобедренный треугольник)
            Point[] trianglePoints = new Point[3];
            trianglePoints[0] = new Point(Triangle.X + Triangle.Width / 2, Triangle.Y);           // Верхняя вершина (центр по X)
            trianglePoints[1] = new Point(Triangle.X, Triangle.Y + Triangle.Height);              // Нижняя левая вершина
            trianglePoints[2] = new Point(Triangle.X + Triangle.Width, Triangle.Y + Triangle.Height); // Нижняя правая вершина

            // Создаём массив фигур с их приоритетами и методами отрисовки
            var shapes = new[]
            {
                new { Order = recOrder, Draw = (Action)delegate { e.Graphics.FillRectangle(Brushes.Yellow, Rectangle); } },
                new { Order = cirOrder, Draw = (Action)delegate { e.Graphics.FillEllipse(Brushes.Red, Circle); } },
                new { Order = sqOrder, Draw = (Action)delegate { e.Graphics.FillRectangle(Brushes.Blue, Square); } },
                new { Order = triOrder, Draw = (Action)delegate { e.Graphics.FillPolygon(Brushes.Purple, trianglePoints); } }
            };

            // Сортируем фигуры по приоритету и рисуем от меньшего к большему
            // Благодаря этому последняя кликнутая фигура оказывается сверху
            foreach (var shape in shapes.OrderBy(s => s.Order))
            {
                shape.Draw();
            }
        }

        // ========== ОБРАБОТКА НАЖАТИЯ КНОПКИ МЫШИ ==========
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // ---- ПРОВЕРКА КЛИКА ПО ПРЯМОУГОЛЬНИКУ ----
            // Условие: курсор внутри границ прямоугольника по X и по Y
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X))
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    clickRec = true;                              // Включаем флаг перетаскивания
                    RecX = e.X - Rectangle.X;                     // Вычисляем смещение по X
                    RecY = e.Y - Rectangle.Y;                     // Вычисляем смещение по Y
                    LastClicked = 1;                              // Запоминаем, что кликнули прямоугольник
                    recOrder = GetMaxOrder() + 1;                 // Поднимаем на передний план
                }
            }

            // ---- ПРОВЕРКА КЛИКА ПО ОКРУЖНОСТИ ----
            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    clickCir = true;
                    CirX = e.X - Circle.X;
                    CirY = e.Y - Circle.Y;
                    LastClicked = 2;
                    cirOrder = GetMaxOrder() + 1;                 // Поднимаем на передний план
                }
            }

            // ---- ПРОВЕРКА КЛИКА ПО КВАДРАТУ ----
            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    clickSq = true;
                    SqX = e.X - Square.X;
                    SqY = e.Y - Square.Y;
                    LastClicked = 3;
                    sqOrder = GetMaxOrder() + 1;                 // Поднимаем на передний план
                }
            }

            // ---- ПРОВЕРКА КЛИКА ПО ТРЕУГОЛЬНИКУ ----
            if ((e.X < Triangle.X + Triangle.Width) && (e.X > Triangle.X))
            {
                if ((e.Y < Triangle.Y + Triangle.Height) && (e.Y > Triangle.Y))
                {
                    clickTri = true;
                    TriX = e.X - Triangle.X;
                    TriY = e.Y - Triangle.Y;
                    LastClicked = 4;
                    triOrder = GetMaxOrder() + 1;                 // Поднимаем на передний план
                }
            }
        }

        // ========== ОБРАБОТКА ОТПУСКАНИЯ КНОПКИ МЫШИ ==========
        // Здесь реализован обмен позициями между фигурами (функциональность "свап")
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            // Сбрасываем все флаги перетаскивания
            clickRec = false;
            clickCir = false;
            clickSq = false;
            clickTri = false;

            // ---- ЕСЛИ ПОСЛЕДНИЙ БЫЛ КРУГ, И ЕГО ПЕРЕМЕСТИЛИ НА КВАДРАТ ----
            if (LastClicked == 2) // Круг
            {
                // Проверяем, находится ли метка lblForm над окружностью
                if ((lblForm.Location.X < Circle.X + Circle.Width) && (lblForm.Location.X > Circle.X))
                {
                    if ((lblForm.Location.Y < Circle.Y + Circle.Height) && (lblForm.Location.Y > Circle.Y))
                    {
                        // Сохраняем данные круга
                        X = Circle.X;
                        Y = Circle.Y;
                        dX = CirX;
                        dY = CirY;
                        // Меняем местами круг и квадрат
                        Circle.X = Square.X;
                        Circle.Y = Square.Y;
                        CirX = SqX;
                        CirY = SqY;
                        Square.X = X;
                        Square.Y = Y;
                        SqX = dX;
                        SqY = dY;
                    }
                }
            }

            // ---- ЕСЛИ ПОСЛЕДНИЙ БЫЛ КВАДРАТ, И ЕГО ПЕРЕМЕСТИЛИ НА КРУГ ----
            if (LastClicked == 3) // Квадрат
            {
                if ((lblForm.Location.X < Circle.X + Circle.Width) && (lblForm.Location.X > Circle.X))
                {
                    if ((lblForm.Location.Y < Circle.Y + Circle.Height) && (lblForm.Location.Y > Circle.Y))
                    {
                        // Сохраняем данные квадрата
                        X = Square.X;
                        Y = Square.Y;
                        dX = SqX;
                        dY = SqY;
                        // Меняем местами квадрат и круг
                        Square.X = Circle.X;
                        Square.Y = Circle.Y;
                        SqX = CirX;
                        SqY = CirY;
                        Circle.X = X;
                        Circle.Y = Y;
                        CirX = dX;
                        CirY = dY;
                    }
                }
            }
            // Примечание: для треугольника и прямоугольника обмен не реализован,
            // так как в исходном коде был только обмен между кругом и квадратом
        }

        // ========== ОБРАБОТКА ПЕРЕМЕЩЕНИЯ МЫШИ (ПЕРЕТАСКИВАНИЕ) ==========
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // Перетаскивание прямоугольника
            if (clickRec)
            {
                Rectangle.X = e.X - RecX;    // Новая позиция = курсор - смещение
                Rectangle.Y = e.Y - RecY;
            }

            // Перетаскивание окружности
            if (clickCir)
            {
                Circle.X = e.X - CirX;
                Circle.Y = e.Y - CirY;
            }

            // Перетаскивание квадрата
            if (clickSq)
            {
                Square.X = e.X - SqX;
                Square.Y = e.Y - SqY;
            }

            // Перетаскивание треугольника
            if (clickTri)
            {
                Triangle.X = e.X - TriX;
                Triangle.Y = e.Y - TriY;
            }

            // Перерисовываем pictureBox (вызывается событие Paint)
            pictureBox.Invalidate();

            // ========== ОПРЕДЕЛЕНИЕ ФИГУРЫ ПОД КУРСОРОМ (ДЛЯ lblInfo) ==========
            // Проверка наведения на квадрат
            if ((lblVid.Location.X < Square.X + Square.Width) && (lblVid.Location.X > Square.X))
            {
                if ((lblVid.Location.Y < Square.Y + Square.Height) && (lblVid.Location.Y > Square.Y))
                {
                    lblInfo.Text = "Синий квадрат";
                    lblInfo.BackColor = Color.Blue;
                }
            }

            // Проверка наведения на прямоугольник
            if ((lblVid.Location.X < Rectangle.X + Rectangle.Width) && (lblVid.Location.X > Rectangle.X))
            {
                if ((lblVid.Location.Y < Rectangle.Y + Rectangle.Height) && (lblVid.Location.Y > Rectangle.Y))
                {
                    lblInfo.Text = "жёлтый прямоугольник";
                    lblInfo.BackColor = Color.Yellow;
                }
            }

            // Проверка наведения на круг
            if ((lblVid.Location.X < Circle.X + Circle.Width) && (lblVid.Location.X > Circle.X))
            {
                if ((lblVid.Location.Y < Circle.Y + Circle.Height) && (lblVid.Location.Y > Circle.Y))
                {
                    lblInfo.Text = "Красная окружность";
                    lblInfo.BackColor = Color.Red;
                }
            }

            // Проверка наведения на треугольник
            if ((lblVid.Location.X < Triangle.X + Triangle.Width) && (lblVid.Location.X > Triangle.X))
            {
                if ((lblVid.Location.Y < Triangle.Y + Triangle.Height) && (lblVid.Location.Y > Triangle.Y))
                {
                    lblInfo.Text = "Фиолетовый треугольник";
                    lblInfo.BackColor = Color.Purple;
                }
            }
        }

        // ========== ВСПОМОГАТЕЛЬНЫЙ МЕТОД ДЛЯ ПОЛУЧЕНИЯ МАКСИМАЛЬНОГО ПРИОРИТЕТА ==========
        // Возвращает наибольшее значение порядка отрисовки среди всех фигур
        // Используется, чтобы новая фигура получала приоритет на 1 больше текущего максимума
        private int GetMaxOrder()
        {
            return Math.Max(recOrder, Math.Max(cirOrder, Math.Max(sqOrder, triOrder)));
        }
    }
}