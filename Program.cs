using C__Preply;

var account = new BankAccount();

try
{
    account.Withdraw(150m);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}