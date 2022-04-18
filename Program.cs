using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            bool whileloopActive = true; //boolean - ячейка памяти, в которой true/false
            int counter = 0; //это значение каждый раз прописывает порядковый номер

            while (whileloopActive) //в скобках уcловие true
            {
                Console.WriteLine("Haaaaayyyyy");//после каждой фразы каунтер будет писать порядковый номер
                Console.WriteLine(counter);
                counter++; //это выражение увеличивает на +1

                if (counter == 100)
                {
                    Console.WriteLine(counter);
                    Console.WriteLine("Loop stopped");
                    break; //разрывает круг замкнутости - вырываемся из команды
                    // вместо break может написать loopActive = false; 
                }
            }
            Console.WriteLine("have a nice day");

            Console.WriteLine();





            bool loopActive = true;
            //Console.WriteLine("Enter u PIN:"); если за пределами блока while - то спросят один раз ПИН, а нам надо, что бы он постоянно спрашивал
            int tries = 0;

            while (loopActive)
            {
                if (tries == 3) //!= означает не равно
                {
                    Console.WriteLine($"U have tried to log in {tries} times. Login failed. No attempts left. Try again later.");
                    break;
                }    
                Console.WriteLine("Pleace, enter u PIN:");
                string userPIN = Console.ReadLine();

                if (userPIN == "1234")
                {
                    Console.WriteLine("Welcome");
                    loopActive = false; //или же break
                }
                else
                {
                    Console.WriteLine($"Invalid PIN. U have made {tries + 1}/3 attempts");
                    tries++;
                }
            }
            // ИЛИ ТАКОЙ ВАРИАНТ

            //int tries = 0;
            //while (tries != 3)  != означает не равно
            //{
            //   Console.WriteLine("Pleace, enter u PIN:");
            //    string userPIN = Console.ReadLine();
            //    if (userPIN == "1234")
            //   {
            //       Console.WriteLine("Welcome");
            //       break;
            //    }
            //   else
            //    {
            //       Console.WriteLine($"Invalid PIN. U have made {tries + 1}/3 attempts");
            //       tries++;
            //    }
        }
    }
}
