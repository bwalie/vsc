// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter weekday");
int num = (Convert.ToInt32(Console.ReadLine()));
switch(num)
{
    case 1: Console.WriteLine("Monday");break;
    case 2: Console.WriteLine("Tuesday");break;
    case 3: Console.WriteLine("Wednesday");break;
    case 4: Console.WriteLine("Thursday");break;
    case 5: Console.WriteLine("Friday"); break;
    default: Console.WriteLine("not weekday");break;
}
