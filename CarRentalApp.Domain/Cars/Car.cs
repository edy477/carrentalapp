﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRentalApp.Domain.Categories;
using CarRentalApp.Domain.Common;
using CarRentalApp.Domain.Rentals;

namespace CarRentalApp.Domain.Cars;

public class Car :  BaseAuditableEntity, BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Brand { get; set; }

    public string Model { get; set; }
    public int ModelYear { get; set; }

    public string Color { get; set; }


    public int CarCategoryId { get; set; }
    public int CurrentLocationId { get; set; }
    
    
    public string FuelType { get; set; }

    public CarCategory CarCategory;
    public Availability? Availability { get; set; }
    public ICollection<Rental> Rentals { get; set; }
   
    


}