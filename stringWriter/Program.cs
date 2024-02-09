using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string text= "Hello, Welcome to C# \n it is nice site. \n it provides technical tutorials";
        StringBuilder sb= new StringBuilder();

        StringWriter w= new StringWriter(sb);

        w.WriteLine(text);
        w.Flush();
        w.Close();
        StringReader reader = new StringReader(sb.ToString());

        while(reader.Peek() > -1)
        {
            Console.WriteLine(reader.ReadLine());
        }

    }
    
}
