var passes = new int[] { 1024, 1337, 2048, 4090, 5555, 7777, 8080, 9001 };

Console.WriteLine("The shift has started. Enter the pass (0 for the finishing of the shift).");
var enteredTries = 0;
var enteredGranted = 0;
var enteredDenied = 0;


while (true)
{
    var isAllowed = false;


    Console.Write("\nEnter the pass: ");
    var input = Console.ReadLine();
    if (input == "0")
    {
        Console.WriteLine("\nThe shift is over. Good bye.");
        break;
    }
    
    var isValidPass = int.TryParse(input, out var enteredPass);
    
    if (!isValidPass)
    {
        Console.WriteLine("Erorr! Only numbers allowed!");
        continue;
    }
   
    
    
    foreach(var allowedPass in passes)
    {
        if (allowedPass == enteredPass) isAllowed = true; 
    
    }

    if (isAllowed)
    {
        Console.WriteLine("Access granted.");
        enteredGranted++;
    }
    else
    {
        Console.WriteLine("Access denied.");
        enteredDenied++;
    }
    
    enteredTries++;
}
Console.WriteLine($"Access granted: {enteredGranted}");
Console.WriteLine($"Access denied: {enteredDenied}");
Console.WriteLine($"Passes tries: {enteredTries}");