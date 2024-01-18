class Program
{
    static void Main(string[] args)
    {
        int a = 100;
        int b = 300;
        int sum = Add(a, b);
        Console.WriteLine("Sum :" + sum);
    }
    static int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
}