using System;

class program
{
    static void Main()
    {
        Console.WriteLine("put a year");
        int y = Convert.ToInt32(Console.ReadLine());

        leapy(y);
    }
    static void leapy(int year)
    {
        if (year% 4 == 0)
        {
            Console.WriteLine("Leap year");
        }
        else
        {
            Console.WriteLine("not a leap year");
        }
    }
}