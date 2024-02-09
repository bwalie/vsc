using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (TextWriter write = File.CreateText("C:\\Users\\Admin\\OneDrive - Petajaveden kunta,Sivistystoimi\\Desktop\\task.txt")) 
        {
            write.WriteLine("Hello C# Developer");
            write.WriteLine("C# File Handling");
        }
        Console.WriteLine("Data written Successfully");
    }
}