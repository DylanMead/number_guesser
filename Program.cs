using System;

// Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            // Run function to get info
            GetAppInfo();

            GreetUser();

            while (true)
            {
                // Init correct number
                //int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                // Generate random number between 1 and 10
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                //Ask user to guess number
                Console.WriteLine("Guess a number between 1 and 10");

                // While incorrect guess
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure is number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                // Ask user if they want to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                } else if (answer == "N") {
                    return;

                }
                else
                {
                    return;
                }

            }
        }

        // Get and display app info
        static void GetAppInfo()
        {
            //Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dylan Mead";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Change color back
            Console.ResetColor();
        }

        // Ask name and greet user
        static void GreetUser()
        {
            // Ask user for name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user not number
            Console.WriteLine(message);

            // Change color back
            Console.ResetColor();
        }
    }
}
