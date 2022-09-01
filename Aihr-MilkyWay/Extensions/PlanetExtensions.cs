using Aihr_MilkyWay.CelestialBodies.Types;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;
using Aihr_MilkyWay.CelestialBodies.Types.Satellites;

namespace Aihr_MilkyWay.Extensions;

public static class PlanetExtensions
{
    /// <summary>
    /// Converts type of planet into string representation (violates OCP)
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string GetPlanetType(this Planet obj)
    {
        return obj switch
        {
            TerrestrialPlanet _ => "Terrestrial Planet",
            DwarfPlanet _ => "Dwarf Planet",
            GasGiant _ => "Gas Giant",
            IceGiant _ => "Ice Giant",
            _ => "unknown"
        };
    }

    /// <summary>
    /// Indicates if the planet has some moons
    /// </summary>
    /// <param name="obj">Any planet</param>
    /// <returns></returns>
    public static bool HasSatelliteMoons(this Planet obj)
    {
        return obj.Satellites?.OfType<Moon>().Any() ?? false;
    }

    /// <summary>
    /// Colonizes the planet if possible (violates SRP)
    /// </summary>
    /// <param name="obj"></param>
    public static void Colonize(this Planet obj)
    {
        if (obj is ITerraformed and ILifeSustainable && obj.HasSatelliteMoons())
        {
            // violation of SRP, better to have CanColonize and logic in a different place
            Console.WriteLine($"{obj.Name} has been colonized!");
        }
    }
}