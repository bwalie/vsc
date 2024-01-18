using System;
using System.Collections;
ArrayList al= new ArrayList();
Console.WriteLine("Adding some numbers");
al.Add(45);
al.Add(70);
al.Add(60);
al.Add(10);
al.Add(20);
al.Add(30);
al.Add(50);
Console.WriteLine("Count: {0}", al.Count);
Console.Write("Content List ");
foreach (int i in al)
{
    Console.Write(i + " ");
}
Console.WriteLine("\n Sorted Content Array");
al.Sort();
foreach(int j in al)
{
    Console.Write(j + " ");
}
Console.WriteLine();
Console.WriteLine("\n Reverse Sort");
al.Reverse();
foreach (int j in al)
{
    Console.Write(j + " ");
}
