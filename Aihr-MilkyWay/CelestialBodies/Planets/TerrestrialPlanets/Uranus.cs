using Aihr_MilkyWay.CelestialBodies.Satellites.Moons;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;
using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Planets;

public class Uranus : IceGiant
{
    public Uranus()
    {
        Name = "Uranus";
        BodyMass = Mass.Init(8.683, 25);
        DistanceFromSun = 2_870_990_000;
        Diameter = 51_118;
        OrbitalPeriodDays = OrbitalPeriod.FromYears(84);
        Satellites = new List<Satellite> { new Cordelia(), new Ophelia() };
    }
}