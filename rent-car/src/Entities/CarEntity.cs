using System;

namespace Entities
{
    public class CarEntity
    {
        // Add a primary key to CarEntity
        public int Id { get; set; }
        
        // Add properties for FullName, FuelCharge, HorsesPower, ExtraInsurance, Type, Brand, amount of km, Color and any other properties(gps, air conditioning, etc.)
        public string FullName { get; set; }
        public double FuelCharge { get; set; }
        public int HorsesPower { get; set; }
        public bool ExtraInsurance { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public int AmountOfKm { get; set; }
        public string Color { get; set; }
        public bool Gps { get; set; }
        public bool AirConditioning { get; set; }
        public bool Automatic { get; set; }
        public bool Diesel { get; set; }
        public bool Electric { get; set; }
        // Add a navigation property for CarRentalEntity
        public CarRentalEntity CarRental { get; set; }
           
    }
}