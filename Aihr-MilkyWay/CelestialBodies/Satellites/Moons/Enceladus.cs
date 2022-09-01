using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Enceladus : Moon
{
    public Enceladus()
    {
        Name = "Enceladus";
        BodyMass = Mass.Init(1.08, 20);
        DistanceFromParent = 238_020;
        Diameter = 500;
        OrbitalPeriodDays = OrbitalPeriod.FromHours(33);
    }
}