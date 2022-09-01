namespace Aihr_MilkyWay.CelestialBodies.Satellites.Moons;

public class EarthMoon : Types.Satellites.Moon
{
    public EarthMoon()
    {
        Name = "Moon";
        BodyMass = Mass.Init(7.342, 22);
        DistanceFromParent = 384_399;
        Diameter = 3_474;
        OrbitalPeriodDays = OrbitalPeriod.FromDays(27);
    }
}