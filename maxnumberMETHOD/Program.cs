using System;
 
class program
{
    static void Main()
    {
        Console.WriteLine("Enter the first num");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second num");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third num");
        int num3 = Convert.ToInt32(Console.ReadLine());

        max(num1, num2, num3);

    }
    
   static void max(int a, int b, int c)
    {
        if (a > b && a > c)
        {
            Console.WriteLine("a is the largest" + a);
        }
        else if (b > a && b > c) 
        {
            Console.WriteLine("b is the largest" + b);
        }
        else
        {
            Console.WriteLine("c is the largest" + c);
        }
        
    }
        

    

}


    