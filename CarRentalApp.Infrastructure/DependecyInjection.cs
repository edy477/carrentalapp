using CarRentalApp.Application.Common.Interfaces;
using Managmentpropertyapp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CarRentalApp.Infrastructure;

public static class DependecyInjection


{
    
  /*  public static ConfigureServices(IServiceCollection services)
    {
        // Other service configurations...

        services.AddPersistence(Configuration);
    }*/
  

    public static IServiceCollection addInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddPersistence(configuration);
        services.AddDbContext<ApplicationDBContext>(options => options.UseNpgsql(configuration.GetConnectionString("main")));
       // services.AddScoped<IPropertiesRepository, Propertyrepository>();
     //   services.AddScoped<IApplicationDBContext>(provider => provider.GetRequiredService<ApplicationDBContext>());
        return services;
        
    }

    /*public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
      /*  services.AddDbContext<DBContext>(options => options
            .UseNpgsql(configuration.GetConnectionString("Main"), b => b.MigrationsAssembly(typeof(DBContext).Assembly.FullName)))
            .LogTo(Console.WriteLine, LogLevel.Information));;

        services.AddScoped<IPropertiesRepository, Propertyrepository>();*/
     /* services.AddDbContext<DBContext>(options => options
          .UseNpgsql(configuration.GetConnectionString("Main"), b => b.MigrationsAssembly(typeof(DBContext).Assembly.FullName))
          .LogTo(Console.WriteLine, LogLevel.Information));
*/
     // services.AddScoped<IPropertiesRepository, Propertyrepository>();
     //   return services;

  //  }*/

}