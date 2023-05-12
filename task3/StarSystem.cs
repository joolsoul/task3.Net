namespace task3;

public class StarSystem
{
    private Star star;

    public StarSystem(Star star)
    {
        this.star = star;
    }

    public Star Star
    {
        get => star;
        set => star = value;
    }

    public void addPlanet(Planet planet)
    {
        star.AddPlanet(planet);
    }
    
    public void removePlanet(Planet planet)
    {
        star.RemovePlanet(planet);
    }

    public String getStarName()
    {
        return star.Name;
    }

    public int getPlanetCount()
    {
        return star.PlanetsCount;
    }

    public void toString()
    {
        Console.WriteLine($"System with star name: {getStarName()}\n");
        Console.WriteLine(star.ToString(0));
    }
    
}