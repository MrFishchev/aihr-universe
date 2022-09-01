using Aihr_MilkyWay.CelestialBodies.Satellites.Moons;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;
using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Planets;

public class Earth : TerrestrialPlanet
{
    public Earth()
    {
        Name = "Earth";
        BodyMass = Mass.Init(5.972, 24);
        DistanceFromSun = 149_600_000;
        Diameter = 12_756;
        OrbitalPeriodDays = OrbitalPeriod.FromDays(365);
        Satellites = new List<Satellite> { new EarthMoon() };
    }
}