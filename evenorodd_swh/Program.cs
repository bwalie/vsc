// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter number");
int num = Convert.ToInt32(Console.ReadLine());

switch(num%2)
{
    case 0: Console.WriteLine("even num");break;

    case 1: Console.WriteLine("odd num");break;
    default: Console.WriteLine("not num");break;
}

