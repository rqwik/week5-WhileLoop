using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Number =  rnd.Next(1, 11);
            int count = 1;

            Console.WriteLine("Try to guess my number. It was from 0 to 10 only. But remember - u have 3 tries only!");
            Console.WriteLine("Pleace, enter your first number:");
            int i = Convert.ToInt32(Console.ReadLine());

            while (count <= 3)
            {
                if (Number == i)
                {
                    Console.WriteLine("U Win! Computer guessed the number " + i + "!");
                    break;
                }              
                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine("Computer Win, U Loose! It was a number " + Number + "!");
                        break;
                    }
                }
                Console.WriteLine("Nope, it isn't a number " + i + "! Attempt no " + count + ":");
                i = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
