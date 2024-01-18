// See https://aka.ms/new-console-template for more information
string ans;
do
{
    Console.WriteLine("Enter the name of student");
    string name = Console.ReadLine();

    Console.WriteLine("Enter subject Marks");
    int submark = Convert.ToInt32(Console.ReadLine());

    if (submark >= 50 && submark < 65)
    {
        Console.WriteLine("Pass");

    }
    else if (submark >= 65 && submark < 80)
    {
        Console.WriteLine("Pass with credit");
    }
    else if (submark >= 80 && submark < 100)
    {
        Console.WriteLine("Pass with distinction");
    }
    Console.WriteLine("Do you want to continue Yes or No");
    ans = Console.ReadLine();
}
while (ans.Equals("y"));
