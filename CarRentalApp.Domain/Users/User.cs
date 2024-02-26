using System.ComponentModel.DataAnnotations;
using CarRentalApp.Domain.Customers;

namespace CarRentalApp.Domain.Users;

public class User
{
    [Key]
    public Guid id { get; set; }

    public string username { get; set; }
    public string password { get; set; }
    public int CustomerId { get; set; }
    
    public Customer Customer { get; set; }
}