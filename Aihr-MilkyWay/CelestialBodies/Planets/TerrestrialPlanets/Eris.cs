using Aihr_MilkyWay.CelestialBodies.Satellites.Moons;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;
using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Planets;

public class Eris : DwarfPlanet
{
    public Eris()
    {
        Name = "Eris";
        BodyMass = Mass.Init(1.67, 22);
        DistanceFromSun = 10_125_000_000;
        Diameter = 2_326;
        OrbitalPeriodDays = OrbitalPeriod.FromYears(558);
        Satellites = new List<Satellite> { new Dysnomia() };
    }
}