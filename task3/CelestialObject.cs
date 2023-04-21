namespace task3;

public abstract class CelestialObject
{
    protected CelestialObject(String name, double weight, double radius)
    {
        Name = name;
        Weight = weight;
        Radius = radius;
    }

    private double _weight;
    private double _radius;
    private String _name;

    public double Weight
    {
        get => _weight; 
        set => _weight = value;
    }

    public double Radius
    {
        get => _radius; 
        set => _radius = value;
    }

    public String Name
    {
        get => _name; 
        set => _name = value;
    }
    
    public abstract String ToString(int level);
    
}