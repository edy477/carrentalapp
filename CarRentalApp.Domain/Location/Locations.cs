using System.ComponentModel.DataAnnotations;
using CarRentalApp.Domain.Rentals;

namespace CarRentalApp.Domain.Location;

public class Locations
{
    [Key]
    public int Id { get; set; }
    public string StreetAddres { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Zipcode { get; set; }
    public ICollection<Rental> DropLocations;
    public ICollection<Rental> PickUpLocations;
}

