using MediatR;

namespace CarRentalApp.Domain.Common;

public interface IDomainEvent 
{

    public List<DomainEvent> DomainEvents { get; set; }

}

public abstract class DomainEvent : INotification
{
    
    
}

