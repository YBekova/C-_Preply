namespace C__Preply;

public class Order
{
    public int Number { get; set; }
    public Customer Customer { get; set; }
    public string? Comment = null;

    public Order CreateCopy(Order original)
    {
        Order copyOrder = new Order();
        Customer copyCustomer = new Customer();
        Address copyAddress = new Address();
        
        copyOrder.Number = original.Number;
        copyCustomer.Name = original.Customer.Name;
        copyAddress.City = original.Customer.Address.City;
        copyAddress.Street = original.Customer.Address.Street;
        
        copyCustomer.Address = copyAddress;
        copyOrder.Customer = copyCustomer;
        copyOrder.Comment = original.Comment;

        return copyOrder;
    }

}