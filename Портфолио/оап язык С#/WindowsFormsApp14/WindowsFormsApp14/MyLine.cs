using System.Drawing;
using System.Drawing.Drawing2D;

namespace GeometryFiguresWinForm
{
    public class MyLine : Figure
    {
        public MyLine(int x1, int y1, int x2, int y2, Color color, string colorName)
            : base(x1, y1, x2, y2, color, colorName) { }

        public override void DrawSolid(Graphics g)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                g.DrawLine(pen, X1, Y1, X2, Y2);
            }
        }
        public override void DrawDashed(Graphics g)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                pen.DashStyle = DashStyle.Dash;
                g.DrawLine(pen, X1, Y1, X2, Y2);
            }
        }
        public override void Erase(Graphics g, Color backColor)
        {
            using (Pen pen = new Pen(backColor, 3))
            {
                g.DrawLine(pen, X1, Y1, X2, Y2);
            }
        }

        public override string GetName() => "Линия";

        public override string GetParameters()
        {
            return $"({X1},{Y1}) -> ({X2},{Y2})";
        }
    }
}