using System;

public class Greeting
{
    public static void Main()
    {
        DateTime dt = DateTime.Now;
        int hours = dt.Hour;
        int minutes = dt.Minute;

        Console.WriteLine(hours);
        if(hours >= 1 && hours <= 12) { Console.WriteLine("Good Morning"); }
        if(hours >= 12 && hours <= 16) { Console.WriteLine("Good Afternoon"); }
        if(hours >= 16 && hours <= 21) { Console.WriteLine("Good Evening"); }
        if(hours >= 21 && hours <= 24) { Console.WriteLine("Good Night"); }

    }
}
