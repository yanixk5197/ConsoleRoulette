namespace ConsoleRoulette;

public class Game
{
    public static void startGame()
    {
        var playerBank = new Bank(1000);
        Console.WriteLine(DefaultText.getFirstPlayText());
        RandomNum.makeRandomNum();
        Console.WriteLine($"Credit: {playerBank.getCredit()}\nset your bet:");
        while (true)
        {
            string bet = Console.ReadLine().ToLower();
            if (bet == "c")
            {
                Console.WriteLine($"\nNumber: {RandomNum.getRandomNum()}");
                Console.WriteLine($"Credit: {playerBank.getCredit()}\nset your bet:");
                RandomNum.makeRandomNum();
                continue;
            }
            
            if (IsValide.Valide(bet))
            {
                playerBank.addCredit(ExecuteBet.ExeBet(bet));
            }
            else if (!IsValide.Valide(bet))
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine($"\nsend 'c' to spin\nset your next bet:");
        }
    }
}