namespace C__Preply;

public class GymMembership
{
    public static int MembershipCount;
    public string OwnerName { get; }

    public int MonthlyCost
    {
        get;
        private set
        {
            if (value > 0)
            {
                field = value;
            }
            else
            {
                Console.WriteLine("Monthly cost can't be = 0 or less than a 0!");
            }
        }
    }

    public int PaidMonthsAmount{ get; private set; }
    
    public bool IsActive { get; set ; }
    
    public int TotalCost => MonthlyCost * PaidMonthsAmount;
    public int ShowPaidMonthsAmount => PaidMonthsAmount * MonthlyCost;

    public GymMembership (string ownerName) : this(ownerName, 1200)
    { }

    public GymMembership(string ownerName, int monthlyCost)
    {
        OwnerName = ownerName;
        MonthlyCost = monthlyCost;
        MembershipCount++;
    }

    public void Activate()
    {
        if (MonthlyCost <= 0)
        {
            Console.WriteLine("Membership can't be activated because monthly cost must be greater than 0!");
        }
        else if (IsActive)
        {
            Console.WriteLine("Membership is already active!");
        }
        else
        {
            IsActive = true;
            PaidMonthsAmount = 1;
        }
    }

    public void Activate(int months)
    {
        if (MonthlyCost <= 0)
        {
            Console.WriteLine("Membership can't be activated because monthly cost must be greater than 0!");
        }
        else if (months <= 0)
        {
            Console.WriteLine("Months amount must be greater than 0!");
        }
        else if (IsActive)
        {
            Console.WriteLine("Membership is already active!");
        }
        else
        {
            IsActive = true;
            PaidMonthsAmount = months;
        }
    }
    
    public int Extend(int months)
    {
        if (IsActive && months > 0)
        {
            PaidMonthsAmount += months;
        }
        else
        {
            Console.WriteLine("You can't extends  deactivated membership!");
        }

        return PaidMonthsAmount;
    }

    public void Cancel()
    { 
        PaidMonthsAmount = 0;
        IsActive = false;

    }

    public void ShowInfo()
    {
        Console.WriteLine($"Members name - {OwnerName}, " +
                          $"Paid Months {PaidMonthsAmount}, " +
                          $"is Active {IsActive}, " +
                          $"Monthly cost {MonthlyCost}, " +
                          $"Total membership cost - {TotalCost}");
    }

    public static void ShowMembershipCount()
    {
        Console.WriteLine($"The amount of memberships - {MembershipCount}");
    }
}