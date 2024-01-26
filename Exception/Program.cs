public class add
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            int x = a / b;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine("Rest of the code");

    }
}