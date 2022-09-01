using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Mimas : Moon
{
    public Mimas()
    {
        Name = "Mimas";
        BodyMass = Mass.Init(3.8, 19);
        DistanceFromParent = 185_520;
        Diameter = 390;
        OrbitalPeriodDays = OrbitalPeriod.FromHours(23);
    }
}