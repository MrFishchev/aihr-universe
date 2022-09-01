using Aihr_MilkyWay.CelestialBodies.Planets;
using Aihr_MilkyWay.CelestialBodies.Stars;
using Aihr_MilkyWay.CelestialBodies.Types;
using Aihr_MilkyWay.CelestialBodies.Types.Planets;
using Aihr_MilkyWay.Utils;

namespace Aihr_MilkyWay;

public class SolarSystem
{
    // Composition: if SolarSystem will die, all the bodies will die as well
    private readonly List<CelestialBody> _celestialBodies = new();
    
    public List<CelestialBody> CelestialBodies => _celestialBodies;
    
    public Star Star { get; }
    
    public List<Planet> Planets { get; }
    
    public List<TerrestrialPlanet> TerrestrialPlanets { get; }
    
    public SolarSystem()
    {
        InitStars();
        InitPlanetsAndTheirSatellites();
        
        Star = _celestialBodies.OfType<Star>().FirstOrDefault()!;
        
        Planets = _celestialBodies.OfType<Planet>().
            OrderBy(x=> x.OrbitalPeriodDays!.Value.Days)
            .ToList();
        
        TerrestrialPlanets = Planets.OfType<TerrestrialPlanet>().
            OrderBy(x=> x.OrbitalPeriodDays!.Value.Days)
            .ToList();
    }

    private void InitStars()
    {
        _celestialBodies.Add(new Sun());
    }
    
    private void InitPlanetsAndTheirSatellites()
    {
        var planets = AssemblyHelper.InstantiateTypesInSameNamespaceAs<CelestialBody>(typeof(Earth));
        _celestialBodies.AddRange(planets);
    }
}