using C__Preply;

var order1 = new Order();

order1.Number = 1;
order1.Customer = new Customer();
order1.Customer.Name = "John Test";

order1.Customer.Address = new Address();
order1.Customer.Address.Street = "Main street 123";
order1.Customer.Address.City = "Almaty";

Order orderCopy1 = order1.CreateCopy(order1);

orderCopy1.Number = 2;
orderCopy1.Customer.Name = "John Copy";
orderCopy1.Customer.Address.Street = "Main street copy123";
orderCopy1.Customer.Address.City = "Astana";

Console.WriteLine($"Original number - {order1.Number}, " +
                  $"Original customer name - {order1.Customer.Name}, " +
                  $"Original customer address street - {order1.Customer.Address.Street}, " +
                  $"Original customer address city - {order1.Customer.Address.City}");
Console.WriteLine($"\nCopy number - {orderCopy1.Number}, " +
                  $"Copy customer name - {orderCopy1.Customer.Name}, " +
                  $"Copy customer adrress street - {orderCopy1.Customer.Address.Street}, " +
                  $"Copy customer address city - {orderCopy1.Customer.Address.City}");