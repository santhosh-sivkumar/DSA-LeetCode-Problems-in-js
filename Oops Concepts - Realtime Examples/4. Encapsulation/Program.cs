using Encapsulation;

// ====================== BAD (No Encapsulation) ======================
// BadBankAccount has a public 'balance' field — anyone can read/write it directly.
// There is zero validation. Any value can be set, including negatives.

BadBankAccount badAccount = new BadBankAccount();
badAccount.balance = 1000;       // direct access
badAccount.balance = -99999;     // PROBLEM: nothing stops this! Balance is now negative.
badAccount.balance = 0;          // PROBLEM: wiped to zero with one line — no rules at all.
Console.WriteLine($"[BAD]  Balance can be anything: {badAccount.balance}");

Console.WriteLine();

// ====================== GOOD (With Encapsulation) ======================
// BankAccount keeps 'balance' private — it cannot be touched directly from outside.
// All changes go through methods that validate every action.

BankAccount account = new BankAccount(1000);
account.Deposit(500);
Console.WriteLine($"[GOOD] Balance after deposit:    {account.GetBalance()}");  // 1500

account.Withdraw(300);
Console.WriteLine($"[GOOD] Balance after withdrawal: {account.GetBalance()}");  // 1200

// account.balance = -99999;  <-- Won't compile — 'balance' is private.
account.Withdraw(1500);        // <-- Throws: "Insufficient funds for this withdrawal."