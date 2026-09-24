namespace C__Preply;

public class Order
{
    public int Number;
    public string Address;
    private bool isDelivered;
    public static int OrderCount;

    public Order(int number, string address)
    {
        Number = number;
        Address = address;
        OrderCount++;

    }

    public bool MarkAsDelivered()
    {
        if (!isDelivered)
        {
            Console.WriteLine("The order is Delivered");
            isDelivered = true;
            return true;
        }
        else
        {
            Console.WriteLine("The order is already delivered!");
            return false;
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Address - {Address}, Number - {Number}, delivery - {isDelivered}");
    }
}