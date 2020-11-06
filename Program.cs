using System;

namespace ABCInput
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Select a letter between A,B,C or Q to quit");
                var input = Console.ReadLine();

                if (input == "A" || input == "B" || input == "C")
                {
                    Console.WriteLine("Good Job!");
                }

                else if (input == "Q")
                {
                     Console.WriteLine("Bye!!");
                     break;
                }

                else
                {
                    Console.WriteLine("Error!");
                }

            }            
        }
    }
}
