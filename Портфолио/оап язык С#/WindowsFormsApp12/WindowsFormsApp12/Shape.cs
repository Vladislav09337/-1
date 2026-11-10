
using System.Drawing;

public abstract class Shape
{
    protected Point point1;  // первая точка фигуры
    protected Point point2;  // вторая точка фигуры
    protected Color color;   // цвет фигуры

    // конструктор, получающий две точки и цвет
    public Shape(Point p1, Point p2, Color col)
    {
        point1 = p1;
        point2 = p2;
        color = col;
    }

    // абстрактный метод рисования сплошной линией
    public abstract void DrawSolid(Graphics g);

    // абстрактный метод рисования пунктирной линией
    public abstract void DrawDashed(Graphics g);

    // абстрактный метод стирания фигуры
    public abstract void Erase(Graphics g);
}