public class add
{
    public static void Main()
    {
        try
        {
            int[] arr = new int[5];
            arr[5] = 30 / 5;


        }
        
        catch (ArithmeticException e)
        {
            Console.WriteLine("ArithmethicException occurs");

        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfRangeException poccurs");
        }
        catch (Exception e)
        {
            Console.WriteLine("Parent Exception accours");
        }
        
    }
}