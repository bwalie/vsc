using System;
class calculator
{
    public static double Operation(double num1, double num2, string op)
    {
        double result = 0;
        switch (op)
        {
            case"a":
                result = num1 + num2;
                break;
            case "b":
                result = num1 - num2;
                break;
            case"c" :
                result = num1 * num2;
                break;
            case "d":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }

                break; 
                default:
                break; 
        }

        return result;
    }
}

class Program
{
    static void Main(string[]args)
    {
        bool endApp = false;
        Console.WriteLine("Console Calculator in C# App: ");
        Console.WriteLine("-------------------------------");

        while (!endApp)
        {
            string numInput1 = " ";
            string numInput2 = " ";
            double result = 0;
            
            Console.Write("Type a number, and then press enter");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not a valid input, Please enter interger");
                numInput1 = Console.ReadLine();
            }
            Console.Write("Type a number, and then press enter");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("This is not a valid input, Please enter interger");
                numInput2 = Console.ReadLine();
            }
            Console.WriteLine("Choose an option from the menu: ");
            Console.WriteLine("\ta - Add: \n");
            Console.WriteLine("\ts - Subtract: ");
            Console.WriteLine("\tm - Multiply: ");
            Console.WriteLine("\td - Divide: ");
            Console.WriteLine(" Your option");

            String op = Console.ReadLine();

            try
            {
                result = calculator.Operation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result)) 
                {
                    Console.WriteLine("This operation will result in mathematical error");
                }
                else
                {
                    Console.WriteLine("your result :\n" + result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oh shit! An exception occured trying to do the math. " + "\n - Details: e.Message");
                
            }
            Console.WriteLine("----------------------");
            Console.Write("Press 'n' and Enter to close the app, or press any other key");
            if (Console.ReadLine() == "n")
                endApp = true;
            Console.WriteLine("\n");
        }

        return;

    }
    
}