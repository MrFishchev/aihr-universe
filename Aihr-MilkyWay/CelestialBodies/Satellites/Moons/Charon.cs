using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Charon : Moon
{
    public Charon()
    {
        Name = "Charon";
        BodyMass = Mass.Init(1.58, 21);
        DistanceFromParent = 17_536;
        Diameter = 1_212;
        OrbitalPeriodDays = OrbitalPeriod.FromHours(153);
    }
}