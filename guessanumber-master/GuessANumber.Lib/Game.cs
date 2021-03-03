using System;
using GuessNumber.Lib.Resources;

namespace GuessNumber.Lib
{
    public static class Game
    {
        public static void Play()
        {
            Console.WriteLine(Messages.Welcome);
            Console.WriteLine();
            var random = new Random();
            var play = true;
            while (play)
            {
                Console.WriteLine(Messages.GameStart);
                Console.WriteLine();
                var secretNumber = random.Next(0, 101);
                GuessNumber(secretNumber);
                play = OneMore();
                if (play)
                {
                    Console.Clear();
                }
            }
            Console.WriteLine(Messages.GameOver);
        }

        public static void GuessNumber(int secretNumber)
        {
            bool isGuessed;
            do
            {
                var userNumber = PromptNumber();
                isGuessed = CheckNumber(userNumber, secretNumber);
            } while (isGuessed != true);
        }

        public static bool CheckNumber(int userNumber, int secretNumber)
        {
            if (secretNumber == userNumber)
            {
                Console.WriteLine(Messages.Win);
                return true;
            }
            Console.WriteLine(userNumber < secretNumber ? Messages.Small : Messages.Big);
            return false;
        }

        public static bool OneMore()
        {
            Console.Write(Messages.NewGame);
            var userInput = Console.ReadLine();
            while (userInput.ToUpper() != "N" && userInput.ToUpper() != "Y")
            {
                Console.Write(@"Please enter 'Y' for yes or 'N' for no: ");
                userInput = Console.ReadLine();
            }

            return userInput.ToUpper() == "Y";
        }

        public static int PromptNumber()
        {
            int userNumber;
            bool isNumber;
            do
            {
                Console.Write(Messages.PromptNumber);
                var userInput = Console.ReadLine();
                isNumber = int.TryParse(userInput, out userNumber);
                if (isNumber) continue;
                Console.Write($@"'{userInput}'");
                Console.WriteLine(Messages.NotANumber);
            } while (!isNumber);

            return userNumber;
        }
    }
}
