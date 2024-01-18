// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number");
int n= Convert.ToInt32(Console.ReadLine());

if (n == 7 || n % 7 == 0)
{
    Console.WriteLine("lucky num");
}
else
{
    Console.WriteLine("sorry!");
}