//this keyword
using System;
class Employee
{
    public int id;
    public string name;
    public float salary;
    
    public Employee(int id, string name, float salary)
    {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }
    public void display()
    {
        Console.WriteLine(id+" "+name+" "+salary);
     
    }
}
public class TestEmployee
{
    public static void Main(string[] args)
    {
        Employee e1 = new Employee(111, "abc", 130000);
        Employee e2 = new Employee(121, "cde", 12222);
        e1.display();
        e2.display();
    }
}