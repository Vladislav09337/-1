
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

public class RectangleShape : Shape
{
    // конструктор, передающий параметры базовому классу
    public RectangleShape(Point p1, Point p2, Color col) : base(p1, p2, col) { }

    // рисование прямоугольника сплошной линией
    public override void DrawSolid(Graphics g)
    {
        using (Pen pen = new Pen(color, 2))  // создаём перо толщиной 2 пикселя
        {
            // вычисляем координаты и размеры прямоугольника
            int x = Math.Min(point1.X, point2.X);
            int y = Math.Min(point1.Y, point2.Y);
            int w = Math.Abs(point1.X - point2.X);
            int h = Math.Abs(point1.Y - point2.Y);
            g.DrawRectangle(pen, x, y, w, h);  // рисуем прямоугольник
        }
    }

    // рисование прямоугольника пунктирной линией
    public override void DrawDashed(Graphics g)
    {
        using (Pen pen = new Pen(color, 2))
        {
            pen.DashStyle = DashStyle.Dash;  // устанавливаем пунктирный стиль
            int x = Math.Min(point1.X, point2.X);
            int y = Math.Min(point1.Y, point2.Y);
            int w = Math.Abs(point1.X - point2.X);
            int h = Math.Abs(point1.Y - point2.Y);
            g.DrawRectangle(pen, x, y, w, h);
        }
    }

    // стирание прямоугольника (рисуем белым цветом)
    public override void Erase(Graphics g)
    {
        using (Pen pen = new Pen(Color.White, 3))  // белое перо толще для надёжного стирания
        {
            int x = Math.Min(point1.X, point2.X);
            int y = Math.Min(point1.Y, point2.Y);
            int w = Math.Abs(point1.X - point2.X);
            int h = Math.Abs(point1.Y - point2.Y);
            g.DrawRectangle(pen, x, y, w, h);
        }
    }
}