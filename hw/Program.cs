// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter first number");
int num1 = (Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Enter second number");
int num2 = (Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Enter third number");
int num3 = (Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Enter a character (s or p)");
string c = Console.ReadLine();
int sum, multi;

if (c.Equals("s")) 
{
    sum = num1 + num2 + num3;
    Console.WriteLine("sum of nums is" + sum);
}
else if(c.Equals("p"))
{
    multi = num1 * num2 * num3;
    Console.WriteLine("multiplication of the nums is" + multi);
}
else
{
    Console.WriteLine("invalid");
}
    