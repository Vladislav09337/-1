
using System;
using System.Drawing;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private Shape currentShape;  // текущая нарисованная фигура

    public MainForm()
    {
        InitializeComponent();
        SetupEvents();  // подписываемся на события кнопок
        DrawGrid();  // рисуем сетку для ориентира
    }

    // подписка на события кнопок
    private void SetupEvents()
    {
        btnDrawSolid.Click += (s, e) => DrawCurrentShape(true);    // сплошная линия
        btnDrawDashed.Click += (s, e) => DrawCurrentShape(false);  // пунктирная линия
        btnErase.Click += (s, e) => EraseCurrentShape();           // стирание

        // при изменении размера окна. перерисовываем сетку
        this.Resize += (s, e) => { drawingPanel.Invalidate(); DrawGrid(); };
    }

    // рисование вспомогательной сетки
    private void DrawGrid()
    {
        using (Graphics g = drawingPanel.CreateGraphics())
        using (Pen lightPen = new Pen(Color.LightGray, 1))
        {
            // рисуем вертикальные линии с шагом 50 пикселей
            for (int x = 0; x < drawingPanel.Width; x += 50)
            {
                g.DrawLine(lightPen, x, 0, x, drawingPanel.Height);
            }

            // рисуем горизонтальные линии с шагом 50 пикселей
            for (int y = 0; y < drawingPanel.Height; y += 50)
            {
                g.DrawLine(lightPen, 0, y, drawingPanel.Width, y);
            }

            // рисуем оси координат (более тёмные линии)
            using (Pen darkPen = new Pen(Color.Gray, 1))
            {
                g.DrawLine(darkPen, 0, 0, drawingPanel.Width, 0);   // ось x
                g.DrawLine(darkPen, 0, 0, 0, drawingPanel.Height);  // ось y
            }
        }
    }

    // рисование текущей фигуры
    private void DrawCurrentShape(bool isSolid)
    {
        // получаем координаты из полей ввода
        if (!TryGetCoordinates(out Point p1, out Point p2)) return;

        // проверяем, что координаты не выходят за пределы панели
        if (p1.X < 0 || p1.Y < 0 || p2.X < 0 || p2.Y < 0 ||
            p1.X > drawingPanel.Width || p1.Y > drawingPanel.Height ||
            p2.X > drawingPanel.Width || p2.Y > drawingPanel.Height)
        {
            MessageBox.Show($"координаты должны быть в пределах панели рисования\n" +
                           $"размер панели: {drawingPanel.Width} x {drawingPanel.Height}\n" +
                           $"ваши координаты: ({p1.X},{p1.Y}) и ({p2.X},{p2.Y})");
            return;
        }

        // определяем тип фигуры из выпадающего списка
        string selected = cmbFigures.SelectedItem?.ToString();
        Color color = Color.Black;  // цвет фигуры

        // создаём соответствующий объект фигуры
        if (selected == "Прямоугольник")
            currentShape = new RectangleShape(p1, p2, color);
        else if (selected == "Эллипс")
            currentShape = new EllipseShape(p1, p2, color);
        else if (selected == "Линия")
            currentShape = new LineShape(p1, p2, color);
        else
        {
            MessageBox.Show("выберите тип фигуры");
            return;
        }

        // рисуем фигуру на панели
        using (Graphics g = drawingPanel.CreateGraphics())
        {
            if (isSolid)
                currentShape.DrawSolid(g);   // сплошная линия
            else
                currentShape.DrawDashed(g);  // пунктирная линия
        }
    }

    // стирание текущей фигуры
    private void EraseCurrentShape()
    {
        if (currentShape == null)
        {
            // если нет фигуры, просто очищаем панель и рисуем сетку
            drawingPanel.Invalidate();
            DrawGrid();
            return;
        }

        // закрашиваем фигуру белым цветом 
        using (Graphics g = drawingPanel.CreateGraphics())
        {
            currentShape.Erase(g);
        }
        currentShape = null;  // сбрасываем фигуру

        // восстанавливаем сетку после стирания
        DrawGrid();
    }

    // получение координат из текстовых полей
    private bool TryGetCoordinates(out Point p1, out Point p2)
    {
        p1 = Point.Empty;
        p2 = Point.Empty;

        // преобразовать текст в числа
        if (!int.TryParse(txtX1.Text, out int x1) ||
            !int.TryParse(txtY1.Text, out int y1) ||
            !int.TryParse(txtX2.Text, out int x2) ||
            !int.TryParse(txtY2.Text, out int y2))
        {
            MessageBox.Show("введите корректные целые координаты");
            return false;
        }

        p1 = new Point(x1, y1);
        p2 = new Point(x2, y2);
        return true;
    }
}