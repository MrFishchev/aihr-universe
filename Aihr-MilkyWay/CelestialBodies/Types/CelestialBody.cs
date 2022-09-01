namespace Aihr_MilkyWay.CelestialBodies.Types;

/// <summary>
/// Base class for any object in open space of Solar System
/// </summary>
public class CelestialBody
{
    public string Name { get; protected init; } = null!;

    /// <summary>
    /// Url to a body's picture
    /// </summary>
    public string? Picture { get; set; }

    public OrbitalPeriod? OrbitalPeriodDays { get; init; }

    public Mass? BodyMass { get; set; }

    /// <summary>
    /// Diameter of an object in kilometers
    /// </summary>
    public double? Diameter { get; set; }
    
    /// <summary>
    /// Distance between object and sun in kilometers
    /// </summary>
    public long? DistanceFromSun { get; set; }
}