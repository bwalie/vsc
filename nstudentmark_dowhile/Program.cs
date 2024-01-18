// See https://aka.ms/new-console-template for more information
string ans;
do
{
    Console.WriteLine("Enter the name of students ");
    string name= Console.ReadLine();

    Console.WriteLine("Enter subject1");
    int subject1=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter subject2");
    int subject2 = Convert.ToInt32(Console.ReadLine());

    if (subject1<40 || subject2<40)
    {
        Console.WriteLine("fail");
    }
    else
    {
        Console.WriteLine("pass");
    }
    Console.WriteLine("Do you want to continue Yes or No");

    ans = Console.ReadLine();
}
while(ans.Equals("y"));

