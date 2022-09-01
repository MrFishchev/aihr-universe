using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Ophelia : Moon
{
    public Ophelia()
    {
        Name = "Ophelia";
        BodyMass = Mass.Init(53, 15);
        DistanceFromParent = 53_800;
        Diameter = 43;
        OrbitalPeriodDays = OrbitalPeriod.FromHours(9);
    }
}