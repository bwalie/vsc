// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter a positive interger");
int n= Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=12; i++)
{
    int multi = n*i;
    Console.WriteLine(n+"*"+i+"="+multi);
}

