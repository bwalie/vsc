// See https://aka.ms/new-console-template for more information
string ans;
int even = 0;
int odd = 0;

do
{
    Console.WriteLine("enter an interger");
    int num=Convert.ToInt32(Console.ReadLine());

    if(num % 2 == 0 )
    {
        even += num; 
    }
    else
    {
        odd += num;
    }
    Console.WriteLine("Do you want to continue Yes or no");
    ans = Console.ReadLine();
}
while (ans.Equals("y"));
Console.WriteLine("sum of even integers: " + even);
Console.WriteLine("sum of even integers: " + odd);
