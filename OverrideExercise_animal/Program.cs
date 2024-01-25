//I. Write a C# program to create a class called Animal with a method called makesound()
//Create a subclass called Cat that overrides the makesound() method
//to bark.

public class Animal
{
    public virtual void makesound()
    {
        Console.WriteLine("making sounds..");
    }
}

public class Cat : Animal
{
    public override void makesound()
    {
        Console.WriteLine("barking..");
    }
}

public class TestOverride()
{
    public static void Main()
    {
        Cat c = new Cat();
        c.makesound();
    }
}