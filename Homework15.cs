// Task 1 - foreach

//int[] numbers = { 5, -2, 8, 0, -1 };
//int positiveNumberSum = 0;
//int negativeNumberSum = 0;

//foreach(int number in numbers)
//{
//    if (number > 0)
//    {
//        positiveNumberSum += number;
//    }

//    else
//    {
//        negativeNumberSum += number;
//    }
//}

//Console.WriteLine($"Positive numbers sum: {positiveNumberSum}");
//Console.WriteLine($"Negative numbers sum: {negativeNumberSum}");

//Task 2 - foreach target, minimal, maximum numbers

//using System.ComponentModel.Design.Serialization;

//int[] numbers = { 14, 6, 21, 9, 3 };
//int max = numbers[0];
//int min = numbers[0];
//bool found = false;

//Console.Write("Enter the target number: ");
//bool targetValid = int.TryParse(Console.ReadLine(), out int target);

//if (!targetValid)
//{
//    Console.WriteLine("Incorrect input for target!");

//}

//foreach (int number in numbers)
//{
//    if (number > max)
//    {
//        max = number;
//    }

//    if (number < min)
//    {
//        min = number;
//    }



//    if (number == target)
//    {
//        found = true;
//        Console.WriteLine($"Target: {target}");
//        break;

//    }

//    else
//    {
//        Console.WriteLine("Target not found!");
//        break;
//    }

//}


//Console.WriteLine($"The minimum number: {min}");
//Console.WriteLine($"The maximum number: {max}");


//Task 3 - Task homework foreach

int[] mass = new int[6];
int sum = 0;
int max = mass[0];
int min = mass[0];
int countPositive = 0;
int countNegative = 0;
int countZero = 0;
bool found = false;
int i;

for (i = 0; i < mass.Length; i++)
{
    Console.Write($"Index #{i}: ");
    
    if (!int.TryParse(Console.ReadLine(), out mass[i]))
    {
        Console.WriteLine("Invalid input, write number!");
        i--;
        continue;

    }
    
}
max = mass[0];
min = mass[0];

Console.Write("Enter the target: ");
bool targetValid = int.TryParse(Console.ReadLine(), out int target);
while (!targetValid)
{
    Console.Write("Error! Enter the target again: ");
    targetValid = int.TryParse(Console.ReadLine(), out target);

}




foreach (int number in mass) 
{
 
    if (number > max)
    {
        max = number;
        
    }
    if (number < min)
    {
        min = number;
    }

    if(number < 0)
    {
        countNegative++;
    }

    else if(number > 0)
    {
        countPositive++;
    }

    else 
    {
        countZero++;
    }

    if(number == target)
    {
        found = true;
       
    }
  

    sum += number;
}

if (found)
{
    Console.WriteLine($"Target found: {target}");
}
else
{
    Console.WriteLine("Target not found!");
}

Console.Write($"Numbers in array:  ");

foreach (int number in mass)
{
    Console.Write(number + " ");
}

Console.WriteLine($"\nThe minimum number: {min}");
Console.WriteLine($"The maximum number: {max}");
Console.WriteLine($"The sum of all numbers: {sum}");
Console.WriteLine($"How many positive numbers: {countPositive}");
Console.WriteLine($"How many negative numbers: {countNegative}");
Console.WriteLine($"How many zeros: {countZero}");