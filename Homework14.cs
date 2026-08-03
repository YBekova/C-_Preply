//Task 1
//int[] mass = { 12, 45, 7, 23, 56, 9, 34 };
//int sum = 0;


//for (int i = 0; i < mass.Length; i++)
//{

//    if (mass.Length == 0)
//    {

//        Console.WriteLine("The array is empty!");

//    }
//    else
//    {

//        sum += mass[i];

//    }



//}
//double average = (double)sum / mass.Length;

//Console.WriteLine($"Sum of all arrays: {sum}");
//Console.WriteLine($"Average of all arrays: {average}");

//Task 2

//int[] mass = { 3, 8, 15, 22, 41, 6, 19, 10 };
//int oddNumbers = 0;
//int evenNumbers = 0;
//int evenNumbersSum = 0;

//for (int i = 0; i < mass.Length; i++)
//{
//    if (i % 2 == 0)
//    {
//        evenNumbers += 1;
//        evenNumbersSum += mass[i];

//    }

//    if (i % 2 != 0)
//    {
//        oddNumbers += 1;

//    }
//}

//Console.WriteLine($"Even numbers count: {evenNumbers}");
//Console.WriteLine($"Odd numbers count: {oddNumbers}");
//Console.WriteLine($"Even numbers sum: {evenNumbersSum}");

//Task 3

//int[] mass = { 5, 12, 8, 21, 3, 17 };
//int targetValue = 21;
//int foundIndex = -1;

//for (int i = 0; i < mass.Length; i++)
//{
//    if (mass[i] == targetValue)
//    {
//        foundIndex = i;
//        break;
//    }

//}
//if (foundIndex != -1)
//{
//    Console.WriteLine($"Target value was found in Index - {foundIndex} - ");
//}
//else
//{
//    Console.WriteLine("Such target value does not exist.");
//}

//Task 4
// 
////            0 1 2 3 4 5  
//int[] mass = {1,2,3,4,5,6};
////            ^i
////            0 1 2 3 4 5
////           {6,5,4,3,2,1}
////                      ^j
//// j = 0 j++
//// j = 0 -> 1
//int[] newMass = new int[mass.Length];
//int j = 0;
//for(int i = mass.Length - 1; i >= 0; i--)
//{
//    newMass[j] = mass[i];
//    j++;
//}

//Console.Write("Reversed array: ");
//for (int i = 0; i < newMass.Length; i++)
//{
//    Console.Write(newMass[i] + " ");

//}

/*
 
              0 1 2 3 4 5 6 7 8
int[] mass = {4,2,7,2,9,4,1,7,3};
              ^i

                 0 1 2 3 4 5 6 7 8
int[] newMass = {4 0 0 0 0 0 0 0 0};
                   ^j
 */

//Task 6
int[] mass = { 15, 42, 8, 42, 23, 415, 42, 8, 42, 23, 4 };

int max = int.MinValue;
int secondMax = int.MinValue;

for (int i = 1; i < mass.Length; i++)
{
    if (mass[i] > max)
    {
        secondMax = max;
        max = mass[i];

    }
    else if (mass[i] > secondMax && mass[i] < max)
    {
        secondMax = mass[i];
   
    }

}

Console.WriteLine($"Second max number in the array:{secondMax}");