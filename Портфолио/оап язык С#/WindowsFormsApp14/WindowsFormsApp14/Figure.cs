using System.Drawing;

namespace GeometryFiguresWinForm
{
    public abstract class Figure
    {
        // Приватные поля (согласно заданию)
        private int x1, y1, x2, y2;     
        private Color color;            

        // Публичные свойства для доступа к приватным полям
        public int X1 { get => x1; set => x1 = value; }
        public int Y1 { get => y1; set => y1 = value; }
        public int X2 { get => x2; set => x2 = value; }
        public int Y2 { get => y2; set => y2 = value; }
        public Color Color { get => color; set => color = value; }
        public string ColorName { get; set; }   

        public Figure(int x1, int y1, int x2, int y2, Color color, string colorName)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Color = color;
            ColorName = colorName;
        }

        // Абстрактные методы 
        public abstract void DrawSolid(Graphics g);      // Рисование сплошной линией
        public abstract void DrawDashed(Graphics g);     // Рисование пунктирной линией
        public abstract void Erase(Graphics g, Color backColor);  // Стирание фигуры
        public abstract string GetName();                // Получение имени фигуры
        public abstract string GetParameters();          // Получение параметров фигуры
    }
}