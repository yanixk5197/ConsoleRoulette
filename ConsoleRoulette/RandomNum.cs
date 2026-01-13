using System;

namespace ConsoleRoulette
{
    public class RandomNum
    {
        private static int num;
        private static Random rnd = new Random();

        public static void makeRandomNum()
        {
            num = rnd.Next(0, 37);
        }

        public static int getRandomNum()
        {
            return num;
        }
    }
}