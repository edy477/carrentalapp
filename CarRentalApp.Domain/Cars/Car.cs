using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Domain.Cars;

public class Car
{
    [Key]
    public int Id { get; set; }

    public string brand { get; set; }
    
    public string 
}