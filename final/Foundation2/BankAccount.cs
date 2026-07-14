public class BankAccount
{
    private string _owner;
    private double _balance;

    public BankAccount(string owner, double balance)
    {
        _owner = owner;
        _balance = balance;
    }

    public void Deposit(double amount)
    {
        _balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > _balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            _balance -= amount;
        }
    }

    public double GetBalance()
    {
        return _balance;
    }

    public string GetOwner()
    {
        return _owner;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Account Owner: {_owner}");
        Console.WriteLine($"Current Balance: ${_balance}");
    }
}