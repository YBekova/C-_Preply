namespace C__Preply;

class BankAccount
{
    public string Owner;
    public decimal Balance;
    
    private decimal InterestRate;
    
    public BankAccount(){ }

    public BankAccount(decimal interestRate)
    {
        InterestRate = interestRate;
    }
    
    public BankAccount(string owner, decimal balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public void ShowBankAccount()
    {
        Console.WriteLine(Owner + " " + Balance + " " + InterestRate);
    }

    public void SetInterestRate(decimal interestRate)
    {
        if (interestRate > 100)
        {
            Console.WriteLine("Insufficient interest rate");
        }
        else
        {
            InterestRate = interestRate;
        }
    }
}