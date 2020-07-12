using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MATRIX";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            void PillPrompt()
            {
                Console.WriteLine("Red pill or blue pill? [R/B]");
                string answer = Console.ReadLine();

                if (answer == "R")
                {
                    Console.WriteLine("I see. So you have chosen to live in the truth. Come with me. (Press any key to continue)");
                    return;
                }
                else if (answer == "B")
                {
                    Console.WriteLine("I understand. The truth can be harsh. Ignorance is bliss after all. You won't see me again");
                    return;
                }
                else
                {
                    Console.WriteLine("Don't get sidetracked. Please answer the question.");
                    PillPrompt();
                    return;
                }
            }

            PillPrompt();

            Console.ReadKey();
        }
    }
}
