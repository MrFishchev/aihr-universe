using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Phobos : Moon
{
    public Phobos()
    {
        Name = "Phobos";
        BodyMass = Mass.Init(1.065, 16);
        DistanceFromParent = 9_380;
        Diameter = 22_533;
        OrbitalPeriodDays = OrbitalPeriod.FromHours(8);
    }
}