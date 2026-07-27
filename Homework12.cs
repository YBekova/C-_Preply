
using System.Diagnostics.CodeAnalysis;


// ————TASK 1 —————
decimal sum = 0;
Console.Write("Enter value: ");

bool valueValid = decimal.TryParse(Console.ReadLine(), out decimal value);

for (int i = 1; i <= 10; i++)
{

    var result = Convert.ToDecimal(value * i);
    sum += result;
    Console.WriteLine($"{value} * {i} = {result} (sum: {sum})");
}

// ————TASK 2 —————
for (var i = 1; i <= 5; i++)

{

    for (var a = 1; a <= i; a++)

    {

        Console.Write("*");

    }

    Console.WriteLine();
}

// ————TASK 3 —————

int divisor3 = 3;
int divisor5 = 5;
int divisor7 = 7;

for (int i = 1; i <= 100; i++)
{
    if (i == 66) break;

    if (i % divisor7 == 0) continue;

    if (i % divisor5 == 0 && i % divisor3 == 0) Console.WriteLine($"FizzBuzz: {i} ");

    else if (i % divisor3 == 0) Console.WriteLine($"Fizz: {i} ");

    else if (i % divisor5 == 0) Console.WriteLine($"Buzz: {i} ");

}

// ————TASK 3 —————
Random rand = new Random();

int randomValue = rand.Next(1,101);
int guess;
do
{
    Console.Write("Enter the value from 1 to 100: ");
    bool isNumber = int.TryParse(Console.ReadLine(), out guess);

    if (!isNumber)
    {
        Console.WriteLine("Please enter a valid number.");
        continue;
    }

    if (guess < randomValue) Console.WriteLine("Bigger!");
    
    else if (guess > randomValue) Console.WriteLine("Lesser!");
    
    else Console.WriteLine("You won!");
    
} while (guess != randomValue);