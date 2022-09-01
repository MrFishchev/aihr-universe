namespace Aihr_MilkyWay.CelestialBodies.Types.Satellites;

/// <summary>
/// Base class for any Satellite (e.g. Moons, Asteroid, HumanMadeThings)
/// </summary>
public class Satellite : CelestialBody
{
    public long? DistanceFromParent { get; set; }
}