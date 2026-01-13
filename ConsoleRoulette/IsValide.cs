using System;

namespace ConsoleRoulette
{
    public class IsValide
    {
        public static bool Valide(string bet)
        {
            string[] parts = bet.Split(',');

            if (parts.Length != 2)
            {
                Console.WriteLine("Syntax error");
                return false;
            }
            
            string amountStr = parts[0].Trim();
            string choice = parts[1].Trim().ToLower();
            
            if (!int.TryParse(amountStr, out int amount))
            {
                Console.WriteLine("Syntax error");
                return false;
            }
            
            if (int.TryParse(choice, out int numberChoice))
            {
                return numberChoice >= 0 && numberChoice <= 36;
            }

            string[] validChoices = {
                "even", "odd", "1to12", "13to24", "25to36",
                "1l", "2l", "3l", "2to1-1", "2to1-2", "2to1-3",
                "red", "black"
            };

            if (Array.Exists(validChoices, c => c == choice))
            {
                return true;
            }

            Console.WriteLine("Ungültige Wahl!");
            return false;
        }
    }
}