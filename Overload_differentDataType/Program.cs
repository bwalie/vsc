//overload with different data types
public class Test
{
    public static int add(int a, int b)
    {
        return a + b;
    }

    public static double add(double a, double b, double c)
    {
        return a + b + c;
    }

    public static string add(string a, string b)
    {
        return a + b;
    }
}

public class TestOverLoad
{
    public static void Main()
    {
        Console.WriteLine(Test.add(10,29));
        Console.WriteLine(Test.add(2.1,0.01,0.9));
        Console.WriteLine(Test.add("chalupa","chapula"));
    }
}