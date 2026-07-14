using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("Ivan", 1000.00);

        account.DisplayInfo();
        Console.WriteLine();

        account.Deposit(500.00);
        Console.WriteLine("Deposited $500.00");

        account.Withdraw(200.00);
        Console.WriteLine("Withdrew $200.00");

        Console.WriteLine();
        account.DisplayInfo();
    }
}