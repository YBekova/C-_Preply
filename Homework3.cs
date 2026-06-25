Console.WriteLine("The product: ");
string productName = Console.ReadLine();
Console.WriteLine("The product Price: ");
int productPrice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("The amount of the product: ");
int productAmount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The discount in %: ");
int productDiscount = Convert.ToInt32(Console.ReadLine());
decimal discountAmount = productPrice * (productDiscount / 100m);
decimal totalPrice = (productPrice - discountAmount) * productAmount;
totalPrice = Math.Round(totalPrice, 2);
Console.WriteLine();

Console.WriteLine($"Product name: {productName}");
Console.WriteLine($"Price without discount: {productPrice}");
Console.WriteLine($"Product discount in %: {productDiscount}");
Console.WriteLine($"Total price: {totalPrice}");