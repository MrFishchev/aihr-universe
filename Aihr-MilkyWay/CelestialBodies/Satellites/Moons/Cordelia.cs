using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Cordelia : Moon
{
    public Cordelia()
    {
        Name = "Cordelia";
        BodyMass = Mass.Init(44, 15);
        DistanceFromParent = 49_800;
        Diameter = 40;
        OrbitalPeriodDays = OrbitalPeriod.FromHours(8);
    }
}