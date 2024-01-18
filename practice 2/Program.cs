using System;
using System.Data;
class program
{
    static void Main ()
    {
        Console.WriteLine("Enter the size of array");
        int ar=Convert.ToInt32 (Console.ReadLine());

        Array(ar);
    }
    static void Array(int ar)
    {
        int[]array= new int[ar];

        for (int i = 0; i < array.Length; i++) 
        {
            Console.WriteLine("Enter" + ar + "element of array");
            int nums= Convert.ToInt32 (Console.ReadLine());
            array[i] = nums;
        }
        for (int j = 0; j < array.Length; j++)
        {
            Console.WriteLine("Elements in array are :" + (array[j]));
        }
    }
}