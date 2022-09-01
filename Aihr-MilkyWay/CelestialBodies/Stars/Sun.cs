using Aihr_MilkyWay.CelestialBodies.Types;

namespace Aihr_MilkyWay.CelestialBodies.Stars;

public class Sun : Star
{
    public Sun()
    {
        Name = "Sun";
        StarType = "G2V";
        BodyMass = Mass.Init(1.988, 30);
        Diameter = 1_392_700;
        OrbitalPeriodDays = OrbitalPeriod.FromYears(240_000_000);
    }
}