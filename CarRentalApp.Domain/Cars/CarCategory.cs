using System.ComponentModel.DataAnnotations;
using CarRentalApp.Domain.Cars;

namespace CarRentalApp.Domain.Categories;

public class CarCategory
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
       
    public ICollection<Car> Cars;


}