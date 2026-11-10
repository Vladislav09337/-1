using System.Collections.Generic;

namespace SolarSystemGuide
{
    public class Planet : SpaceObject
    {
        public double DistanceFromSun { get; set; }
        public List<Moon> Moons { get; set; }

        public Planet() : base()
        {
            Moons = new List<Moon>();
        }

        public Planet(string name, double mass, double radius, double distanceFromSun)
            : base(name, mass, radius)
        {
            DistanceFromSun = distanceFromSun;
            Moons = new List<Moon>();
        }

        public void AddMoon(Moon moon)
        {
            Moons.Add(moon);
        }

        public override string GetInfo()
        {
            string moonsInfo = "";
            if (Moons.Count > 0)
            {
                moonsInfo = "\nСпутники: ";
                for (int i = 0; i < Moons.Count; i++)
                {
                    moonsInfo += Moons[i].Name;
                    if (i < Moons.Count - 1) moonsInfo += ", ";
                }
            }
            else
            {
                moonsInfo = "\nСпутников нет";
            }

            return base.GetInfo() + $"\nРасстояние от Солнца: {DistanceFromSun} млн км" + moonsInfo;
        }
    }
}