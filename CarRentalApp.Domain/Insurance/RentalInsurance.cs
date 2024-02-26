namespace CarRentalApp.Domain.Insurance;

public class RentalInsurance
{
    public int Id { get; set; }
    public int InsuranceId { get; set; }
    public Insurance Insurance { get; set; }
}