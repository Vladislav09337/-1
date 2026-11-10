
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

public class EllipseShape : Shape
{
    // конструктор, передающий параметры базовому классу
    public EllipseShape(Point p1, Point p2, Color col) : base(p1, p2, col) { }

    // рисование эллипса сплошной линией
    public override void DrawSolid(Graphics g)
    {
        using (Pen pen = new Pen(color, 2))
        {
            // вычисляем описывающий прямоугольник для эллипса
            int x = Math.Min(point1.X, point2.X);
            int y = Math.Min(point1.Y, point2.Y);
            int w = Math.Abs(point1.X - point2.X);
            int h = Math.Abs(point1.Y - point2.Y);
            g.DrawEllipse(pen, x, y, w, h);  // рисуем эллипс
        }
    }

    // рисование эллипса пунктирной линией
    public override void DrawDashed(Graphics g)
    {
        using (Pen pen = new Pen(color, 2))
        {
            pen.DashStyle = DashStyle.Dash;
            int x = Math.Min(point1.X, point2.X);
            int y = Math.Min(point1.Y, point2.Y);
            int w = Math.Abs(point1.X - point2.X);
            int h = Math.Abs(point1.Y - point2.Y);
            g.DrawEllipse(pen, x, y, w, h);
        }
    }

    // стирание эллипса
    public override void Erase(Graphics g)
    {
        using (Pen pen = new Pen(Color.White, 3))
        {
            int x = Math.Min(point1.X, point2.X);
            int y = Math.Min(point1.Y, point2.Y);
            int w = Math.Abs(point1.X - point2.X);
            int h = Math.Abs(point1.Y - point2.Y);
            g.DrawEllipse(pen, x, y, w, h);
        }
    }
}