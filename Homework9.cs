Console.Write("Enter a number a: ");
bool a = decimal.TryParse(Console.ReadLine(), out decimal firstValue);

Console.Write("Enter operator(+ - * /): ");
string operation = Console.ReadLine();

Console.Write("Enter a number b: ");
bool b = decimal.TryParse(Console.ReadLine(), out decimal secondValue);
switch (operation)
{
    case "+":
        Console.WriteLine($"Result: {firstValue + secondValue}");
        break;

    case "-":
        Console.WriteLine($"Result: {firstValue - secondValue}");
        break;

    case "*":
        Console.WriteLine($"Result: {firstValue * secondValue}");
        break;

    case "/":
        if (secondValue == 0)
        {
            Console.WriteLine("You can't divide by zero!");
            break;
        }
        Console.WriteLine($"Result {firstValue / secondValue}");
        break;

    default:
        Console.WriteLine("Unknown operation");
        break;

}