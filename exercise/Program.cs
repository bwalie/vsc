// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter digit num1");
int digit1 = (Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Enter digit num2");
int digit2 = (Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Enter digit num3");
int digit3 = (Convert.ToInt32(Console.ReadLine()));

if (digit1 %2 == 0 && digit2 %2 == 0 && digit3 %2 == 0)
{
    Console.WriteLine("This number contains all even digits");
}
else if(digit1% 2 !=0 && digit2 %2 != 0 && digit3%2 != 0)
{
    Console.WriteLine("This num contains all odd digits");
}
else
{
    Console.WriteLine("The number contains both odd and even digits");
}