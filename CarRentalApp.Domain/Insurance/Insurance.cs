namespace CarRentalApp.Domain.Insurance;

public class Insurance
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string policy { get; set; }
    public double money { get; set; }
    public ICollection<Insurance> Insurances { get; set; }
}