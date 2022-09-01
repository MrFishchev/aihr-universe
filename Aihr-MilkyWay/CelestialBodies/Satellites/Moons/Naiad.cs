using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Naiad : Moon
{
    public Naiad()
    {
        Name = "Naiad";
        BodyMass = Mass.Init(1.9, 17);
        DistanceFromParent = 48_000;
        Diameter = 60;
        OrbitalPeriodDays = OrbitalPeriod.FromHours(7);
    }
}