
public class BankAccount
{
    private double balance;

    public double Deposit(double value)
    {
        return balance += value;
    }

    public double GetBalance()
    {
        return balance;
    }
}

