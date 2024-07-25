using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;
using Repositories;

namespace Services
{
    public class CarService : ICarService
    {
        private readonly CarRepository _carRepository;

        public CarService(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        // Liste des voitures
        public IEnumerable<CarEntity> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }
        // Liste des voitures par id
        public CarEntity GetCarById(int id)
        {
            return _carRepository.GetCarById(id);
        }
        // Supprimer une voiture
        public void DeleteCar(int id)
        {
            _carRepository.DeleteCar(id);
        }
        // Mettre à jour une voiture
        public void UpdateCar(CarEntity car)
        {
            _carRepository.UpdateCar(car);
        }
        // Liste des voitures par couleur
        public IEnumerable<CarEntity> GetCarsByColor(string color)
        {
            return _carRepository.GetAllCars().Where(c => c.Color == color);
        }
        // Liste des voitures par marque
        public IEnumerable<CarEntity> GetCarsByBrand(string brand)
        {
            return _carRepository.GetAllCars().Where(c => c.Brand == brand);
        }
        // Liste des voitures par modèle
        public IEnumerable<CarEntity> GetCarsByModel(string model)
        {
            return _carRepository.GetAllCars().Where(c => c.Type == model);
        }
        // Liste des voitures disponibles
        public IEnumerable<CarEntity> GetAvailableCars()
        {
            return _carRepository.GetAllCars().Where(c => c.CarRental == null);
        }
        // Liste des voitures ayant moins de 1000 km
        public IEnumerable<CarEntity> GetCarsWithLessThan1000Km()
        {
            return _carRepository.GetAllCars().Where(c => c.AmountOfKm < 1000);
        }
        // Liste des voitures rouges
        public IEnumerable<CarEntity> GetRedCars()
        {
            return _carRepository.GetAllCars().Where(c => c.Color == "Red");
        }

    }
}