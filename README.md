# Aihr Universe

The project shows, how to organise `SolarSystem` structure.

> **Note!** <br/>
> Some of the task's requirements I decided to implement in my own way, I put them into `Assumptions` section. 

## Get Started
1. Open the solution and press Run (tested with Rider).
2. You will see all the necessary structure in a console.

> Warning! <br/>
> Not the whole information is printed in a console.

## Assumptions

| Topic               | Comment                                                                                                                                                                                                                                       |
|---------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Celestial Bodies    | Not all the types are presented: Stars, Planets, Satellites, DwarfPlanets only. There are no Comets, Asteroids, and Meteors.                                                                                                                  |
| Satellites          | In a context of this project - it's a natural object of Solar System, which are not made by human (e.g. only Moons are here).                                                                                                                 |
| Satellites Limit    | Maximum amount of satellites for any object is 2 (sorry, but too much googling for parameters).                                                                                                                                               |
| Terraformed Bodies  | In a context of this project I didn't put `ITerraformed` interface to any satellite, only for planets, no sense to do it, no logic in the requirements.                                                                                       |
| Orbital Period      | Represents days without too specific hours (e.g. 0.25 days, not like 0.234141251 days), if you are interested how I work with big numbers, look at the `Mass` class.                                                                          |
| Linked Objects      | Now I have one-directional linked list (`Planet -> Satellite`), but better to have `Planet <-> Satellite` that will allow any Satellite to find its planet.                                                                                   |
| Nullable Properties | There are `nullable` or `open to be set` properties, as we have missing information for some of the celestial bodies, or even we not fully opened amount of planets in the system (e.g. Planet X)                                             |
| Distances           | Better to have not a distance between Sun and Object, or Parent and Object, but a coordinates to calculate vector if needed                                                                                                                   |
| Colonize            | Better do not have any logic in extension methods, instead we need to `CanColonize` method and move all the business logic to a separate `Colonizer` service (but it too many time already here), see `SRP - Single Responsibility Principle` |

> **Perfect === Good Enough**

> **Note!** <br/>
> _Implement an interface for all celestial bodies that "**Can sustain life**", "**Can be terraformed**", and "**Has satellite moon(s)**" and an extension method named Colonize()_.

There is no sense to implement these interfaces for all the Celestial Bodies, much better to add it to specific objects, like Mars or Venus.
Also, `HasSatelliteMoons` interface will violate `OCP - Open-Closed Principle`, so I decided to do extension method, that will work without manual changes in case of adding new celestial bodies 👍.

````
ILifeSustainable - Can sustainn life interface
ITerraformed - Can be terraformed (yeah yeah, thats, difficult to follow correct names)
HasSatellitesMoons - Extension method for Planet type.
````
