const int MinimumAge = 16;
const int MinimumHoursPerWeek = 5;
const int MinimumTestScore = 60;

Console.Write("Enter your name: ");
string name = Console.ReadLine().Trim().ToUpper();

Console.Write("Your age: ");
bool ageCorrect = int.TryParse(Console.ReadLine(), out int age);

Console.Write("Enter your city: ");
string city = Console.ReadLine().Trim();

Console.Write("How many free hours you have in a week?: ");
bool hoursCorrect = int.TryParse(Console.ReadLine(), out int hours);

Console.Write("How many point you had at entrance test?: ");
bool testPointsCorrect = int.TryParse(Console.ReadLine(), out int testPoints);

Console.Write("Do you havae a laptop? Enter true or false: ");
bool laptopCorrect = bool.TryParse(Console.ReadLine(), out bool laptop);

Console.Write("Do you have coding experience? Enter true or false: ");
bool experienceCorrect = bool.TryParse(Console.ReadLine(), out bool experience);

Console.Write("What's your desired direction in Tech?: ");
string techDirection = Console.ReadLine().Trim().ToLower();

bool ageLimit = age >= MinimumAge;
bool enoughHours = hours >= MinimumHoursPerWeek;
bool enoughPoints = testPoints >= MinimumTestScore;
bool hasLaptop = laptop == true;
bool hasCodingExperience = experience == true;
bool directionBackEnd = techDirection == "backend";
bool directionFrontEnd = techDirection == "frontend";
bool directionQA = techDirection == "qa";
bool directionGameDev = techDirection == "game dev";
bool hasEnoughPointsForAdvancedGroup = testPoints >= 85;
bool canJoinAdvancedGroup = hasEnoughPointsForAdvancedGroup && hasCodingExperience && (directionBackEnd || directionGameDev);

const string Header =
@"========== COURSE APPLICATION ==========";
Console.WriteLine($"\n{Header}");
Console.WriteLine($"\nName: {name}");
Console.WriteLine($"City: {city}");
Console.WriteLine($"Direction: {techDirection}");
if (ageLimit) Console.WriteLine("\nYour age is correct for this programm");
if (!ageLimit)
{
    Console.WriteLine("Your age is incorrect for this programm! Come back when your age will be 16 y.o.");
    return;
}
if (enoughHours) Console.WriteLine("You have enough hours to participate in this programm");
if (enoughPoints) Console.WriteLine("You have enough point to participate in this programm");
if (!enoughPoints)
{
    Console.WriteLine("You don't have enough point! Re-take the test and cone back when the point will be minimum = 60");
    return;
}

if (hasLaptop) Console.WriteLine("You have a laptop");
if (!hasLaptop)
{
    Console.WriteLine("If you don't have a laptop go to receptionist and leave a request for a laptop");
    return;
}
if (ageLimit && enoughHours) Console.WriteLine("You have enough hours and correct age for this programm");
if (enoughPoints && hasLaptop) Console.WriteLine("You have enough points and laptop for this programm");
if (ageLimit && enoughHours && enoughPoints && hasLaptop) Console.WriteLine("You can start basic educational programm. Congratulations!");
if (!hasCodingExperience) Console.WriteLine("You don't need coding experience for this porgramm.");
if (canJoinAdvancedGroup) Console.WriteLine($"Can join the advanced group: {canJoinAdvancedGroup}");

