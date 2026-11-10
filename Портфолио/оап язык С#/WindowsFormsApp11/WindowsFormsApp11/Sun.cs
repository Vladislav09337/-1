namespace SolarSystemGuide
{
    public class Sun : SpaceObject
    {
        public double Temperature { get; set; }

        public Sun() : base() { }

        public Sun(string name, double mass, double radius, double temperature)
            : base(name, mass, radius)
        {
            Temperature = temperature;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"\nТемпература: {Temperature} K";
        }
    }
}