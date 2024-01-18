using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Supplied arguements are:");
        string sa = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Argeument Length:" + args.Length);
        


        foreach(object i in sa) 
        {
            Console.WriteLine(i);
        }
    }
}