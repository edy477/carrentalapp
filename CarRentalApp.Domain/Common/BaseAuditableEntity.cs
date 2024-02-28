namespace CarRentalApp.Domain.Common;

public abstract class BaseAuditableEntity : BaseEntity
{
    public DateTimeOffset Created { get; set; }
    public int? CreatedBy { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTimeOffset LastModified { get; set; }
    
    
    
}