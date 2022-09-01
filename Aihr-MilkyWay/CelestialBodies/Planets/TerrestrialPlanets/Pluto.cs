using Aihr_MilkyWay.CelestialBodies.Satellites.Moons;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;
using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Planets;

public class Pluto : DwarfPlanet
{
    public Pluto()
    {
        Name = "Pluto";
        BodyMass = Mass.Init(1.27, 22);
        DistanceFromSun = 5_913_520_000;
        Diameter = 2_274;
        OrbitalPeriodDays = OrbitalPeriod.FromYears(248);
        Satellites = new List<Satellite> { new Charon(), new Styx() };
    }
}