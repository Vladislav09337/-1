namespace SolarSystemGuide
{
    public class Moon : SpaceObject
    {
        public Planet ParentPlanet { get; set; }
        public double DistanceFromPlanet { get; set; }

        public Moon() : base() { }

        public Moon(string name, double mass, double radius, Planet parentPlanet, double distanceFromPlanet)
            : base(name, mass, radius)
        {
            ParentPlanet = parentPlanet;
            DistanceFromPlanet = distanceFromPlanet;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"\nРодительская планета: {ParentPlanet.Name}\nРасстояние от планеты: {DistanceFromPlanet} тыс км";
        }
    }
}
