int[,] num = new int[3, 3];
num[0, 1] = 10;
num[1, 2] = 20;
num[2, 0] = 30;

for(int i= 0; i<3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(num[i, j] + " ");
    }
    Console.WriteLine();
}