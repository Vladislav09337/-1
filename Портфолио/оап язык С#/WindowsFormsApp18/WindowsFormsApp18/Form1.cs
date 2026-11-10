using System.Drawing;
using System.Windows.Forms;

namespace Практическая_работа_20
{
    public partial class Form1 : Form
    {
        // Прямоугольники задают положение и размер всех фигур (x, y, ширина, высота)
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);  
        Rectangle Circle = new Rectangle(220, 10, 150, 150);   
        Rectangle Square = new Rectangle(380, 10, 150, 150);   
        Rectangle Triangle = new Rectangle(540, 10, 150, 150); 

        // Флаги: нажали ли мы на фигурку (перетаскивание активно)
        bool clickRec = false;
        bool clickCir = false;
        bool clickSq = false;
        bool clickTri = false;

        int RecX = 0, RecY = 0;
        int CirX = 0, CirY = 0;
        int SqX = 0, SqY = 0;
        int TriX = 0, TriY = 0;

        // Временные переменные для обмена координатами между фигурами
        int X, Y, dX, dY;
        int LastClicked = 0;
        int PeredniPlan = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Построение массива точек для треугольника (равнобедренный)
            Point[] trianglePoints = new Point[]
            {
                new Point(Triangle.X + Triangle.Width / 2, Triangle.Y), // верхняя вершина
                new Point(Triangle.X + Triangle.Width, Triangle.Y + Triangle.Height), // правый нижний угол
                new Point(Triangle.X, Triangle.Y + Triangle.Height) // левый нижний угол
            };



            if (PeredniPlan == 1)  // Прямоугольник на переднем плане
            {
                e.Graphics.FillEllipse(Brushes.Red, Circle);
                e.Graphics.FillRectangle(Brushes.Blue, Square);
                e.Graphics.FillPolygon(Brushes.Purple, trianglePoints);
                e.Graphics.FillRectangle(Brushes.Green, Rectangle); 
            }
            else if (PeredniPlan == 2)  // Окружность на переднем плане
            {
                e.Graphics.FillRectangle(Brushes.Green, Rectangle);
                e.Graphics.FillRectangle(Brushes.Blue, Square);
                e.Graphics.FillPolygon(Brushes.Purple, trianglePoints);
                e.Graphics.FillEllipse(Brushes.Red, Circle); // Сверху
            }
            else if (PeredniPlan == 3)  // Квадрат на переднем плане
            {
                e.Graphics.FillRectangle(Brushes.Green, Rectangle);
                e.Graphics.FillEllipse(Brushes.Red, Circle);
                e.Graphics.FillPolygon(Brushes.Purple, trianglePoints);
                e.Graphics.FillRectangle(Brushes.Blue, Square); // Сверху
            }
            else if (PeredniPlan == 4)  // Треугольник на переднем плане
            {
                e.Graphics.FillRectangle(Brushes.Green, Rectangle);
                e.Graphics.FillEllipse(Brushes.Red, Circle);
                e.Graphics.FillRectangle(Brushes.Blue, Square);
                e.Graphics.FillPolygon(Brushes.Purple, trianglePoints); // Сверху
            }
            else  // Порядок по умолчанию (ничего не выбран)
            {
                e.Graphics.FillPolygon(Brushes.Purple, trianglePoints);
                e.Graphics.FillEllipse(Brushes.Red, Circle);
                e.Graphics.FillRectangle(Brushes.Blue, Square);
                e.Graphics.FillRectangle(Brushes.Green, Rectangle);
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Проверка попадания в прямоугольник
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X))
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    clickRec = true;                     // Включаем флаг перетаскивания
                    RecX = e.X - Rectangle.X;            // Запоминаем смещение курсора относительно угла фигуры
                    RecY = e.Y - Rectangle.Y;
                    LastClicked = 1;                     // Запоминаем, что нажат прямоугольник
                    PeredniPlan = 1;                     // Делаем его на переднем плане
                }
            }

            // Проверка попадания в окружность
            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    clickCir = true;
                    CirX = e.X - Circle.X;
                    CirY = e.Y - Circle.Y;
                    LastClicked = 2;
                    PeredniPlan = 2;
                }
            }

            // Проверка попадания в квадрат
            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    clickSq = true;
                    SqX = e.X - Square.X;
                    SqY = e.Y - Square.Y;
                    LastClicked = 3;
                    PeredniPlan = 3;
                }
            }

            // Проверка попадания в треугольник
            if ((e.X < Triangle.X + Triangle.Width) && (e.X > Triangle.X))
            {
                if ((e.Y < Triangle.Y + Triangle.Height) && (e.Y > Triangle.Y))
                {
                    clickTri = true;
                    TriX = e.X - Triangle.X;
                    TriY = e.Y - Triangle.Y;
                    LastClicked = 4;
                    PeredniPlan = 4;
                }
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            // Сбрасываем все флаги перетаскивания
            clickRec = false;
            clickCir = false;
            clickSq = false;
            clickTri = false;


            if (LastClicked == 2)
            {
                if ((lblForm.Location.X < Square.X + Square.Width) && (lblForm.Location.X > Square.X))
                {
                    if ((lblForm.Location.Y < Square.Y + Square.Height) && (lblForm.Location.Y > Square.Y))
                    {
                        // Сохраняем старые координаты окружности
                        X = Circle.X;
                        Y = Circle.Y;
                        dX = CirX;
                        dY = CirY;

                        // Перемещаем окружность на место квадрата
                        Circle.X = Square.X;
                        Circle.Y = Square.Y;
                        CirX = SqX;
                        CirY = SqY;

                        // Перемещаем квадрат на место окружности
                        Square.X = X;
                        Square.Y = Y;
                        SqX = dX;
                        SqY = dY;
                    }
                }
            }

            if (LastClicked == 3)
            {
                if ((lblForm.Location.X < Circle.X + Circle.Width) && (lblForm.Location.X > Circle.X))
                {
                    if ((lblForm.Location.Y < Circle.Y + Circle.Height) && (lblForm.Location.Y > Circle.Y))
                    {
                        X = Square.X;
                        Y = Square.Y;
                        dX = SqX;
                        dY = SqY;

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
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // Если зажат прямоугольник - перемещаем его
            if (clickRec)
            {
                Rectangle.X = e.X - RecX;  // Новый X = курсор - начальное смещение
                Rectangle.Y = e.Y - RecY;
            }

            if (clickCir)
            {
                Circle.X = e.X - CirX;
                Circle.Y = e.Y - CirY;
            }

            if (clickSq)
            {
                Square.X = e.X - SqX;
                Square.Y = e.Y - SqY;
            }

            if (clickTri)
            {
                Triangle.X = e.X - TriX;
                Triangle.Y = e.Y - TriY;
            }

            // Перерисовываем pictureBox, чтобы увидеть перемещение
            pictureBox.Invalidate();

            if ((lblVid.Location.X < Square.X + Square.Width) && (lblVid.Location.X > Square.X))
            {
                if ((lblVid.Location.Y < Square.Y + Square.Height) && (lblVid.Location.Y > Square.Y))
                {
                    lblInfo.Text = "Синий квадрат";
                    lblInfo.BackColor = Color.Blue;
                    lblInfo.ForeColor = Color.White;
                }
            }

            if ((lblVid.Location.X < Rectangle.X + Rectangle.Width) && (lblVid.Location.X > Rectangle.X))
            {
                if ((lblVid.Location.Y < Rectangle.Y + Rectangle.Height) && (lblVid.Location.Y > Rectangle.Y))
                {
                    lblInfo.Text = "Зеленый прямоугольник";
                    lblInfo.BackColor = Color.Green;
                    lblInfo.ForeColor = Color.Black;
                }
            }

            if ((lblVid.Location.X < Circle.X + Circle.Width) && (lblVid.Location.X > Circle.X))
            {
                if ((lblVid.Location.Y < Circle.Y + Circle.Height) && (lblVid.Location.Y > Circle.Y))
                {
                    lblInfo.Text = "Красная окружность";
                    lblInfo.BackColor = Color.Red;
                    lblInfo.ForeColor = Color.Black;
                }
            }

            if ((lblVid.Location.X < Triangle.X + Triangle.Width) && (lblVid.Location.X > Triangle.X))
            {
                if ((lblVid.Location.Y < Triangle.Y + Triangle.Height) && (lblVid.Location.Y > Triangle.Y))
                {
                    lblInfo.Text = "Фиолетовый треугольник";
                    lblInfo.BackColor = Color.Purple;
                    lblInfo.ForeColor = Color.White;
                }
            }
        }
    }
}