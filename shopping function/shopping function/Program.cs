using System;

class Program
{
    static void Main()
    {
        shopping();
    }
    public static void shopping()
    {
        string userInput, trymore = "";
        string item;
        double price;
        int total = 0, quantity, cash, refund;
        int stkQuantity;
        do
        {
            Console.WriteLine("Available Items, Pleace Choose! \n");
            Console.WriteLine("(1) mouse- (2) Ballpen- (3) Book \n");

            userInput = Console.ReadLine();

            if (userInput.Equals("mouse"))
            {
                Console.WriteLine("Enter Quantity");
                quantity = Convert.ToInt32(Console.ReadLine());

                total = 8000 * quantity;
                Console.WriteLine("total\t" + total + "\n");

                Console.WriteLine("Enter Cash\n");
                cash = Convert.ToInt32(Console.ReadLine());

                Console.ReadLine();

                if (cash < total)
                {
                    Console.WriteLine("cash is not enough");
                }
                else if (cash > total)
                {
                    refund = cash - total;
                    Console.WriteLine("Refund " + refund + "\n");
                }
                else
                {
                    Console.WriteLine("Refund zero!");

                }

                Console.WriteLine("Thank you come again");
            }


            else if (userInput.Equals("Ballpen"))
            {
                Console.WriteLine("Enter Quantity");
                quantity = Convert.ToInt32(Console.ReadLine());

                total = 500 * quantity;
                Console.WriteLine("total\t" + total + "\n");

                Console.WriteLine("Enter Cash\n");
                cash = Convert.ToInt32(Console.ReadLine());

                Console.ReadLine();

                if (cash < total)
                {
                    Console.WriteLine("cash is not enough");
                }
                else if (cash > total)
                {
                    refund = cash - total;
                    Console.WriteLine("Refund " + refund + "\n");
                }
                else
                {
                    Console.WriteLine("Refund zero!");

                }

                Console.WriteLine("Thank you come again");
            }

            else if (userInput.Equals("Book"))
            {
                Console.WriteLine("Enter Quantity");
                quantity = Convert.ToInt32(Console.ReadLine());

                total = 600 * quantity;
                Console.WriteLine("total\t" + total + "\n");

                Console.WriteLine("Enter Cash\n");
                cash = Convert.ToInt32(Console.ReadLine());

                Console.ReadLine();

                if (cash < total)
                {
                    Console.WriteLine("cash is not enough");
                }
                else if (cash > total)
                {
                    refund = cash - total;
                    Console.WriteLine("Refund " + refund + "\n");
                }
                else
                {
                    Console.WriteLine("Refund zero!");

                }

                Console.WriteLine("Thank you come again");
            }
            else
            {
                Console.WriteLine("sorry, this item is not availible \n");
            }

            Console.WriteLine("do you want to Continue? Yes or No");
            trymore = Console.ReadLine();

        } while (trymore.Equals("y"));
    }
    
}