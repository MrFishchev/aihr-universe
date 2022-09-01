using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Hiiaka : Moon
{
    public Hiiaka()
    {
        Name = "Hiʻiaka";
        BodyMass = Mass.Init(1.79, 19);
        DistanceFromParent = 49_880;
        Diameter = 320;
        OrbitalPeriodDays = OrbitalPeriod.FromYears(284);
    }
}