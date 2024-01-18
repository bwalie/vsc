// See https://aka.ms/new-console-template for more information
int sum = 0;
for (int i = 0; i<=12; i++)
{
    Console.WriteLine("Hello, month!");
    int month = (Convert.ToInt32(Console.ReadLine()));
    switch (month)
    {

        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12: Console.WriteLine("31 days"); break;
        case 4:
        case 6:
        case 9:
        case 11: Console.WriteLine("30 days"); break;
        case 2: Console.WriteLine("28 or 29 days"); break;
        default: Console.WriteLine("doesn't exist"); break;
    }
}