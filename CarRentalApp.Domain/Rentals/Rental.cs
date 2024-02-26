using CarRentalApp.Domain.Cars;
using CarRentalApp.Domain.Customers;
using CarRentalApp.Domain.Location;


namespace CarRentalApp.Domain.Rentals;


public class Rental
{
    public int Id { get; set; }
    public double PricePerDay { get; set; }
    public int CarId { get; set; }
    public int PickupLocationId { get; set; }
    public int DropOffLocationId{ get; set; }
    public int CatCategoryId { get; set; }
    public int Customerd { get; set;}
    
    public DateTime StartDate{ get; set; }
    public Car Car { get; set; }
    public Customer Customer { get; set; }
    public Locations DropLocation;
    public Locations PickupLocation;




}