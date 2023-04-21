using System.Text;

namespace task3;

public abstract class Planet : CelestialObject
{
    protected Planet(string name, double weight, double radius,
        Star star, double orbitRadius, double orbitalSpeed, double axisSpeed) : base(name, weight, radius)
    {
        OrbitRadius = orbitRadius;
        OrbitalSpeed = orbitalSpeed;
        AxisSpeed = axisSpeed;
        Star = star;
        star.AddPlanet(this);
    }
    
    protected Planet(string name, double weight, double radius,
        Star star, double orbitRadius, double orbitalSpeed, double axisSpeed, 
        List<Satellite> satellites) : base(name, weight, radius)
    {
        OrbitRadius = orbitRadius;
        OrbitalSpeed = orbitalSpeed;
        AxisSpeed = axisSpeed;
        Satellites = satellites;
        Star = star;
        star.AddPlanet(this);
    }

    private Star _star;
    private double _orbitRadius;
    private double _orbitalSpeed;
    private double _axisSpeed;
    private List<Satellite> _satellites = new List<Satellite>();

    public Star Star
    {
        get => _star;
        set => _star = value;
    }

    public double OrbitRadius
    {
        get => _orbitRadius;
        set => _orbitRadius = value;
    }

    public double OrbitalSpeed
    {
        get => _orbitalSpeed;
        set => _orbitalSpeed = value;
    }

    public double AxisSpeed
    {
        get => _axisSpeed;
        set => _axisSpeed = value;
    }

    public List<Satellite> Satellites
    {
        get => _satellites;
        set => _satellites = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void AddSatellite(Satellite satellite)
    {
        _satellites.Add(satellite);
    }

    public void RemoveSatellite(Satellite satellite)
    {
        _satellites.Remove(satellite);
    }

    public override String ToString(int level)
    {
        string tab = new String('\t', level);
        var sb = new StringBuilder();
        sb.Append('\n').Append('\n').Append(tab).Append($"Planet {Name}: \n").Append(tab)
        .Append($"-Weight: {Weight}*10^23 kg\n").Append(tab)
        .Append($"-Radius: {Radius} km\n").Append(tab)
        .Append($"-Orbit radius: {OrbitRadius} au\n").Append(tab)
        .Append($"-Orbital speed: {OrbitalSpeed} km/s\n").Append(tab)
        .Append($"-Axis speed: {AxisSpeed} m/s");
        if (Satellites.Count != 0)
        {
            var s = Satellites.Count == 1
                ? $"With {Satellites.Count} satellite:"
                : $"With {Satellites.Count} satellites:";
           sb.Append('\n').Append(tab).Append(s);
                    
                    foreach (var satellite in Satellites)
                    {
                        sb.Append(satellite.ToString(2));
                    }
        }
        

        return sb.ToString();
    }
}