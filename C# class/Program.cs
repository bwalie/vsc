using System;

class student
{
    int id;
    string name;

    static void Main()
    {
        student s1 = new student();
        s1.id = 1001;
        s1.name = "Jack";
        Console.WriteLine(s1.id);
        Console.WriteLine(s1.name);
    }
}
