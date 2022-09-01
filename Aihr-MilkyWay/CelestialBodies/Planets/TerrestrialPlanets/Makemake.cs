using Aihr_MilkyWay.CelestialBodies.Satellites.Moons;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;
using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Planets;

public class Makemake : DwarfPlanet
{
    public Makemake()
    {
        Name = "Makemake";
        BodyMass = Mass.Init(3.1, 21);
        DistanceFromSun = 6_847_000_000;
        Diameter = 1_430;
        OrbitalPeriodDays = OrbitalPeriod.FromYears(306);
        Satellites = new List<Satellite> { new S2015() };
    }
}