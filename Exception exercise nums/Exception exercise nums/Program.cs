class program
{


    public static void Main(string[] args)
    {
        int n = 18;
        trynumber(n);
        n = 7;
        trynumber(n);

    }

    public static void trynumber(int a)
    {
        try
        {
            checkEvenNumber(a);
            Console.WriteLine(a + "is even");
        }

        catch (ArgumentException ea)
        {
            Console.WriteLine("Error:" + ea.GetBaseException());
        }
    }

    public static void checkEvenNumber(int number)
    {
        if (number % 2 != 0)
        {
            throw new ArgumentException(number + "is odd");

        }
    }
}

