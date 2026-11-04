namespace C__Preply;

public class Pickup : IDelivery
{
    public string PickupPoint { get; set; }

    public Pickup(string pickupPoint)
    {
        PickupPoint = pickupPoint;
    }

    
    public decimal CalculateCost()
    {
        return 0;
    }

}