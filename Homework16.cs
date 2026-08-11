Console.Write("Enter number of students: ");
var studentNumberValid = int.TryParse(Console.ReadLine(), out var numberOfStudents);
var isInvalidAmount = numberOfStudents is > 15 or < 3;

while (!studentNumberValid || isInvalidAmount)
{
    if (!studentNumberValid)
    {
        Console.Write("Error! Enter the valid number: ");
    }
    else if (isInvalidAmount)
    {
        Console.Write("Error! The student count can't be less than 3 and more than 15! Enter the number again: ");
    }

    studentNumberValid = int.TryParse(Console.ReadLine(), out numberOfStudents);
}

var students = new int[numberOfStudents];

for (var i = 0; i < students.Length; i++)
{
    
    Console.Write($"Student #{i + 1}, points: ");
    var pointValid = int.TryParse(Console.ReadLine(), out var points);

    if (!pointValid)
    {
        Console.Write("Error! Write only numbers for point! Try again:  ");
        i--;
        continue;
    }
    else if (points < 0 || points > 100)
    {
        Console.Write("Error! Points can only be from 0 to a 100! Try again:  ");
        i--;
        continue;
    }

    students[i] = points;
}

var max = students[0];
var min = students[0];
var studentNumber = 1;
var passedSixtyScore = 0;
var sum = 0;

Console.WriteLine();

foreach (var score in students)
{
    Console.WriteLine($"Student #{studentNumber}: {score}");
  
    sum += score;

    if (score > max) max = score;
    if (score < min) min = score;
    if (score >= 60) passedSixtyScore++;

    studentNumber++;
}

var average = (double)sum / students.Length;

const string Header =
@"====================================
      STUDENT SCORE ANALYTICS
====================================";

Console.WriteLine($"\n{Header}\n");
Console.WriteLine($"Sum of all students scores: {sum}");
Console.WriteLine($"The average score of all students is - {average}");
Console.WriteLine($"The minimum score was - {min}");
Console.WriteLine($"The maximum score was - {max}");
Console.WriteLine($"The amount of student who passed the 60 score - {passedSixtyScore}");