namespace C__Preply;

public class ExpressDelivery : Delivery
{
    public ExpressDelivery(string address, int distance) : base(address, distance)
    {
    }

    public override decimal CalculateCost()
    {
        return 100 + (15 * Distance);
    }
}