using System;

class Program {
    static void Main() {
        DateTime currentTime = DateTime.Now;
        int currentHour = currentTime.Hour;

        if (currentHour >= 6 && currentHour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        else if (currentHour >= 12 && currentHour < 17)
        {
            Console.WriteLine("Good Afternoon");
        }
        else if (currentHour >= 17 && currentHour < 21)
        {
            Console.WriteLine("Good Evening");
        }
        else
        {
            Console.WriteLine("Good Night");
        }

    }
}