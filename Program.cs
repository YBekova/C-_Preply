using C__Preply;

var account1 = new BankAccount("first", 1);

account1.ShowBankAccount();

var account2 = new BankAccount("Second account", 2);

account2.ShowBankAccount();

var account3 = new BankAccount("Third account", 10000);

account3.ShowBankAccount();

// var account4 = new BankAccount
// {
//     Balance = 5000,
//     InterestRate = 0.1m,
//     Owner = "John Doe"
// };

var account4 = new BankAccount();
account4.Balance = 5000;
account4.SetInterestRate(1000);
account4.ShowBankAccount();
