using System.Drawing;

namespace SolarSystemReference
{
    // класс звезда, наследуется от celestialbody
    public class Star : CelestialBody
    {
        public double Temperature { get; set; }

        // конструктор вызывает конструктор базового класса через base
        public Star(string name, Image photo, double mass, double radius, double temperature)
            : base(name, photo, mass, radius)
        {
            this.Temperature = temperature;
        }

        // переопределяем метод getinfo, добавляем информацию о температуре
        public override string GetInfo()
        {
            return base.GetInfo() + "\n" +
                   "температура: " + this.Temperature.ToString("N0") + " k\n" +
                   "тип: звезда";
        }
    }
}
