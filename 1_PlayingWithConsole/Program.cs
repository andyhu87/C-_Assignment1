using System;

class Program {
    static void Main() {
        Console.WriteLine("What is your favorite color?");
        string favoriteColor = Console.ReadLine();

        Console.WriteLine("What is your astrology sign?");
        string astrologySign = Console.ReadLine();

        Console.WriteLine("What is your street number?");
        string streetNum = Console.ReadLine();

        string hackerName = $"{favoriteColor}{astrologySign}{streetNum}";

        Console.WriteLine($"Your Hacker Name is {hackerName}.");
    }


}


