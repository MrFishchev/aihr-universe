namespace Aihr_MilkyWay;

/// <summary>
/// Represents the value type of string representation of too big numbers (e.g. from 10^19)
/// </summary>
public struct Mass
{
    private double _bodyMass;

    public double BodyMass => _bodyMass;

    /// <summary>
    /// Creates value type of <see cref="Mass"/> with selected pow (e.g. 2,1 x 10^17)
    /// </summary>
    /// <param name="baseNumber">Base value of mass</param>
    /// <param name="pow">Pow that you need to put on (e.g. 10^pow)</param>
    /// <returns></returns>
    public static Mass Init(double baseNumber, int pow)
    {
        return new Mass
        {
            _bodyMass = baseNumber * Math.Pow(10, pow)
        };
    }
}