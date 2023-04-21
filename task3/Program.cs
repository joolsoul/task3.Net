// 6. Создать объект класса Звездная система, используя классы Планета, Звезда, Луна. 
// Методы: вывести количество планет в звездной системе, название звезды, добавление планеты в систему.

using task3.impl;
using task3.impl.jupiter;
using task3.impl.mars;
using task3.impl.neptune;
using task3.impl.saturn;
using task3.impl.uranium;
using task3.impl.venus;

namespace task3;


class Program
{
    static void Main(string[] args)
    {
        Star sun = new Sun();
        
        Planet mercury = new Mercury(sun);
        
        Planet venus = new Venus(sun);
        
        Planet earth = new Earth(sun);
        Satellite moon = new Moon(earth);
        
        Planet mars = new Mars(sun);
        Satellite phobos = new Phobos(mars);
        Satellite deimos = new Deimos(mars);

        Planet jupiter = new Jupiter(sun);
        Satellite io = new Io(jupiter);
        Satellite europe = new Europe(jupiter);
        Satellite ganymede = new Ganymede(jupiter);
        Satellite callisto = new Callisto(jupiter);

        Planet saturn = new Saturn(sun);
        Satellite iapetus = new Iapetus(saturn);
        Satellite titan = new Titan(saturn);
        
        Planet uranium = new Uranium(sun);
        Satellite arielle = new Arielle(uranium);
        Satellite miranda = new Miranda(uranium);
        Satellite oberon = new Oberon(uranium);
        
        Planet neptune = new Neptune(sun);
        Satellite nereid = new Nereid(neptune);
        Satellite proteus = new Proteus(neptune);
        Satellite triton = new Triton(neptune);
        
        var starSystem = new StarSystem(sun);
        starSystem.toString();
    }
}