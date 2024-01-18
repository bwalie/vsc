using System;
class Program
{
    static void Main()
    {
        // Sample array
        int[] originalArray = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original Array:");
        PrintArray(originalArray);

        // Reverse the array
        ReverseArray(originalArray);
        Console.WriteLine("\nReversed Array:");
        PrintArray(originalArray);
    }

    static void ReverseArray(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            // Swap elements at i and length - i - 1
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}


