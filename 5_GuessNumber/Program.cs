using System;

class Program
{
    static void Main()
    {
        int correctNumber = new Random().Next(3) + 1;

        while (true)
        {
            Console.Write("Guess a number between 1 and 3: ");
            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Invalid guess. Number should be between 1 and 3.");
                continue;
            }

            if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Too low.");
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("Too high.");
            }
            else
            {
                Console.WriteLine("You guessed the correct number!");
                break;
            }
        }
    }
}