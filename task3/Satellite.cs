using System.Text;

namespace task3;

public class Satellite : CelestialObject
{
    public Satellite(string name, double weight, double radius, Planet planet) : base(name, weight, radius)
    {
        Planet = planet;
        planet.AddSatellite(this);
    }

    private Planet _planet;

    public Planet Planet
    {
        get => _planet; 
        set => _planet = value;
    }

    public override String ToString(int level)
    {
        string tab = new String('\t', level);
        var sb = new StringBuilder();
        sb.Append('\n').Append('\n').Append(tab).Append($"Satellite {Name}: \n").Append(tab)
        .Append($"-Weight: {Weight}*10^22 kg\n").Append(tab)
        .Append($"-Radius: {Radius} km");

        return sb.ToString();
    }
}