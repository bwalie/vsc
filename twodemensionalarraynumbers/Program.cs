int[,] n = {
               {1 , 0, 0, 0},
               {0, 1, 0, 0},
               {0, 0, 1, 0 },
               {0, 0, 0, 1},
            };
for(int i = 0; i<4; i++)
{
    for(int j= 0; j<4; j++)
    {
        Console.Write(n[i, j] + " ");
    }
    Console.WriteLine();
}