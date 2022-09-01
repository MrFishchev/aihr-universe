using Aihr_MilkyWay.CelestialBodies.Types;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;

namespace Aihr_MilkyWay.CelestialBodies.Planets;

public class Mercury : TerrestrialPlanet, ITerraformed
{
    public Mercury()
    {
        Name = "Mercury";
        BodyMass = Mass.Init(3.30, 23);
        DistanceFromSun = 57_910_000;
        Diameter = 4_880;
        OrbitalPeriodDays = OrbitalPeriod.FromDays(88);
    }
}