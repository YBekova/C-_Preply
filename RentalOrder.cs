namespace C__Preply;

public class RentalOrder
{
    public Vehicle Vehicle { get; set; }
    public int Days { get; set; }

    public RentalOrder(Vehicle vehicle, int days)
    {
        Vehicle = vehicle;
        Days = days;
    }

    public decimal GetTotalCost()
    {
        return Vehicle.CalculateCost(Days);
    }
}