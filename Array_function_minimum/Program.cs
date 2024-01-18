using System;
class program 
{
    static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int[] arr1 = { 11,12,13,14,15 };
        pMin(arr);
        pMin(arr1);
        pMax(arr);
        pMax(arr1);

    }
    static void pMin(int[]arr2)
    {
        int min = arr2[0];
        for(int i= 1; i<arr2.Length; i++)
        {
            if (min > arr2[i])
            {
               min= arr2[i];

            }
        }

        Console.WriteLine("Minimum element is:" + min);


    }
    static void pMax(int[]arr3)
    {
        int max= arr3[0];
        for(int i=1; i<arr3.Length; i++)
        {
            if (max < arr3[i])
            {
                max = arr3[i];
            }
        }
        Console.WriteLine("Maxium element is " + max);
    }
}