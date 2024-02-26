using System.ComponentModel.DataAnnotations;
using CarRentalApp.Domain.Rentals;
using CarRentalApp.Domain.Users;
namespace CarRentalApp.Domain.Customers;

public class Customer
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int LicenseNumber { get; set; }
    public DateTime BirthDay { get; set; }
    public DateTime DriverLicenseExp { get; set; }
    public ICollection<Rental> Rentals { get; set; }
    public User User { get; set;}



}