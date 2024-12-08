using System;

namespace T2
{
    public static class GuessGame
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 11); // Número secreto entre 1 y 10
            Console.WriteLine(secretNumber);
            int attempts = 3;

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("You have 3 attempts to guess the secret number (1-10).\n");

            while (attempts > 0)
            {
                Console.Write($"Attempts left: {attempts}. Guess the secret number: ");
                
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    if (guess == secretNumber)
                    {
                        Console.WriteLine("🎉 Congratulations! You guessed the secret number!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(guess > secretNumber 
                            ? "Incorrect! The secret number is lower." 
                            : "Incorrect! The secret number is higher.");
                    }
                }
                else
                {
                    Console.WriteLine("❌ Invalid input. Please enter a number between 1 and 10.");
                }

                attempts--;
            }

            if (attempts == 0)
            {
                Console.WriteLine($"Game Over! The secret number was: {secretNumber}");
            }
        }
    }
}