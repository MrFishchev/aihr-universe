using Aihr_MilkyWay.CelestialBodies.Types.Planets;

namespace Aihr_MilkyWay.CelestialBodies.Planets;

public class Ceres : DwarfPlanet
{
    public Ceres()
    {
        Name = "Ceres";
        BodyMass = Mass.Init(9.1, 20);
        DistanceFromSun = 413_000_000;
        Diameter = 946;
        OrbitalPeriodDays = OrbitalPeriod.FromYears(1682);
    }
}