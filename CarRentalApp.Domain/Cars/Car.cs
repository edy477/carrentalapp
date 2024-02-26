using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Domain.Cars;

public class Car
{
    [Key]
    public int Id { get; set; }

    public string Brand { get; set; }

    public string Model { get; set; }
    public int ModelYear { get; set; }

    public string Color { get; set; }


    public int CarCategoryId { get; set; }
    public int CurrentLocationId { get; set; }
  




}