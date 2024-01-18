using System;
class program
{
    static void Main()
    {

        repeatchar();
        

    }
    static void repeatchar()
    {
        for(int l=0; l<3; l++)
        {
            Console.WriteLine("enter a character");
            string ch = Convert.ToString(System.Console.ReadLine());


            for (int i = 0; i <= 25; i++)
            {
                if (ch.Equals("*"))
                    {
                    Console.WriteLine("*");
                }
            }
            for(int j= 0; j<= 10; j++)
            {
                if(ch.Equals("=")) 
                {
                    Console.WriteLine("=");

                }
                for (int k = 0; k <= 20; k++) 

                {
                    if(ch.Equals("-"))
                    {
                        Console.WriteLine("-");
                    }
                }
            }
        }
    }
}