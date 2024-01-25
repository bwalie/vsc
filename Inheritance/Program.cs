//inheritance

class program
{
    public class Employee
    {
        public float salary = 400000;
    }

    public class Programmer : Employee
    {
        public float bonus = 100000;
    }

    class Testinherit
    {
        public static void Main(string[]args)
        {
            Programmer p = new Programmer();
            Console.WriteLine("salary"+ p.salary);
            Console.WriteLine("bonus"+ p.bonus);
            
        }
    }
}