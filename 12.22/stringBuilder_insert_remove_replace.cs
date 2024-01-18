

using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
    StringBuilder sb = new StringBuilder("Hello World");
    
    sb.AppendLine("Welcome ");
    sb.AppendLine("12.22.23 ");

        
        sb.Insert(5, "C#");

        sb.Remove(6, 7);

        sb.Replace("C" +
            "" +
            "" +
            "Welcome", "C#");

    Console.WriteLine(sb);
    }
}




