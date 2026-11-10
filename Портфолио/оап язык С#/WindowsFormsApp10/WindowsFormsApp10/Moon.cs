using System.Drawing;

namespace SolarSystemReference
{
    // класс спутник, наследуется от celestialbody
    public class Moon : CelestialBody
    {
        public double DistanceFromParent { get; set; }
        public Planet ParentPlanet { get; set; }

        // конструктор
        public Moon(string name, Image photo, double mass, double radius,
                    double distanceFromParent, Planet parentPlanet)
            : base(name, photo, mass, radius)
        {
            this.DistanceFromParent = distanceFromParent;
            this.ParentPlanet = parentPlanet;
        }

        // переопределяем метод getinfo, добавляем родительскую планету и расстояние до нее
        public override string GetInfo()
        {
            return base.GetInfo() + "\n" +
                   "родительская планета: " + this.ParentPlanet.Name + "\n" +
                   "расстояние от планеты: " + this.DistanceFromParent.ToString("N3") + " млн км\n" +
                   "тип: спутник";
        }
    }
}