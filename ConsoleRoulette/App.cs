using ConsoleRoulette;

class App
{ static void Main(string[] args)
    {
        Console.WriteLine(DefaultText.getWelcomeText());
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
        Game.startGame();
    }
}