// See https://aka.ms/new-console-template for more information
int[,] n = {
                {0, 1, 2, 3,4 },
                {0, 2, 3, 4, 5 },
                {2, 3, 4, 5, 6 },
                {3, 4, 5, 6, 7 },
};

for(int i = 0; i<4; i++)
{
    for(int j = 0; j<5; j++)
    {
        Console.Write(n[i,j]+ " ");
    }
    Console.WriteLine();
}