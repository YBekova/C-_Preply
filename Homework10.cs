using System.Diagnostics.Metrics;
using System.Reflection;

int counter = 0;

Console.Write("Ente first value: ");

bool firstValueIsValid = decimal.TryParse(Console.ReadLine(), out decimal firstValue);

while (!firstValueIsValid)
{
    counter++;

    if (counter == 5)
    {
        Console.WriteLine("Too many errors!");
        return;
    }

    Console.Write("That's not value. Try again: ");
    firstValueIsValid = decimal.TryParse(Console.ReadLine(), out firstValue);
}

Console.Write("Enter operator (+ - * /): ");
string operation = Console.ReadLine();

while (operation != "+" &&
       operation != "-" &&
       operation != "*" &&
       operation != "/")
{
    counter++;

    if (counter == 5)
    {
        Console.WriteLine("Too many errors!");
        return;
    }

    Console.Write("Unknown operator. Try again: ");
    operation = Console.ReadLine();
}


Console.Write("Enter second value: ");

bool secondValueIsValid = decimal.TryParse(Console.ReadLine(), out decimal secondValue);

while (!secondValueIsValid)
{
    counter++;

    if (counter == 5)
    {
        Console.WriteLine("Too many errors!");
        return;
    }

    Console.Write("That's not value. Try again: ");
    secondValueIsValid = decimal.TryParse(Console.ReadLine(), out secondValue);
}
  

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
        Console.WriteLine($"Result: {firstValue / secondValue}");
        break;

    default:
        Console.WriteLine("Unknown operation");
        break;

}
