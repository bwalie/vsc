using System.IO;
using System.Text;
StringWriter str= new StringWriter();
str.WriteLine("hello, this message is ready by string reader class");
str.Close();

StringReader reader = new StringReader(str.ToString());
while(reader.Peek()>1)
{
    Console.WriteLine(reader.ReadLine());
}

