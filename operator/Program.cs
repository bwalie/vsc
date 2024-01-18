// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Enter subject1");

int s1= Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter subject2");

int s2 = Convert.ToInt32(Console.ReadLine());

if (s1 >= 50 && s2 >= 50)

{
    Console.WriteLine("pass");

}

else
{
    Console.WriteLine("fail");
}