namespace Entities
{
    public class CustomerEntity
    {
        // Add primary key
        public int Id { get; set; }
        // Add properties for FirstName, LastName, Email, PhoneNumber, Address
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        // Add a list of CarRentalEntity named CarRentals  
        public List<CarRentalEntity> CarRentals { get; set; }


    }
}
