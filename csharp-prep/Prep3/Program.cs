using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int magicNumber = rand.Next(1, 101);

        Console.WriteLine("Welcome to the magic number game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100.");
        Console.WriteLine("Can you guess what it is?");

        int guess;
        bool guessedCorrectly = false;

        while (!guessedCorrectly)
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is too low. Try again.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Your guess is too high. Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number!");
                guessedCorrectly = true;
            }
        }

        Console.WriteLine("Thanks for playing!");
        Console.ReadLine();
    }
}