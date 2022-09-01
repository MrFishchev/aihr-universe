using Aihr_MilkyWay.CelestialBodies.Satellites.Moons;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;
using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Planets;

public class Saturn : GasGiant
{
    public Saturn()
    {
        Name = "Saturn";
        BodyMass = Mass.Init(5.68, 26);
        DistanceFromSun = 1_429_400_000;
        Diameter = 120_536;
        OrbitalPeriodDays = OrbitalPeriod.FromYears(29);
        Satellites = new List<Satellite> { new Mimas(), new Enceladus() };
    }
}