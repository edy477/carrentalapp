namespace CarRentalApp.Domain.Cars;

public class Availability
{
     public int Id { get; set; }
     public DateTime AvailableStartDate { get; set; }
     public DateTime AvailableEndDate { get; set; }
     public int CarId { get; set; }
     public Car Car { get; set; } = null;

}