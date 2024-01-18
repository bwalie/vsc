using System;
class program
{
    static void Main(string[] args)
    {
        int[][] arr = new int[3][];
        arr[0] = new int[3] { 10, 20, 30 };
        arr[1] = new int[] { 12, 23, 33, 45, 45 };
        arr[2] = new int[] { 12, 22 };

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}