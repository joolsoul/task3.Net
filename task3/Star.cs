using System.Text;

namespace task3;

public abstract class Star : CelestialObject
{
    protected Star(String name, double weight, double radius, double luminosity) : base(name, weight, radius)
    {
        Luminosity = luminosity;
    }
    protected Star(String name, double weight, double radius, double luminosity,
        List<Planet> planets) : base(name, weight, radius)
    {
        Luminosity = luminosity;
        Planets = planets;
    }
    
    private double _luminosity;
    private int _planetCount;
    private List<Planet> _planets = new List<Planet>();
    
    public double Luminosity
    {
        get => _luminosity; 
        set => _luminosity = value;
    }

    public int PlanetCount
    {
        get => _planetCount;
    }
    public List<Planet> Planets 
    { 
        get => _planets; 
        set => _planets = value; 
    }
    public void AddPlanet(Planet planet)
    {
        _planets.Add(planet);
        _planetCount++;
    }

    public void RemovePlanet(Planet planet)
    {
        _planets.Remove(planet);
        _planetCount--;
    }

    public override String ToString(int level)
    {
        var sb = new StringBuilder("");
        sb.Append('\n').Append($"Star {Name}: \n");
        sb.Append($"-Luminosity: {Luminosity}*10^26 W\n");
        sb.Append($"-Weight: {Weight}*10^30 kg\n");
        sb.Append($"-Radius: {Radius} km\n");
        if (PlanetCount != 0)
        {
            var s = PlanetCount == 1
                ? $"With {PlanetCount} planet: \n"
                : $"With {PlanetCount} planets: \n";
            sb.Append(s);
            
            foreach (var planet in Planets)
            {
                sb.Append(planet.ToString(1)).AppendLine();
            }
        }

        return sb.ToString();
    }
    
}