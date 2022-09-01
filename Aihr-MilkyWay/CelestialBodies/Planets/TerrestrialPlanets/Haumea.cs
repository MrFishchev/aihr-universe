using Aihr_MilkyWay.CelestialBodies.Satellites.Moons;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;
using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Planets;

public class Haumea : DwarfPlanet
{
    public Haumea()
    {
        Name = "Haumea";
        BodyMass = Mass.Init(4.046, 21);
        DistanceFromSun = 6_452_000_000;
        Diameter = 1_632;
        OrbitalPeriodDays = OrbitalPeriod.FromYears(284);
        Satellites = new List<Satellite> { new Namaka(), new Hiiaka() };
    }
}