using System;
public class TestEmployee
{
    public int id;
    public string name;
    public int salary;
    public void insert(int i, string n, int s)
    {
        id = i;
        salary = s;
        name = n;
    }
    public void display()
    {
        Console.WriteLine(id+ " " + name+ " "+ salary);
    }
}
public class employee
{
    public static void Main(string[] args)
    {
        TestEmployee e1= new TestEmployee();
        TestEmployee e2= new TestEmployee();
        TestEmployee e3 = new TestEmployee();
        e1.insert(1001,"mei" , 1200);
        e2.insert(1002, "bwal", 1200);
        e3.insert(1003, "myat",  1300);
        e1.display();
        e2.display();
        e3.display();
    }
}