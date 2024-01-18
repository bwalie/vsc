using System;
class program
{

    static void Main()

        {
            int[] arr1 = { 10, 20, 30, 40, 50 };
            int[] arr = { 11, 12, 13, 14, 15 };
            Parr(arr1);
            Parr(arr);
        }

        static void Parr(int[] arr2)
        {
        Console.WriteLine("Printing array elements");
            for(int i = 0; i < arr2.Length; i++)
            {
            Console.WriteLine(arr2[i]);

            }

        }

 }