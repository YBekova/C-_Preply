//Task 1 - weekly expense tracker

decimal[] expenses = new decimal[7];
decimal sum = 0;
decimal min = Decimal.MaxValue;
decimal max = Decimal.MinValue;
int maxDay = 1;
int minDay = 1;

for (int i = 0; i < expenses.Length; i++)
{
    Console.Write($"Day {i + 1}, expenses: ");
    var validExpenses = decimal.TryParse(Console.ReadLine(), out var expResult);
    
    
    while (!validExpenses || expResult <= 0)
    {
        if (!validExpenses)
        {
            Console.Write("Error! You can only input numbers! Try again: ");
        }
        else if (expResult <= 0)
        {
            Console.Write("Error! You can't input zero or the minus amount! Try again: ");
        }
        validExpenses = decimal.TryParse(Console.ReadLine(), out expResult);
    }
    
    expenses[i] = expResult;
    
    if (expenses[i] < min)
    {
        min = expenses[i];
        minDay = i + 1;
    }

    if (expenses[i] > max)
    {
        max = expenses[i];
        maxDay = i + 1;
    }
}

foreach (decimal input in expenses)
{
    sum += input;
}

decimal average = sum / expenses.Length;

const string Header = 
    @"====================================
      WEEKLY EXPENSES ANALYTICS
===================================="; 

Console.WriteLine(Header);
Console.WriteLine($"The expenses for the whole week is = {sum}");
Console.WriteLine($"The most expensive day = {maxDay}, the amount = {max}");
Console.WriteLine($"The most inexpensive day = {minDay}, the amount = {min}");
Console.WriteLine($"The average spending number is = {average}");