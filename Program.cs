using System;


namespace NumberGuesser
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Hello What is your name?");

            string username = Console.ReadLine();

            Console.WriteLine("HELLO {0} let's play a game",username);

            int correctNumber = 8;
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");
            
            while (guess != correctNumber)
            {
                Console.ForegroundColor = ConsoleColor.White;
                // Get user input
                string userGuess = Console.ReadLine();

                // cast to int and put in guess
                guess = Int32.Parse(userGuess);

                if(guess == correctNumber){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You guessed correct heres a cookie");
                }else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong guess again");
                }
            }
        }
    }
}

