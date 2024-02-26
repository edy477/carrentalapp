using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Domain.Location;

public class Location
{
    [Key]
    public int Id { get; set; }
    public string StreetAddres { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Zipcode { get; set; }
}
