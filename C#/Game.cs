using System;

class Program
{
    static void Main()
    {
        int score = 5;
        Random random = new Random();
        int month = random.Next(1, 13);
        int guess;

        Console.WriteLine("Enter the number of your birth month (1-12).");
        Console.Clear();

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Your guess? ");
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess == month)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win!");
                    Console.WriteLine("Your score: {0}", score);
                    break;
                }
                else
                {
                    score -= 1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 12.");
            }
        }

        if (score == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You lost! The correct month was: {0}", month);
        }

        Console.ResetColor();
    }
}