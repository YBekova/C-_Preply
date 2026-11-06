namespace C__Preply;

public class OrderInput
{
    public static int ReadInt(string message, int minValue, int maxValue = int.MaxValue)
    {
        int number;

        while (true)
        {
            Console.Write(message + " ");

            if (int.TryParse(Console.ReadLine(), out number)
                && number >= minValue
                && number <= maxValue)
            {
                return number;
            }

            if (maxValue == int.MaxValue)
            {
                Console.WriteLine($"Invalid input! Enter a number greater than or equal to {minValue}.");
            }
            else
            {
                Console.WriteLine($"Invalid input! Enter a number from {minValue} to {maxValue}.");
            }
        }
    }
   
    public static string ReadText(string message)
    {
        while (true)
        {
            Console.Write(message);
            var value = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            Console.WriteLine("Field cannot be empty!");
        }
    }
    
    
    
    public static decimal ReadProductsTotal()
    {
        decimal productsTotal;

        while (true)
        {
            Console.Write("Enter products total: ");

            if (decimal.TryParse(Console.ReadLine(), out productsTotal) && productsTotal >= 0)
            {
                return productsTotal;
            }

            Console.Write("Invalid price! Try again. ");
        }
    }
}