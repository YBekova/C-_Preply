Console.Write("Enter value: ");

bool valueValid = decimal.TryParse(Console.ReadLine(), out decimal value);

for(int i = 1; i <= 10; i++)
{
    
    var result = Convert.ToDecimal(value * i);
    Console.WriteLine($"{value} * {i} = {result}");
}