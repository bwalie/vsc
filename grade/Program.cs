// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter first num");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second num");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter an operator");
string op= Console.ReadLine();
int res;

if (op.Equals("+"))
{
    res = n1 + n2;
    Console.WriteLine("sum=" + res);
}
else if (op.Equals("-"))
{
    res = n1 - n2;
    Console.WriteLine("subtract=" + res);
}
else if (op.Equals("*"))
{
    res = n1 * n2;
    Console.WriteLine("multi =" + res);
}
else if (op.Equals("/"))
{
    res= n1/ n2;
    Console.WriteLine("division = " + res);
}

else
{
    Console.WriteLine("invalid");
}