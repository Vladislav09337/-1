using System;
using System.Drawing;

namespace SolarSystemReference
{
    // базовый абстрактный класс для всех небесных тел
    public abstract class CelestialBody
    {
        public string Name { get; set; }
        public Image Photo { get; set; }
        public double Mass { get; set; }
        public double Radius { get; set; }

        // конструктор базового класса
        protected CelestialBody(string name, Image photo, double mass, double radius)
        {
            this.Name = name;
            this.Photo = photo;
            this.Mass = mass;
            this.Radius = radius;
        }

        // виртуальный метод для получения информации
        public virtual string GetInfo()
        {
            return "название: " + this.Name + "\n" +
                   "масса: " + this.Mass.ToString("E2") + " кг\n" +
                   "радиус: " + this.Radius.ToString("N0") + " км";
        }
    }
}