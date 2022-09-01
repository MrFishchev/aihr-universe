using Aihr_MilkyWay.CelestialBodies.Satellites.Moons;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;
using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Planets;

public class Jupiter : GasGiant
{
    public Jupiter()
    {
        Name = "Jupiter";
        BodyMass = Mass.Init(1.9, 27);
        DistanceFromSun = 778_330_000;
        Diameter = 142_984;
        OrbitalPeriodDays = OrbitalPeriod.FromYears(12);
        Satellites = new List<Satellite>
        {
            new Io(),
            new Europa(),
            new Ganymede(),
            new Callisto()
        };
    }
}