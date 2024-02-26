using Microsoft.EntityFrameworkCore;

using CarRentalApp.Domain.Cars;
using CarRentalApp.Domain.Categories;
using CarRentalApp.Domain.Customers;
using CarRentalApp.Domain.Insurance;
using CarRentalApp.Domain.Location;
using CarRentalApp.Domain.Rentals;
using CarRentalApp.Domain.Users;

namespace CarRentalApp.Application.Common.Interfaces;

public interface IApplicationDBContext
{
    public DbSet<Car> Cars { get; }
    public DbSet<Customer> Customers { get; }
    public DbSet<CarCategory> Categories { get; }
    public DbSet<Rental> Rentals { get; }
    public DbSet<User> Users { get; }
    public DbSet<Reservation> Reservations { get; }
    public DbSet<Availability> Availabilities { get; }
    public DbSet<Locations> Locations { get; }
    public DbSet<Insurance> Insurances { get; }
    public DbSet<RentalInsurance> RentalInsurances { get; }

    // Task<int> SaveChangesAsync(CancellationToken cancellationToken);

}