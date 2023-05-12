using System.Text;

namespace task3;

public sealed class Star : CelestialObject
{
    public Star(String name, double weight, double radius, double luminosity) : base(name, weight, radius)
    {
        Luminosity = luminosity;
    }
    public Star(String name, double weight, double radius, double luminosity,
        List<Planet> planets) : base(name, weight, radius)
    {
        Luminosity = luminosity;
        Planets = planets;
    }
    
    private double _luminosity;
    private List<Planet> _planets = new List<Planet>();
    
    public double Luminosity
    {
        get => _luminosity; 
        set => _luminosity = value;
    }
    
    public List<Planet> Planets 
    { 
        get => _planets; 
        set => _planets = value; 
    }

    public int PlanetsCount
    {
        get => _planets.Count;
    }
    
    public void AddPlanet(Planet planet)
    {
        _planets.Add(planet);
    }

    public void RemovePlanet(Planet planet)
    {
        _planets.Remove(planet);
    }

    public override String ToString(int level)
    {
        var sb = new StringBuilder("");
        sb.Append('\n').Append($"Star {Name}: \n");
        sb.Append($"-Luminosity: {Luminosity}*10^26 W\n");
        sb.Append($"-Weight: {Weight}*10^30 kg\n");
        sb.Append($"-Radius: {Radius} km\n");
        if (Planets.Count != 0)
        {
            var s = Planets.Count == 1
                ? $"With {Planets.Count} planet: \n"
                : $"With {Planets.Count} planets: \n";
            sb.Append(s);
            
            foreach (var planet in Planets)
            {
                sb.Append(planet.ToString(1)).AppendLine();
            }
        }

        return sb.ToString();
    }
    
}