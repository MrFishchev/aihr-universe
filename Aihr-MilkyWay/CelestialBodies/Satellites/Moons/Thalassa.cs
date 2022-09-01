using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class Thalassa : Moon
{
    public Thalassa()
    {
        Name = "Thalassa";
        BodyMass = Mass.Init(3.7, 17);
        DistanceFromParent = 50_000;
        Diameter = 80;
        OrbitalPeriodDays = OrbitalPeriod.FromHours(7);
    }
}