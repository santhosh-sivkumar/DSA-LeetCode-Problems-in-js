using Encapsulation;

BankAccount account = new BankAccount(1000);
account.Deposit(500);

Console.WriteLine($"Current Balance: {account.GetBalance()}");

account.Withdraw(300);
Console.WriteLine($"Balance after withdrawal: {account.GetBalance()}");

account.Withdraw(1500); // This will throw an exception due to insufficient funds