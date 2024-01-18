using System;
class program
{
    static void Main()
    {
        int f;
        Console.WriteLine("Enter a Number");
        int num = Convert.ToInt32 (Console.ReadLine());

        f= cal(num);
        Console.WriteLine("The factorial of the"+ num +"!= "+f);
    }
    static int cal(int num)
    {
        if (num == 0) 
        {
            return 1;
        }
        else
        {
            return num* cal(num-1);
        }
    }
}
