using Aihr_MilkyWay.CelestialBodies.Satellites.Moons;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;
using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Planets;

public class Neptune : IceGiant
{
    public Neptune()
    {
        Name = "Neptune";
        BodyMass = Mass.Init(1.024, 26);
        DistanceFromSun = 4_504_000_000;
        Diameter = 49_532;
        OrbitalPeriodDays = OrbitalPeriod.FromYears(165);
        Satellites = new List<Satellite> { new Naiad(), new Thalassa() };
    }
}