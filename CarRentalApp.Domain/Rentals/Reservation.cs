using System.Runtime.InteropServices.JavaScript;

namespace CarRentalApp.Domain.Rentals;

public class Reservation
{
    public int Id { get; set; }
    public int PickupLocationId { get; set; }
    public int DropOffLocationId{ get; set; }
    public int CatCategoryId { get; set; }
    public DateTime StartDate{ get; set; }
    public DateTime EnnDate{ get; set; }
    public string RentalType { get; set; }
    

}