using System;

namespace SumOfRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0; //i - iteration - одно запускание цикла
            Random rnd = new Random();

            while(i != 10)
            {
                int myRandom = rnd.Next(1, 11);
                Console.WriteLine($"Step {i+1}. U generated {myRandom}");
                sum = sum + myRandom;
                i++;
            }

            Console.WriteLine($"Summa of random numbers: {sum}");
        }
    }
}
