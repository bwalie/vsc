// See https://aka.ms/new-console-template for more information
string ans;
do
{
    Console.WriteLine("Enter number");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter num2");
    int n2 = (Convert.ToInt32(Console.ReadLine()));

    int sum = n + n2;
    Console.WriteLine("sum =" + sum);
    Console.WriteLine("Do you want to continue Yes or No");

    ans = (Console.ReadLine());
}
while (ans.Equals("y"));


