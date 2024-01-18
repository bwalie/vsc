using System;

class program
{
    static void ShowChoice()
    {
        Console.WriteLine("enter choice 1 to 4");
        Console.WriteLine("1   Add");
        Console.WriteLine("2   Subtract");
        Console.WriteLine("3   Multiply");
        Console.WriteLine("4   Divide");

    }
    static int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
    static int subtract(int a, int b)
    {
        return a - b;
    }
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static int divide(int a, int b)
    {
        return a/b ;
    }

    static void Main()
    {
        string ans;
        do
        {
            Console.WriteLine("Enter the first num");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second num");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your choice 1-4");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Add" + Add(num1, num2));

            }
            else if (choice == 2)
            {
                Console.WriteLine("subtract " + subtract(num1, num2));
            }
            else if (choice == 3)
            {
                Console.WriteLine("Multiply " + Multiply(num1, num2));
            }
            else if (choice == 4) 
            {
                Console.WriteLine("divide " + divide(num1, num2));
            }
            else
            {
                Console.WriteLine("1- 4 dumbass");
            }

            Console.WriteLine("do you want to continue or not");
            ans = Console.ReadLine();


        }
        while (ans.Equals("yes"));
        
    }    


    

    
}