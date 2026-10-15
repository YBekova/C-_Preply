//Task 1 

using C__Preply;

int productCountA = 10;
int productCountB = productCountA;

productCountB = 100;

Console.WriteLine(productCountA);
Console.WriteLine(productCountB);

//Task 2

Product firstProduct = new Product();
Product secondProduct = firstProduct;


secondProduct.Price = 2000;
secondProduct.Quantity = 5;

bool same = ReferenceEquals(firstProduct, secondProduct);
Console.WriteLine($"First product price {firstProduct.Price} , quantity {firstProduct.Quantity}");
Console.WriteLine($"Second product price {secondProduct.Price} , quantity {secondProduct.Quantity}");
Console.WriteLine($"Same reference true or false  = {same}");

//Task 3 
Product thirdProduct = new Product();

thirdProduct.Name = firstProduct.Name;
thirdProduct.Price = thirdProduct.Price;
thirdProduct.Quantity = thirdProduct.Quantity;

thirdProduct.Quantity = 10;
bool same2 = ReferenceEquals(firstProduct, thirdProduct);

Console.WriteLine($"First product price {firstProduct.Price} , quantity {firstProduct.Quantity}");
Console.WriteLine($"Third product price {thirdProduct.Price} , quantity {thirdProduct.Quantity}");
Console.WriteLine($"Same reference true or false  = {same2}");

//Task 4

int[] mass1 = [5, 10, 15, 20, 25];
int[] mass2 = mass1;
