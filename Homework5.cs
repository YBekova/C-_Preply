const int AdultAge = 18;
const int MinimumPoints = 60;
const int DiscountPoints = 100;

Console.Write("Enter your name: ");
string name = Console.ReadLine().Trim();

Console.Write("What's your age?: ");
int age = Convert.ToInt32(Console.ReadLine().Trim());

Console.Write("How namy points you have?: ");
int points = Convert.ToInt32(Console.ReadLine().Trim());

Console.Write("Do you have a ticket? Enter true or false: ");
bool ticket = bool.Parse(Console.ReadLine().Trim());

Console.Write("Do you have a promocode? Enter true or false: ");
bool hasPromoCode = bool.Parse(Console.ReadLine().Trim());

Console.Write("What is your role: ");
string role = Console.ReadLine().Trim().ToLower();

bool isAdult = age >= AdultAge;
bool isNotAdult = isAdult != true; 
bool hasEnoughPoints = points >= MinimumPoints;
bool canGetDiscount = hasPromoCode || points >= DiscountPoints;
bool canEnter = isAdult && ticket;
bool hasAccess = (role == "admin" || role == "moderator") && isAdult;

const string Header =
@"========== USER CHECK ==========";
Console.WriteLine($"\n{Header}");
Console.WriteLine($"\nUser: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Role: {role}");


Console.WriteLine($"\nAdult of age: {isAdult}");
Console.WriteLine($"Has enough point: {hasEnoughPoints}");
Console.WriteLine($"Can enter: {canEnter}"); 
Console.WriteLine($"Can get a discount: {canGetDiscount}");
Console.WriteLine($"Can edit: {hasAccess}");
Console.WriteLine($"Is not of legal age: {isNotAdult}"); 


