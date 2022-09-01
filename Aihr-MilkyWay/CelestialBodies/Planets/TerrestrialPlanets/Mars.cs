using Aihr_MilkyWay.CelestialBodies.Satellites.Moons;
using Aihr_MilkyWay.CelestialBodies.Types;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;
using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Planets;

public class Mars : TerrestrialPlanet, ITerraformed, ILifeSustainable
{
    public Mars()
    {
        Name = "Mars";
        BodyMass = Mass.Init(6.421, 23);
        DistanceFromSun = 227_940_000;
        Diameter = 6_794;
        OrbitalPeriodDays = OrbitalPeriod.FromDays(687);
        Satellites = new List<Satellite>
        {
            new Phobos(),
            new Deimos()
        };
    }
}