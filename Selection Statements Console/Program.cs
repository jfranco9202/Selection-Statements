using System;

namespace Selection_Statements_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 100;

            Console.WriteLine("Guess my number that is a common number that has 3 integers?");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < myNumber)
            {
                Console.WriteLine("Too Low!!!");
            }

            else if (userGuess > myNumber)
            {
                Console.WriteLine("Too High!!!");
            }


            else if (userGuess == myNumber)
            {
                Console.WriteLine("Great job you know my number!!");
            }

            else
            {
                Console.WriteLine("Nevermind");
            }


        }
    }
     
    
    
}
