using CarRentalApp.Domain.Cars;

namespace CarRentalApp.Domain.Common;

public class CarRegisteredEvent: IDomainEvent
{
    public int CarId { get; init; }

    public CarRegisteredEvent()
    {
        
    }
    
}