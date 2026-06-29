
Console.Write("Enter your name: ");
string firstName = Console.ReadLine().Trim();

Console.Write("Enter you last name: ");
string lastName = Console.ReadLine().Trim();

Console.Write("Enter the city: ");
string city = Console.ReadLine().Trim();

Console.Write("What is your desirable career: ");
string career = Console.ReadLine();

Console.Write("What is your favourite programming language: ");
string programmingLanguage = Console.ReadLine();

Console.Write("What's your favorite subject in CS: ");
string favoriteCS = Console.ReadLine();

Console.Write("What's your personal motto: ");
string motto = Console.ReadLine();

const string EmailDomain = "@student.local";

const string Header =
@"====================================
        STUDENT PROFILE
====================================";
const string CourseName = "C# Basic Course";
const string PlatformName = "Miyuki IT School";


Console.WriteLine();
Console.WriteLine(Header);
Console.WriteLine();
Console.WriteLine($"Course: {CourseName}");
Console.WriteLine($"Platform: {PlatformName}");
Console.WriteLine();
Console.WriteLine($"Name: {firstName.ToUpper()}");
Console.WriteLine($"Last name: {lastName.ToUpper()}");
Console.WriteLine($"City: {city}");
Console.WriteLine($"Career: {career}");
Console.WriteLine($"Programming language: {programmingLanguage}");
Console.WriteLine($"Favourite subject in CS: {favoriteCS}");
Console.WriteLine();
Console.WriteLine($"Your school e-mail: {firstName.ToLower()}.{lastName.ToLower()}{EmailDomain}");
Console.WriteLine($"Your motto: \"{motto}\"");
Console.WriteLine($"Motto lenght {motto.Length}");