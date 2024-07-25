using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories 
{
    public class CarRepository : ICarRepository
    {
        // Add a private readonly field for the DbContext
        private readonly RentCarDbContext _dbContext;

        // Add a constructor that accepts the DbContext
        public CarRepository(RentCarDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddCar(CarEntity car)
        {
            //Réalise l'ajout d'une voiture
            _dbContext.Cars.Add(car);
        }

        public void DeleteCar(int id)
        {
            //Réalise la suppression d'une voiture
            var car = _dbContext.Cars.Find(id);
        }

        public IEnumerable<CarEntity> GetAllCars()
        {
            //Récupère toutes les voitures
            return _dbContext.Cars.ToList();
        }

        public CarEntity GetCarById(int id)
        {
            //Récupère une voiture par son id
            return _dbContext.Cars.Find(id) ?? throw new Exception("Car not found");
        }

        public void UpdateCar(CarEntity car)
        {
            //Modifications d'une voiture
            _dbContext.Cars.Update(car);
        }
    }
}