namespace ConsoleRoulette
{
    public class ExecuteBet
    {
        public static int ExeBet(string bet)
        {
            string[] parts = bet.Split(',');

            int value = int.Parse(parts[0].Trim());
            string sbet = parts[1].Trim();
            int randomNum = RandomNum.getRandomNum(); // zufällige Zahl zwischen 0-36

            switch (sbet)
            {
                case "1to12":
                    return (randomNum >= 1 && randomNum <= 12) ? value * 2 : value * -1;
                case "1to24":
                    return (randomNum >= 1 && randomNum <= 24) ? value * 2 : value * -1;
                case "1to36":
                    return (randomNum >= 1 && randomNum <= 36) ? value * 2: value * -1;
                case "1l":
                    return (randomNum % 3 == 1) ? value * 2 : value * -1;
                case "2l":
                    return (randomNum % 3 == 2) ? value * 2 : value * -1;
                case "3l":
                    return (randomNum % 3 == 0 && randomNum != 0) ? value * 1 : value * -1;
                case "red":
                    int[] red = {1,3,5,7,9,12,14,16,18,19,21,23,25,27,30,32,34,36};
                    return Array.Exists(red, n => n == randomNum) ? value : value * -1;
                case "black":
                    int[] black = {2,4,6,8,10,11,13,15,17,20,22,24,26,28,29,31,33,35};
                    return Array.Exists(black, n => n == randomNum) ? value : value * -1;
                case "even":
                    return (randomNum != 0 && randomNum % 2 == 0) ? value : value * -1;
                case "odd":
                    return (randomNum % 2 != 0) ? value : value * -1;
                case "":
                    return 0;
                default:
                    return (randomNum == int.Parse(sbet)) ? value * 36 : value * -1;
            }
        }
    }
}