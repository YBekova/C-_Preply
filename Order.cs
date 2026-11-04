namespace C__Preply;

public class Order
{
    public int Number { get; set; }
    public decimal ProductsTotal { get; set; }
    public IDelivery Delivery { get; set; }


    public Order(int number, decimal productsTotal, IDelivery delivery)
    {
        Number = number;
        ProductsTotal = productsTotal;
        Delivery = delivery;
    }

    public decimal GetTotalCost()
    {
        return ProductsTotal + Delivery.CalculateCost();
    }
}   