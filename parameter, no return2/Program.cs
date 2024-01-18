namespace Square
{
    class Test
    {
        static void Main(string[] args)
        {
            int p = 5;
            perimeter(p);
            Console.WriteLine("Finish");
        }
        public static void perimeter(int p)
        {
            int result = 4 * p;
            Console.WriteLine("Perimeter of the Square is : " + result);
        }
    }
}