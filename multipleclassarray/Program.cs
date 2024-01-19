using System;
public class TestStudent
{
    public int id;
    public String name; 
    public void insert(int i, String n) 
    {
        id = i;
        name = n;
    }
    public void display()
    {
        Console.WriteLine(id+ " " + name);
    }
}
public class student
{
    public static void Main(string[] args)
    {
        TestStudent s1 = new TestStudent();
        TestStudent s2= new TestStudent();
        s1.insert(001, "Rachel");
        s2.insert(002, "Bwal");
        s1.display();
        s2.display();
    }
}