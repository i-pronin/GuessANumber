using System;
using GuessNumber.Lib;

namespace GuessANumber
{
    class Program
    {
        public static int SecretNumber = 0;

        static void Main(string[] args)
        {
            Game.Play();
        }
    }
}
