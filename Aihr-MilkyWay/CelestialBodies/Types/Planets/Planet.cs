using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.CelestialBodies.Types.Planets;

/// <summary>
/// Base class for any type of Planet
/// </summary>
public class Planet : CelestialBody
{
    // Aggregation: when Planet dies its Satellites may live
    public List<Satellite>? Satellites { get; set; }
}