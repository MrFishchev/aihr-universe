using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class S2015 : Moon
{
    public S2015()
    {
        Name = "S/2015 (136472) 1";
        DistanceFromParent = 21_000;
        Diameter = 175;
        OrbitalPeriodDays = OrbitalPeriod.FromDays(12);
    }
}