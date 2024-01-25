//multilevel inheritence

public class Animal
{
    public void eat()
    {
        Console.WriteLine("eating meat");
    }
    public class dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("barking");
        }
    }

    public class BabyDog : dog
    {
        public void weep()
        {
            Console.WriteLine("weeping");
        }
    }

    public class TestInheritence
    {

        public static void Main()
        {
            BabyDog b = new BabyDog();
            b.eat();
            b.bark();
            b.weep();
        }
                
        
        
    }
        
}