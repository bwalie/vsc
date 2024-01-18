using System;

class Program
{
    // Method with no parameters and no return value (void)
    public static void SayHello()
    {
        Console.WriteLine("Hello, World!");
    }

    // Method with parameters and a return value
    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        // Calling the SayHello method
        SayHello();

        // Calling the AddNumbers method and printing the result
        int result = AddNumbers(5, 3);
        Console.WriteLine("The sum is: " + result);
    }
}
