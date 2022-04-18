using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            int rand = new Random().Next(1,11);
            Console.WriteLine("Try to guess my number. It was from 0 to 10 only.");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == rand.ToString())
                {
                    Console.WriteLine($"U are right. The answer is {rand}.");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong! Try again!");
                }
            }
        }
    }
}
