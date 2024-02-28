namespace CarRentalApp.Domain.Common;

public abstract class BaseEntity 
{

    private readonly List<IDomainEvent> _domainEvents = new();

    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList();
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    protected void RaiseDomainEvents(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

}