// 6. Создать объект класса Звездная система, используя классы Планета, Звезда, Луна. 
// Методы: вывести количество планет в звездной системе, название звезды, добавление планеты в систему.

namespace task3;


class Program
{
    static void Main(string[] args)
    {
        Star sun = new Star("Sun", 1.9885, 695000d, 3.828);
       
        
        Planet mercury = new Planet("Mercury", 3.33, 2439.7, sun, 0.4, 47, 3.026);
        
        Planet venus = new Planet("Venus", 48.7, 6051.8, sun, 0.723, 35, 1.811);
        
        Planet earth = new Planet("Earth", 59.7, 6371d, sun, 1d, 29.765, 465);
        Satellite moon = new Satellite("Moon", 7.35, 1737.1, earth);
        
        Planet mars = new Planet("Mars", 6.42, 3389.5, sun, 1.525, 24, 241.172);
        Satellite phobos = new Satellite("Phobos", 0.00000107, 22.4, mars);
        Satellite deimos = new Satellite("Deimos", 0.000000148, 6.2, mars);

        Planet jupiter = new Planet("Jupiter", 190000d, 71492, sun, 5.2, 13, 12600);
        Satellite io = new Satellite("Io", 8.94, 1821.3, jupiter);
        Satellite europe = new Satellite("Europe", 4.8, 1560.8, jupiter);
        Satellite ganymede = new Satellite("Ganymede", 14.8, 2634.1, jupiter);
        Satellite callisto = new Satellite("Callisto", 10.759,  2410.3, jupiter);

        Planet saturn = new Planet("Saturn", 5680, 60268, sun, 9.048, 9.7, 9870);
        Satellite iapetus = new Satellite("Iapetus", 0.000000148, 6.2, saturn);
        Satellite titan = new Satellite("Titan", 0.000000148, 6.2, saturn);
        
        Planet uranium = new Planet("Uranium", 868, 25559, sun, 19.191, 6.8, 2590);
        Satellite arielle = new Satellite("Arielle", 0.000000148, 6.2, uranium);
        Satellite miranda = new Satellite("Miranda", 0.000000148, 6.2, uranium);
        Satellite oberon = new Satellite("Oberon", 0.000000148, 6.2, uranium);
        
        Planet neptune = new Planet("Neptune", 1020, 24764, sun, 19.18, 5.4, 2680);
        Satellite nereid = new Satellite("Nereid", 0.000000148, 6.2, neptune);
        Satellite proteus = new Satellite("Proteus", 0.000000148, 6.2, neptune);
        Satellite triton = new Satellite("Triton", 0.000000148, 6.2, neptune);
        
        var starSystem = new StarSystem(sun);
        
        starSystem.addPlanet(mercury);
        starSystem.addPlanet(venus);
        starSystem.addPlanet(earth);
        starSystem.addPlanet(mars);
        starSystem.addPlanet(jupiter);
        starSystem.addPlanet(saturn);
        starSystem.addPlanet(uranium);
        starSystem.addPlanet(neptune);
        
        starSystem.toString();
    }
}