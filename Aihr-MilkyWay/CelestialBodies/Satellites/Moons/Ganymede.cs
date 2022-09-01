using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Ganymede : Moon
{
    public Ganymede()
    {
        Name = "Ganymede";
        BodyMass = Mass.Init(14.8, 22);
        DistanceFromParent = 1_070_00;
        Diameter = 5_262;
        OrbitalPeriodDays = OrbitalPeriod.FromHours(172);
    }
}