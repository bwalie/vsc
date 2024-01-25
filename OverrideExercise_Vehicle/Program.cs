//2. Write a Java program to create a class called Vehicle with a method called drive().
//Create a subclass called Car that overides the drive() method to print "Repairing a car"

public class Vehicle
{
    public virtual void drive()
    {
        Console.WriteLine("driving..");
    }
}

public class Car : Vehicle
{
    public override void drive()
    {
        Console.WriteLine("Reparing a car");
    }
}

public class TestOverride()
{
    public static void Main()
    {
        Car c = new Car();
        c.drive();
    }
}