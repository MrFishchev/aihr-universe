using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Io : Moon
{
    public Io()
    {
        Name = "Io";
        BodyMass = Mass.Init(8.931, 22);
        DistanceFromParent = 421_600;
        Diameter = 3_643;
        OrbitalPeriodDays = OrbitalPeriod.FromHours(42);
    }
}