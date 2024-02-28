using CarRentalApp.Application.Common.Interfaces;
using CarRentalApp.Domain.Cars;
using MediatR;

namespace CarRentalApp.Application.Cars.Commands.RegisterCar;

public class RegisterCarCommand: IRequest<int>
{
   

    public string Brand { get; set; }

    public string Model { get; set; }
    public int ModelYear { get; set; }

    public string Color { get; set; }


    public int CarCategoryId { get; set; }
    public int CurrentLocationId { get; set; }
    public string FuelType { get; set; }
    
    
    
    
}


public class RegisterCarCommandHandler : IRequestHandler<RegisterCarCommand, int>
{
    private readonly IApplicationDBContext _dbContext;

    public RegisterCarCommandHandler(IApplicationDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> Handle(RegisterCarCommand request, CancellationToken cancellationToken)
    {

        Car car = new() 
        {
            Brand = request.Brand, Model = request.Model, ModelYear = request.ModelYear, Color = request.Color,
            CarCategoryId = request.CarCategoryId, FuelType = request.FuelType, CurrentLocationId = request.CurrentLocationId, 
        };

        _dbContext.Cars.Add(car);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return car.Id;
        
        
        
        
        
        return 0;

    }

}