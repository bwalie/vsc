// See https://aka.ms/new-console-template for more information
string ans;
int poscount = 0;
int negcount = 0;
int zerocount=0;
do
{
    Console.WriteLine("Enter a number");
    int num = Convert.ToInt32(Console.ReadLine());


    if (num > 0)
    {
        poscount++;
    }
    else if (num < 0)
    {
        negcount++;
    }
    else
    {
        zerocount++;
    }
    Console.WriteLine("Do you want to continue Yes or No");
    ans = Console.ReadLine();
}
while (ans.Equals("y"));
Console.WriteLine("positive number " + poscount);
Console.WriteLine("negative numebr " + negcount);
Console.WriteLine("zero count" +  zerocount);