// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter age");
int age = Convert.ToInt32(Console.ReadLine());

if (age > 0 && age <= 4)
{
    Console.WriteLine("You are a baby");
}
else if (age >= 5 && age <= 14)
{
    Console.WriteLine("You are a child");
}
else if (age >= 15 && age <= 19)
{
    Console.WriteLine("You are a teenager");
}
else if (age >= 20 && age <= 65)
{
    Console.WriteLine("old");
}
else
{
    Console.WriteLine("invalid age");
}