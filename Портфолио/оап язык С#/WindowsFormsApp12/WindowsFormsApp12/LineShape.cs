
using System.Drawing;
using System.Drawing.Drawing2D;

public class LineShape : Shape
{
    // конструктор, передающий параметры базовому классу
    public LineShape(Point p1, Point p2, Color col) : base(p1, p2, col) { }

    // рисование линии сплошной линией
    public override void DrawSolid(Graphics g)
    {
        using (Pen pen = new Pen(color, 2))
        {
            g.DrawLine(pen, point1, point2);  // рисуем линию между двумя точками
        }
    }

    // рисование линии пунктирной линией
    public override void DrawDashed(Graphics g)
    {
        using (Pen pen = new Pen(color, 2))
        {
            pen.DashStyle = DashStyle.Dash;  // пунктирный стиль
            g.DrawLine(pen, point1, point2);
        }
    }

    // стирание линии
    public override void Erase(Graphics g)
    {
        using (Pen pen = new Pen(Color.White, 3))  // белая линия поверх
        {
            g.DrawLine(pen, point1, point2);
        }
    }
}