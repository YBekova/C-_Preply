using System.Globalization;

// Practice base
int[] mass = { 2, 5, 7, 8, 9, 10, 19 };

Console.WriteLine($"{mass[0]}, {mass[2]}, {mass[^1]}");
mass[1] = 100;

for (int i = 0; i < mass.Length; i++) Console.WriteLine(mass[i]);

//Practice: input and sum

int[] mass = new int[5];
int sum = 0;

int i = 0;
while (i < mass.Length)
{

    Console.Write($"Index #{i}: ");

    if (!int.TryParse(Console.ReadLine(), out mass[i]))

    {
        Console.WriteLine("Error! Try again!");
        continue;

    }

    i++;

}

for (i = 0; i < mass.Length; i++)
{

    sum += mass[i];

}
Console.WriteLine($"Sum of all indexes = {sum}");

//Homework



int[] mass = new int[5];
int sum = 0;
int firstIndex = mass[0];
int lastIndex = mass.Length - 1;
int positiveNumbers = 0;
int i = 0;

while (i < mass.Length)
{
    Console.Write($"Index #{i}: ");
    if (!int.TryParse(Console.ReadLine(), out mass[i]))
    {
        Console.WriteLine("Error! Try again!");
        continue;
    }

    i++;

}

for (i = 0; i < mass.Length; i++)
{

    sum += mass[i];
    if (mass[i] > 0)
    {
        positiveNumbers += 1;
    }

}

Console.Write($"Index countdown:  ");

for (i = mass.Length - 1; i >= 0; i--)
{
    Console.Write(mass[i] + " ");
}

Console.WriteLine($"\nSum of all indexes = {sum}");
Console.WriteLine($"How many positive numbers = {positiveNumbers}");
Console.WriteLine($"First Index = {mass[firstIndex]}");
Console.WriteLine($"Last Index = {mass[lastIndex]}");
