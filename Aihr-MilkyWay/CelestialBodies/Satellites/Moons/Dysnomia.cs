using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Dysnomia : Moon
{
    public Dysnomia()
    {
        Name = "Dysnomia";
        BodyMass = Mass.Init(0.143, 21);
        DistanceFromParent = 37_273;
        Diameter = 700;
        OrbitalPeriodDays = OrbitalPeriod.FromDays(15);
    }
}