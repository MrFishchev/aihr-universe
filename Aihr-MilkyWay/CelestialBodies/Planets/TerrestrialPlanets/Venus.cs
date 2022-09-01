using Aihr_MilkyWay.CelestialBodies.Types;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;

namespace Aihr_MilkyWay.CelestialBodies.Planets;

public class Venus : TerrestrialPlanet, ITerraformed, ILifeSustainable
{
    public Venus()
    {
        Name = "Venus";
        BodyMass = Mass.Init(4.869, 24);
        DistanceFromSun = 108_200_000;
        Diameter = 12_103;
        OrbitalPeriodDays = OrbitalPeriod.FromDays(225);
    }
}