//3. Write a Java program to create a class called Shape with a method called
//getArea(). Create a subclass called Rectangle that overrides the getArea() method to
//calculate the area of a rectangle.

public class Shape
{
    public virtual double Getarea()
    {
        return 0.0;
    }
}

public class Rectangle: Shape
{
    private double Length;
    private double Width;

    public Rectangle(double Length, double Width)
    {
        this.Length = Length;
        this.Width = Width;
    }

    public override double Getarea()
    {
        return Length * Width;
    }
}

public class TestArea
{
    public static void Main()
    {
        Rectangle r = new Rectangle(12.5, 6.3);
        double area = r.Getarea();
        Console.WriteLine("area of rectangle: "+ area);
    }
}