namespace ConsoleRoulette;

public class Bank
{
    private double credit;

    public Bank(double credit)
    {
        this.credit = credit;
    }

    public double getCredit()
    {
        return this.credit;
    }

    public void addCredit(double amount)
    {
        this.credit += amount;
    }
}