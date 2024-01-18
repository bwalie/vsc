using System;
    class program
{
    static void Main()
    {
        Console.WriteLine("Enter first num");
        int n1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second num");
        int n2=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter third num");
        int n3= Convert.ToInt32(Console.ReadLine());
        GetMinMax(n1 , n2, n3);

    }
    static void GetMinMax(int n1, int n2, int n3)
    {
        int min= Math.Min(n1,Math.Min( n2, n3));
        int max= Math.Max(n1,Math.Max (n2, n3));

        Console.WriteLine("Maxium:" + max);
        Console.WriteLine("Minium" + min);
    }
}