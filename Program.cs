using System;

namespace NumberGuessingGame
{
    class Program
    {
         static void Main()
        {
            Random r = new Random();

            int winNum = r.Next(1, 100);

            bool win = false;

            do
            {
                Console.WriteLine(" ");
                Console.Write("Guess a number between 1-100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if(i> winNum)
                {                    
                    Console.WriteLine(" ");
                    Console.WriteLine("Too high!  Guess lower...");
                }
                else if(i < winNum)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Too low!  Guess higher...");
                }
                else if(i == winNum)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("You have won!");
                    win = true;
                }
            }
            while (win == false);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Would you like to play again? (Yes/No)");
            string replay = Console.ReadLine();


            if (replay == "Yes" || replay == "yes")
            {
                Console.Clear();
                win = false;
                Main();
            }            
        }
    }
}
