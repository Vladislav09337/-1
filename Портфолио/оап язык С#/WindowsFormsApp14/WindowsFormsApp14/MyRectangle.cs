using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GeometryFiguresWinForm
{
    public class MyRectangle : Figure
    {
        public MyRectangle(int x1, int y1, int x2, int y2, Color color, string colorName)
            : base(x1, y1, x2, y2, color, colorName) { }

        public override void DrawSolid(Graphics g)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                int x = Math.Min(X1, X2);
                int y = Math.Min(Y1, Y2);
                int w = Math.Abs(X2 - X1);
                int h = Math.Abs(Y2 - Y1);
                g.DrawRectangle(pen, x, y, w, h);
            }
        }
        public override void DrawDashed(Graphics g)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                pen.DashStyle = DashStyle.Dash;  
                int x = Math.Min(X1, X2);
                int y = Math.Min(Y1, Y2);
                int w = Math.Abs(X2 - X1);
                int h = Math.Abs(Y2 - Y1);
                g.DrawRectangle(pen, x, y, w, h);
            }
        }
        public override void Erase(Graphics g, Color backColor)
        {
            using (Pen pen = new Pen(backColor, 3))
            {
                int x = Math.Min(X1, X2);
                int y = Math.Min(Y1, Y2);
                int w = Math.Abs(X2 - X1);
                int h = Math.Abs(Y2 - Y1);
                g.DrawRectangle(pen, x, y, w, h);
            }
        }

        public override string GetName() => "Прямоугольник";

        public override string GetParameters()
        {
            int x = Math.Min(X1, X2);
            int y = Math.Min(Y1, Y2);
            int w = Math.Abs(X2 - X1);
            int h = Math.Abs(Y2 - Y1);
            return $"({x},{y}) {w}x{h}";
        }
    }
}