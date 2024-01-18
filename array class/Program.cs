using System;
class program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[6] { 1, 2, 3, 4, 2, 3 };
        int[] arr1 = new int[6];


            Console.WriteLine("Length of first array: " + arr.Length);

        Array.Sort(arr);
        Console.WriteLine("First array Elements");
        PrintArray(arr);
        Array.Copy(arr, arr1, arr.Length);
        Console.Write("Second array Element:");
        PrintArray(arr);

        Array.Reverse(arr);
        Console.Write("\nFirst Array elements in reverse order");
    }

    static void PrintArray(int[] arr)
    {
        foreach(Object o in arr)
        {
            Console.WriteLine(o + " ");
        }
    }
}