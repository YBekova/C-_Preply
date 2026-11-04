using C__Preply;

// var delivery1 = new CourierDelivery("Almaty, Dostyk 42A", 8);
// var delivery2 = new CourierDelivery("Talgar, Abay 31",26);
// var delivery3 = new CourierDelivery("Aksay-4, Avay 456",19);
// var delivery4 = new CourierDelivery("Almaty, Qarasay batyr 48", 5);
// var pickup1 = new Pickup("Pick-up shop2");
// var pickup2 = new Pickup("Pick-up shop2");
// var expressdelivery1 = new ExpressDelivery("Almaty, Zhambyl 236", 5);
// var expressdelivery2 = new ExpressDelivery("Akzhar, SiSinghai 2",60);

List<Order> orderDeliveryList = new List<Order>(8);

int orderCount = OrderInput.ReadInt("How many orders? ", 0);
//
// orderDeliveryList.Add(new Order(10, 1550, delivery1));
// orderDeliveryList.Add(new Order(2, 250, delivery2));
// orderDeliveryList.Add(new Order(9, 789, delivery3));
// orderDeliveryList.Add(new Order(24,4999,delivery4));
// orderDeliveryList.Add(new Order(1, 190, pickup1));
// orderDeliveryList.Add(new Order(90,1200,pickup2)); 
// orderDeliveryList.Add(new Order(33, 9898, expressdelivery1));
// orderDeliveryList.Add(new Order(15,7644, expressdelivery2));



for (var i = 0; i < orderCount; i++)
{
    Console.WriteLine("Choose delivery type:");
    Console.WriteLine("1 - Courier");
    Console.WriteLine("2 - Express");
    Console.WriteLine("3 - Pickup");

    int choice = OrderInput.ReadInt("Enter the choice: ", 1, 3);

    IDelivery delivery;
    
    switch (choice)
    {
        case 1 or 2:
        {
            var address = OrderInput.ReadText("Enter address: ");

            int distance = OrderInput.ReadInt("Enter distance:", 1);

            if (choice == 1)
            {
                delivery = new CourierDelivery(address, distance);
            }
            else
            {
                delivery = new ExpressDelivery(address, distance);
            }

            break;
        }
        case 3:
        {
            var pickupPoint = OrderInput.ReadText("Enter pickup point: ");

            delivery = new Pickup(pickupPoint);
            break;
        }
        default:
            Console.Write("Invalid delivery type!");
            i--;
            continue;
    }
    
    var number = OrderInput.ReadInt("Enter order number:", 1);
    
    var productsTotal = OrderInput.ReadProductsTotal();
    
    Order order = new Order(number, productsTotal, delivery);
    
    orderDeliveryList.Add(order);
}

static void DeliveryOrderProcess(List<Order> orderDeliveryList)
{
    if (orderDeliveryList.Count == 0)
    {
        Console.WriteLine("No orders found");
        return;
    }
    
    decimal totalRevenue = 0;
    decimal totalDeliveryCost = 0;
    Order maxOrder = null;
    var freeDeliveryCount = 0;
    
    Console.WriteLine();
    foreach (Order order in orderDeliveryList)
    {
        Console.WriteLine($"Order number - {order.Number}, product total - {order.ProductsTotal}, delivery cost - {order.Delivery.CalculateCost()}, total for everything: {order.GetTotalCost()}");
        
        decimal cost = order.GetTotalCost();
        totalRevenue += cost;
        
        totalDeliveryCost += order.Delivery.CalculateCost();
        
        if (maxOrder == null || order.GetTotalCost() > maxOrder.GetTotalCost())
        {
            maxOrder = order;
        }
        
        if (order.Delivery.CalculateCost() == 0)
        {
            freeDeliveryCount++;
        }
    }
    Console.WriteLine($"\nMost expensive order: {maxOrder.Number}, cost: {maxOrder.GetTotalCost()}");
    
    var averageCost = totalRevenue / orderDeliveryList.Count;

    var aboveAverageCount = 0;

    Console.WriteLine($"\nAverage order cost: {averageCost}\n");
  
    
    foreach (Order order in orderDeliveryList)
    {
        if (order.GetTotalCost() > averageCost)
        {
            
            Console.WriteLine($"Above average order: {order.Number}, cost: {order.GetTotalCost()}");
            aboveAverageCount++;
        }
    }
    Console.WriteLine($"\nHow many orders above average: {aboveAverageCount}");
    Console.WriteLine($"\nHow many free deliveries - pick ups: {freeDeliveryCount}");
}

DeliveryOrderProcess(orderDeliveryList);