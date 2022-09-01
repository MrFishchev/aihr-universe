using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Callisto : Moon
{
    public Callisto()
    {
        Name = "Callisto";
        BodyMass = Mass.Init(10.8, 22);
        DistanceFromParent = 1_883_000;
        Diameter = 4_821;
        OrbitalPeriodDays = OrbitalPeriod.FromDays(17);
    }
}