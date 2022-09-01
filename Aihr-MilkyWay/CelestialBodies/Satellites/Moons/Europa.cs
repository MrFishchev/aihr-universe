using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Europa : Moon
{
    public Europa()
    {
        Name = "Europa";
        BodyMass = Mass.Init(4.799, 22);
        DistanceFromParent = 670_900;
        Diameter = 3_126;
        OrbitalPeriodDays = OrbitalPeriod.FromHours(85);
    }
}