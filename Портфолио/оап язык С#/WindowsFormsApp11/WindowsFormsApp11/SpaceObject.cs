namespace SolarSystemGuide
{
    public class SpaceObject
    {
        public string Name { get; set; }
        public double Mass { get; set; }
        public double Radius { get; set; }

        public SpaceObject() { }

        public SpaceObject(string name, double mass, double radius)
        {
            Name = name;
            Mass = mass;
            Radius = radius;
        }

        public virtual string GetInfo()
        {
            return $"Название: {Name}\nМасса: {Mass} кг\nРадиус: {Radius} км";
        }
    }
}