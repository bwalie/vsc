using System;
class program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Enter the base");
        int bn = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the power");
        int p = Convert.ToInt32(Console.ReadLine());

        cal(bn, p);
    }
    static void cal(int bn, int p)
    {
        double result = Math.Pow(bn, p);
        Console.WriteLine("result" + result);

    }
}