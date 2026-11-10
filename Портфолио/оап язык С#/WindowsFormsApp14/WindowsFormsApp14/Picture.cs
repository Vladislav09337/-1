using System;

namespace GeometryFiguresWinForm
{
    public class Picture
    {
        // Приватные поля (согласно заданию)
        private Figure[] shpArray;   // Массив фигур
        private int n;               // Размерность массива

        public int N
        {
            get => n;
            set
            {
                if (value > 0)
                {
                    n = value;
                    shpArray = new Figure[n];
                }
                else
                {
                    throw new ArgumentException("Размерность массива должна быть больше нуля");
                }
            }
        }

        public Picture(int size)
        {
            N = size;
        }
        public void FillArray(int index, Figure figure)
        {
            if (index >= 0 && index < n)
            {
                shpArray[index] = figure;
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс вне границ массива");
            }
        }

        public string GetNames()
        {
            string result = "Список фигур в Picture:\n";
            for (int i = 0; i < n; i++)
            {
                if (shpArray[i] != null)
                {
                    result += $"{i + 1}. {shpArray[i].GetName()}\n";
                }
            }
            return result;
        }


        public Figure GetFigure(int index)
        {
            if (index >= 0 && index < n)
                return shpArray[index];
            return null;
        }
    }
}