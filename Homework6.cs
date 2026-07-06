Console.Write("Enter your name: ");
string name = Console.ReadLine().Trim().ToUpper();

Console.Write("What's your age?: ");
bool ageCorrect = int.TryParse(Console.ReadLine(), out int age);

Console.Write("Number of available seats: ");
bool seatCorrect = int.TryParse(Console.ReadLine(), out int seats);

Console.Write("Do you have a ticket? Enter true or false: ");
bool ticketCorrect = bool.TryParse(Console.ReadLine(), out bool ticket);

Console.Write("Do you have an invitation? Enter true or false: ");
bool invitationCorrect = bool.TryParse(Console.ReadLine(), out bool invitation);

Console.Write("What is your role: ");
string role = Console.ReadLine().Trim().ToLower();


bool hasSeats = seats > 0;
bool isAdult = age >= 18;
bool hasTicketOrInvitation = ticket || invitation;
bool isVip = role == "vip";
bool roleValid = role == "guest" || role == "student" || role == "vip";

 bool canRegister =
            ageCorrect &&
            seatCorrect &&
            ticketCorrect &&
            invitationCorrect &&
            roleValid &&
            hasSeats &&
            hasTicketOrInvitation &&
            (isAdult || isVip);

const string Header =
@"========== REGISTRATION CHECK ==========";
Console.WriteLine($"\n{Header}");
Console.WriteLine($"\nName: {name}");
Console.WriteLine($"Role: {role}");

Console.WriteLine($"\nAge entered correctly: {ageCorrect}");
Console.WriteLine($"Available places entered correctly: {seatCorrect}");
Console.WriteLine($"Ticket entered correctly: {ticketCorrect}");
Console.WriteLine($"Invitation entered correctly: {invitationCorrect}");

Console.WriteLine($"\nIs adult: {isAdult}");
Console.WriteLine($"Has available places: {hasSeats}");
Console.WriteLine($"Has ticket or invitation: {hasTicketOrInvitation}");
Console.WriteLine($"Is VIP: {isVip}");
Console.WriteLine($"Role is valid: {roleValid}");



Console.WriteLine($"\nCan register: {canRegister}");
    