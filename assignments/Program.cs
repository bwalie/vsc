using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a character:");
        string input = Console.ReadLine();

        if ((input[0] >= 'a' && input[0] <= 'z') || (input[0] >= 'A' && input[0] <= 'Z'))
        {
            Console.WriteLine("Character");
        }
        else if (input[0] >= '0' && input[0] <= '9')
        {
            Console.WriteLine("Digit");
        }

        else
        {
            Console.WriteLine("special character");
        }



        }
       
}
