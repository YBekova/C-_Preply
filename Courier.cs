namespace C__Preply;

public class Courier
{
    public string Name;
    private int deliveredOrders;

    public Courier (string name)
    {
        Name = name;
        
    }

    public bool Deliver(Order order)
    { 
        if (order.MarkAsDelivered())
        {
                deliveredOrders++;
                return true;
        }
        
        return false;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name - {Name}, Deliver {deliveredOrders}");
    }
}