using Entities;

namespace Services
{
    public interface ICarService
    {
        // Liste des voitures grace a CarService
        IEnumerable<CarEntity> GetAllCars();
        void DeleteCar(int id);
        void UpdateCar(CarEntity car);
        // Liste des voitures par id
        CarEntity GetCarById(int id);
        // Liste des voitures par couleur
        IEnumerable<CarEntity> GetCarsByColor(string color);
        // Liste des voitures par marque
        IEnumerable<CarEntity> GetCarsByBrand(string brand);
        // Liste des voitures par modèle
        IEnumerable<CarEntity> GetCarsByModel(string model);
        // Liste des voitures disponibles
        IEnumerable<CarEntity> GetAvailableCars();
        // Liste des voitures ayant moins de 1000 km
        IEnumerable<CarEntity> GetCarsWithLessThan1000Km();
        // Liste des voitures rouges
        IEnumerable<CarEntity> GetRedCars();
    }
}