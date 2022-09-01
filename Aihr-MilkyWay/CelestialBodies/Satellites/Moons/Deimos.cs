using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Deimos : Moon
{
    public Deimos()
    {
        Name = "Deimos";
        BodyMass = Mass.Init(1.476, 15);
        DistanceFromParent = 23_460;
        Diameter = 12.4;
        OrbitalPeriodDays = OrbitalPeriod.FromHours(30);
    }
}