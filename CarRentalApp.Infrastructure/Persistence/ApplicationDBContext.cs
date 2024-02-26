using CarRentalApp.Application.Common.Interfaces;
using CarRentalApp.Domain.Cars;
using CarRentalApp.Domain.Categories;
using CarRentalApp.Domain.Customers;
using CarRentalApp.Domain.Insurance;
using CarRentalApp.Domain.Location;
using CarRentalApp.Domain.Rentals;
using CarRentalApp.Domain.Users;
using Microsoft.EntityFrameworkCore;


namespace Managmentpropertyapp.Infrastructure.Persistence;

public class ApplicationDBContext: DbContext , IApplicationDBContext
{

    public ApplicationDBContext()
    {
    }

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conn = "Username=postgres;Password=aass1122;Host=localhost;Port=5432;Database=carrentaldb";
        
   
        optionsBuilder.UseNpgsql(conn);
    }

  //  public DbSet<Property> Properties => Set<Property>();
  public void OnModelCreating(ModelBuilder modelBuilder)
  {
      base.OnModelCreating(modelBuilder);
  }
  public DbSet<Car>  Cars { get; set; }
  public DbSet<Customer> Customers { get; set; }
  public DbSet<CarCategory> Categories { get; set; }
  public DbSet<Rental> Rentals { get; set; }
  public DbSet<User> Users { get; set; }
  public DbSet<Reservation> Reservations { get; set; }
  public DbSet<Availability> Availabilities { get; set; }
  public DbSet<Locations> Locations { get; set; }
  public DbSet<Insurance> Insurances { get; set; }
  public DbSet<RentalInsurance> RentalInsurances { get; set; }
/*
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        
        
    }
*/
}