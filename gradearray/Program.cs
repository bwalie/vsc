// See https://aka.ms/new-console-template for more information
int[] n = new int[6];
int total = 0;
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Enter marks for subjects"+(i+1)+":");
    int marks= Convert.ToInt32(Console.ReadLine());
    n[i] = marks;
    total += n[i];
}
double avg= total/n.Length;
Console.WriteLine("student grade is:");
if (avg >= 80 && avg <= 100)
{
    Console.WriteLine("A");
}
else if (avg >= 60 && avg < 80)
{
    Console.WriteLine("B");
}
else if (avg >=40  && avg <60)
{
    Console.WriteLine("C");
}
else
{
    Console.WriteLine("D");
}
   
