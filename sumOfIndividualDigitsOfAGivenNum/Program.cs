using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = cal(num);
        Console.WriteLine("the sum of the individual digit is :" + sum);
    }
    static int cal(int num)
    {
        string n1= Convert.ToString(num);

        int sum = 0;
        for (int i = 0; i< n1.Length; i++)
        {
            sum += Convert.ToInt32(n1.Substring(i, 1));
            
        }
        return sum;
    }
}