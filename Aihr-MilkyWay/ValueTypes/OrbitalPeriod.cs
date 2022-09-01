using System.Diagnostics.CodeAnalysis;

namespace Aihr_MilkyWay;

/// <summary>
/// Represents the value type of int representation of orbital period in days
/// </summary>
public struct OrbitalPeriod
{
    private float _days;

    public float Days => _days;

    /// <summary>
    /// Defines orbital period by years
    /// </summary>
    /// <param name="years"></param>
    /// <returns></returns>
    public static OrbitalPeriod FromYears(int years)
    {
        return FromDays(years * 365);
    }
    
    /// <summary>
    /// Defines orbital period by days
    /// </summary>
    /// <param name="days"></param>
    /// <returns></returns>
    public static OrbitalPeriod FromDays(int days)
    {
        return new OrbitalPeriod
        {
            _days = days
        };
    }

    /// <summary>
    /// Defines orbital period by hours
    /// </summary>
    /// <param name="hours"></param>
    /// <returns></returns>
    [SuppressMessage("ReSharper", "PossibleLossOfFraction")]
    public static OrbitalPeriod FromHours(int hours)
    {
        return new OrbitalPeriod
        {
            _days = hours / 24f
        };
    }
}