// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter gender M/F");
string gender= Console.ReadLine();

switch (gender)
{
    case "M":
    case "m":
                Console.WriteLine("male");break;

    case "F":
    case "f": 
                Console.WriteLine("female");break;
        default: Console.WriteLine("nonbinary");break;
}


