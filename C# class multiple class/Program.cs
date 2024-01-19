using System;
public class TestStudent
{
    public int id;
    public string name;
}

public class student
{
    public static void Main(string[] args)
    {
        TestStudent ts= new TestStudent();
        ts.id = 1;
        ts.name = "Bwal";
        Console.WriteLine(ts.id);
        Console.WriteLine(ts.name);
    }
}