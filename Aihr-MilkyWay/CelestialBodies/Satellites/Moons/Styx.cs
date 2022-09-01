using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Styx : Moon
{
    public Styx()
    {
        Name = "Styx";
        BodyMass = Mass.Init(7.5, 15);
        DistanceFromParent = 42_000;
        Diameter = 25;
        OrbitalPeriodDays = OrbitalPeriod.FromDays(25);
    }
}