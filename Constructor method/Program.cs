using System;
public class Employee
{
    public int id;
    public string name;
    public int salary;

    public Employee(int i, string n, int s)
    {
        id = i;
        name = n; 
        salary = s;
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
        Employee e1=new Employee(111, "rachel",  12000);
        Employee e2 = new Employee(121, "abi", 12999);
        e1.display();
        e2.display();
    }
}
