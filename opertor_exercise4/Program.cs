// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number");
int n= Convert.ToInt32(Console.ReadLine());

if (n > 0 && n % 2 == 0)
{
    Console.WriteLine((n + 2) + "," + (n + 4) + "," + (n + 6));

}
else if (n < 0 && n % 2 != 0)
{
    Console.WriteLine((n - 2) + "," + (n - 4) + "," + (n - 6));
}
else
{
    Console.WriteLine("The number is neither a postive even nor a negative odd");
}