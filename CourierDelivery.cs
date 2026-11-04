namespace C__Preply;

public class CourierDelivery : Delivery
{
    public CourierDelivery(string address, int distance) : base(address, distance)
    {
    }

    public override decimal CalculateCost()
    {
        return 50 + (10 * Distance);
    }
}