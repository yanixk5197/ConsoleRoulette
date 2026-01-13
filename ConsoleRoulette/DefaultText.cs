namespace ConsoleRoulette;

public class DefaultText
{
    private static string welcometext = """
    _________                            .__        __________             .__          __    __          
    \_   ___ \  ____   ____   __________ |  |   ____\______   \ ____  __ __|  |   _____/  |__/  |_  ____  
    /    \  \/ /  _ \ /    \ /  ___/  _ \|  | _/ __ \|       _//  _ \|  |  \  | _/ __ \   __\   __\/ __ \ 
    \     \___(  <_> )   |  \\___ (  <_> )  |_\  ___/|    |   (  <_> )  |  /  |_\  ___/|  |  |  | \  ___/ 
     \______  /\____/|___|  /____  >____/|____/\___  >____|_  /\____/|____/|____/\___  >__|  |__|  \___  >
            \/            \/     \/                \/       \/                       \/                \/ 
    By yanixk
    """;

    private static string firstplaytext = """
                                          Set your Bets in this format: (Money, Bet)
                                          for examle: 20, Red

                                          you can use this key-values:
                                          1 - 12: 1to12
                                          13 - 24: 1to24
                                          15 - 36: 1to36

                                          1st Line: 1L
                                          2nd Line: 2L
                                          3rd Line: 3L
                                          """;
    public static string getWelcomeText()
    {
        return welcometext;
    }
    
    public static string getFirstPlayText()
    {
        return firstplaytext;
    }
}