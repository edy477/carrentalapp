using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Domain.Categories;

public class Category
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
    
    

}