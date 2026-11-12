using C__Preply;

Product product1 = new Product("Laptop",7000m,10);
Product product2 = new Product("Phone",10000m,6);

ShopService service = new ShopService();


try
{
    decimal totalCost = service.SellProduct(product1, 2);

    Console.WriteLine($"Laptop total cost: {totalCost}");
}
catch (ArgumentException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Laptop stock: {product1.ProductStock}");



try
{
    decimal totalCost = service.SellProduct(product2, 2);

    Console.WriteLine($"\nPhone total cost with discount: {totalCost}");
}
catch (ArgumentException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Phone stock: {product2.ProductStock}");



try
{
    decimal totalCost = service.SellProduct(product1, 20);

    Console.WriteLine($"\nTotal cost: {totalCost}");
}
catch (ArgumentException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Laptop stock: {product1.ProductStock}");



try
{
    service.RestockProduct(product1, 5);

    Console.WriteLine("\nRestock successful!");
}
catch (ArgumentException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Laptop stock: {product1.ProductStock}");



try
{
    service.RestockProduct(product1, -3);

    Console.WriteLine("\nRestock successful!");
}
catch (ArgumentException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Laptop stock: {product1.ProductStock}");



try
{
    decimal totalCost = service.SellProduct(product2, 0);

    Console.WriteLine($"\nTotal cost: {totalCost}");
}
catch (ArgumentException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Phone stock: {product2.ProductStock}");



try
{
    Product invalidProduct = new Product("", 100m, 5);

    Console.WriteLine("\nProduct created successfully!");
}
catch (ArgumentException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}



try
{
    Product invalidProduct = new Product("Mouse", 0m, 5);

    Console.WriteLine("\nProduct created successfully!");
}
catch (ArgumentException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}



try
{
    Product invalidProduct = new Product("Keyboard", 100m, -5);

    Console.WriteLine("\nProduct created successfully!");
}
catch (ArgumentException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}



try
{
    DiscountProduct invalidProduct =
        new DiscountProduct("Tablet", 1000m, 5, 100m);

    Console.WriteLine("\nProduct created successfully!");
}
catch (ArgumentException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}