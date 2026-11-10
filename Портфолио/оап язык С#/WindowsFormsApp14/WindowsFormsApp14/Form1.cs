using System;                    
using System.Collections.Generic; 
using System.Drawing;            
using System.Windows.Forms;      

namespace GeometryFiguresWinForm
{
    public partial class Form1 : Form
    {
        // Хранилище всех фигур 
        private Picture picture;
        private int figureCount = 0;

        // Словарь 
        private Dictionary<string, Color> colorMap;
        public Form1()
        {
            InitializeComponent();          
            InitializeColorMap();           
            picture = new Picture(7);       
            UpdateFigureCount();            
        }

        // Метод заполняет словарь цветов
        private void InitializeColorMap()
        {
            colorMap = new Dictionary<string, Color>
            {
                { "Красный", Color.Red },
                { "Синий", Color.Blue },
                { "Зеленый", Color.Green },
                { "Черный", Color.Black },
                { "Фиолетовый", Color.Purple },
                { "Оранжевый", Color.Orange },
                { "Коричневый", Color.Brown }
            };
        }
        private void UpdateFigureCount()
        { 
            lblFigureCount.Text = $"{figureCount} / {picture.N}";

            // Если фигур столько же или больше, чем максимум то красный, иначе зелёный
            lblFigureCount.ForeColor = figureCount >= picture.N ? Color.Red : Color.FromArgb(76, 175, 80);
        }
        private void UpdateStatus(string message) //(string message) означает объявление параметра метода
        {
            lblStatus.Text = message;
        }
        private void BtnCreateTest_Click(object sender, EventArgs e)
        {
            figureCount = 0;                
            lstFigures.Items.Clear();       
            panelDrawing.Invalidate();     

            picture.FillArray(0, new MyRectangle(50, 50, 150, 100, Color.Red, "Красный"));
            picture.FillArray(1, new MyRectangle(200, 50, 300, 120, Color.Blue, "Синий"));
            picture.FillArray(2, new MyEllipse(50, 150, 150, 220, Color.Green, "Зеленый"));
            picture.FillArray(3, new MyEllipse(200, 150, 280, 230, Color.Purple, "Фиолетовый"));
            picture.FillArray(4, new MyLine(50, 280, 150, 350, Color.Black, "Черный"));
            picture.FillArray(5, new MyLine(200, 280, 300, 360, Color.Orange, "Оранжевый"));
            picture.FillArray(6, new MyRectangle(350, 50, 450, 150, Color.Brown, "Коричневый"));

            figureCount = 7;   

            for (int i = 0; i < figureCount; i++)
            {
                Figure fig = picture.GetFigure(i);   // Получаем фигуру по индексу
                lstFigures.Items.Add($"{i + 1}. {fig.GetName()} ({fig.ColorName}) - {fig.GetParameters()}");
            }

            UpdateFigureCount();
            UpdateStatus("Создано 7 тестовых фигур");
            MessageBox.Show("Создано 7 тестовых фигур!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка: не превышен ли лимит фигур
                if (figureCount >= picture.N)
                {
                    MessageBox.Show($"Достигнут лимит фигур ({picture.N})", "Внимание",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Считываем координаты из текстовых полей 
                int x1 = int.Parse(txtX1.Text);
                int y1 = int.Parse(txtY1.Text);
                int x2 = int.Parse(txtX2.Text);
                int y2 = int.Parse(txtY2.Text);
                string colorName = cmbColor.SelectedItem.ToString();
                Color color = colorMap[colorName];

                // Создаём фигуру нужного типа (полиморфизм)
                Figure newFigure = null;
                switch (cmbFigureType.SelectedItem.ToString())
                {
                    case "Прямоугольник":
                        newFigure = new MyRectangle(x1, y1, x2, y2, color, colorName);
                        break;
                    case "Эллипс":
                        newFigure = new MyEllipse(x1, y1, x2, y2, color, colorName);
                        break;
                    case "Линия":
                        newFigure = new MyLine(x1, y1, x2, y2, color, colorName);
                        break;
                }

                picture.FillArray(figureCount, newFigure);

                lstFigures.Items.Add($"{figureCount + 1}. {newFigure.GetName()} ({newFigure.ColorName}) - {newFigure.GetParameters()}");

                figureCount++;              
                UpdateFigureCount();        
                panelDrawing.Invalidate();  

                UpdateStatus($"Добавлена фигура: {newFigure.GetName()}");
                MessageBox.Show("Фигура добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)   // Ловим любые ошибки 
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            if (lstFigures.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите фигуру из списка!", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем фигуру по индексу выбранного элемента списка
            Figure fig = picture.GetFigure(lstFigures.SelectedIndex);
            if (fig != null)
            {
                using (Graphics g = panelDrawing.CreateGraphics())
                {
                    if (cmbDrawMode.SelectedItem.ToString() == "Сплошная линия")
                        fig.DrawSolid(g);   
                    else
                        fig.DrawDashed(g);  

                    UpdateStatus($"Нарисована фигура: {fig.GetName()}");
                } 
            }
        }
        private void BtnErase_Click(object sender, EventArgs e)
        {
            if (lstFigures.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите фигуру из списка!", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Figure fig = picture.GetFigure(lstFigures.SelectedIndex);
            if (fig != null)
            {
                using (Graphics g = panelDrawing.CreateGraphics())
                {
                    fig.Erase(g, panelDrawing.BackColor);
                    UpdateStatus($"Стерта фигура: {fig.GetName()}");
                }
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            panelDrawing.Invalidate();
            UpdateStatus("Область рисования очищена");
        }

        private void BtnShowNames_Click(object sender, EventArgs e)
        {
            if (figureCount == 0)
            {
                MessageBox.Show("Нет добавленных фигур!", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(picture.GetNames(), "Имена фигур в Picture",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateStatus("Выведен список имен всех фигур");
        }
    }
}