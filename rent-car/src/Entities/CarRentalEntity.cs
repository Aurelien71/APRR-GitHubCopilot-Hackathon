
namespace Entities
{
    public class CarRentalEntity
    {
        // Add primary key
        public int Id { get; set; }
        // Add foreign key for Customer Entity
        public int CustomerId { get; set; }
        
        // Add foreign key for Car Entity
        public int CarId { get; set; }

        // Add IsRented, StartDate, EndDate
        public bool IsRented { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
    }
}

