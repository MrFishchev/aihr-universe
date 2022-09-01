using System.Globalization;
using Aihr_MilkyWay;
using Aihr_MilkyWay.Extensions;

var solarSystem = new SolarSystem();

Console.WriteLine("Solar System Overview:");
Console.WriteLine($"Star: {solarSystem.Star.Name} - {solarSystem.Star.StarType}");
Console.WriteLine($"Planets: {solarSystem.Planets.Count}");
foreach (var planet in solarSystem.Planets)
{
    Console.WriteLine($"\t{planet.Name} - {planet.GetPlanetType()} - {planet.OrbitalPeriodDays!.Value.Days} opd");
    if (planet.Satellites != null)
    {
        foreach (var satellite in planet.Satellites)
        {
            string opd = satellite.OrbitalPeriodDays == null
                ? "NaN"
                : satellite.OrbitalPeriodDays.Value.Days.ToString(CultureInfo.InvariantCulture);
        
            Console.WriteLine(
                $"\t\t{satellite.Name} - {satellite.DistanceFromParent} dfp - {opd} opd");
        }
    }
}
Console.WriteLine("* dfp - distance from parent");
Console.WriteLine("* opd - orbital period in days");
Console.WriteLine();

Console.WriteLine("Searching for planets to be colonized...");
solarSystem.Planets.ForEach(x=> x.Colonize());