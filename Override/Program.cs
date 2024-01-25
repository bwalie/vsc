public class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("eating..");
    }
    
}

public class Dog : Animal
{
    public override void eat()
    {
        Console.WriteLine("eating bread");
    }
}

public class TestOverride()
{
    public static void Main()
    {
        Dog d = new Dog();
     d.eat();
    }
}