// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter subject 1 mark");
int s1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter subject 2 mark");
int s2= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter subject 3 mark");
int s3= Convert.ToInt32(Console.ReadLine());

if(s1 >= 40 && s2>= 40 && s3 >= 40)
{
    Console.WriteLine("You pass!");
}
else
{
    Console.WriteLine("you fail!!");
}