using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controllers;
[Route("[controller]")]
public class CarController : ControllerBase
{
    private readonly ILogger<CarController> _logger;
    private readonly ICarService _carService;

    public CarController(ILogger<CarController> logger, ICarService carService)
    {
        _logger = logger;
        _carService = carService;
    }

    // Liste des voitures
    [HttpGet]
    public IEnumerable<CarEntity> GetAllCars()
    {
        return _carService.GetAllCars();
    }
    // Liste des voitures par id
    [HttpGet("{id}")]
    public CarEntity GetCarById(int id)
    {
        return _carService.GetCarById(id);
    }
    // Supprimer une voiture
    [HttpDelete("{id}")]
    public void DeleteCar(int id)
    {
        _carService.DeleteCar(id);
    }
    // Mettre à jour une voiture
    [HttpPut]
    public void UpdateCar(CarEntity car)
    {
        _carService.UpdateCar(car);
    }
    // Liste des voitures par couleur
    [HttpGet("color/{color}")]
    public IEnumerable<CarEntity> GetCarsByColor(string color)
    {
        return _carService.GetCarsByColor(color);
    }
    // Liste des voitures par marque
    [HttpGet("brand/{brand}")]
    public IEnumerable<CarEntity> GetCarsByBrand(string brand)
    {
        return _carService.GetCarsByBrand(brand);
    }
    // Liste des voitures par modèle
    [HttpGet("model/{model}")]
    public IEnumerable<CarEntity> GetCarsByModel(string model)
    {
        return _carService.GetCarsByModel(model);
    }
    // Liste des voitures disponibles
    [HttpGet("available")]
    public IEnumerable<CarEntity> GetAvailableCars()
    {
        return _carService.GetAvailableCars();
    }
    // Liste des voitures ayant moins de 1000 km
    [HttpGet("lessThan1000Km")]
    public IEnumerable<CarEntity> GetCarsWithLessThan1000Km()
    {
        return _carService.GetCarsWithLessThan1000Km();
    }
    // Liste des voitures rouges
    [HttpGet("red")]
    public IEnumerable<CarEntity> GetRedCars()
    {
        return _carService.GetRedCars();
    }
}

