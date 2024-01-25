using System.Reflection.Metadata.Ecma335;

public class cal
{
    public static int add(int a, int b)
    {
        return a + b;
    }

    public static int add(int a, int b, int c)
    {
        return a + b + c;
    }
    
}

public class TestOverload
{
    public static void Main()
    {
        Console.WriteLine(cal.add(10,20));
        Console.WriteLine(cal.add(11,12,13));
    }
}