// See https://aka.ms/new-console-template for more information
int j;
for (int i = 1; i <= 3; i++)
{
    for ( j = 1; j <= 3; j++)
    {
        if (i == 2 && j == 2)
        {
            break;

        }
        Console.WriteLine(i + " " + j);

    }
}