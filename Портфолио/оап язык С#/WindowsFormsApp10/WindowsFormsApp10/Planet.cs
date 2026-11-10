using System.Drawing;

namespace SolarSystemReference
{
    // класс планета, наследуется от celestialbody
    public class Planet : CelestialBody
    {
        public double DistanceFromSun { get; set; }
        public Star Sun { get; set; }

        // конструктор
        public Planet(string name, Image photo, double mass, double radius,
                      double distanceFromSun, Star sun)
            : base(name, photo, mass, radius)
        {
            this.DistanceFromSun = distanceFromSun;
            this.Sun = sun;
        }

        // переопределяем метод getinfo, добавляем расстояние от солнца
        public override string GetInfo()
        {
            return base.GetInfo() + "\n" +
                   "расстояние от солнца: " + this.DistanceFromSun.ToString("N1") + " млн км\n" +
                   "тип: планета";
        }
    }
}