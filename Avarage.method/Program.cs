using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("first number");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("second number");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("thrid number");
        int n3= Convert.ToInt32(Console.ReadLine());

        double avg=average(n1, n2, n3);
        Console.WriteLine("average: " + avg);
    }
    static double average(int n1, int n2, int n3)
    {
        int sum = 0;
        for(int i = 0; i < 3; i++ ) 
        {
            sum += i;
        }
        double avg = sum/ 3;

        return avg;
    }

}