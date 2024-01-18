// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter year");
int n= Convert.ToInt32(Console.ReadLine());

if (n % 4 == 0 && n % 400 == 0)
{
    Console.WriteLine("leap year");
}
else
{
    Console.WriteLine("not leap year");

}