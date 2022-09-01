using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Namaka : Moon
{
    public Namaka()
    {
        Name = "Namaka";
        BodyMass = Mass.Init(1.79, 18);
        DistanceFromParent = 25_657;
        Diameter = 170;
        OrbitalPeriodDays = OrbitalPeriod.FromDays(18);
    }
}