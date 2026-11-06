namespace C__Preply;

class BankAccount
{
    public decimal Balance
    {
        get;
        private set;
    } = 100m;
    
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Сумма должна быть больше нуля");
        }
        
        Balance += amount;
    }
    
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Сумма должна быть больше нуля");
        }
        
        if (amount > Balance)
        {
            throw new InvalidOperationException("Недостаточно средств");
        }
        
        Balance -= amount;
    }
}
