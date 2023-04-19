using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your birthdate (YYYY-MM-DD): ");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());

        TimeSpan ageInDays = DateTime.Now - birthdate;
        Console.WriteLine("You are {0} days old.", ageInDays.Days);

        int daysToNextAnniversary = 10000 - (ageInDays.Days % 10000);
        DateTime nextAnniversary = DateTime.Now.AddDays(daysToNextAnniversary);
        Console.WriteLine("Your next 10,000 day anniversary is on {0:yyyy-MM-dd}.", nextAnniversary);
    }
}