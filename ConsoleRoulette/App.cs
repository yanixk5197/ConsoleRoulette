class App
{
    public static string welcometext = """
                                       _________                            .__        __________             .__          __    __          
                                       \_   ___ \  ____   ____   __________ |  |   ____\______   \ ____  __ __|  |   _____/  |__/  |_  ____  
                                       /    \  \/ /  _ \ /    \ /  ___/  _ \|  | _/ __ \|       _//  _ \|  |  \  | _/ __ \   __\   __\/ __ \ 
                                       \     \___(  <_> )   |  \\___ (  <_> )  |_\  ___/|    |   (  <_> )  |  /  |_\  ___/|  |  |  | \  ___/ 
                                        \______  /\____/|___|  /____  >____/|____/\___  >____|_  /\____/|____/|____/\___  >__|  |__|  \___  >
                                               \/            \/     \/                \/       \/                       \/                \/ 

                                       By yanixk

                                       Press Entre to start:
                                       """;
    public static int credit;

    static void Main(string[] args)
    {
        Console.Write(welcometext);
        Console.ReadLine();
        Console.Write("Bitte gib den Startbetrag ein: ");
        int credit = TryParse(Console.ReadLine());
    }
}