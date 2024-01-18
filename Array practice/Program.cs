
int[] g = new int[6];
int total = 0;
for (int i = 0; i < 6; i++) 
{
    Console.WriteLine("Enter mark for the subject" + (i+1) + ":");
    int marks= Convert.ToInt32(Console.ReadLine());
    g[i] = marks;
    g[i] += total;
}
Double avg = total/g.Length;
Console.WriteLine("Grade :");
if (avg >= 0 && avg <= 100)
{
    Console.WriteLine("A");

}
else if (avg >= 60 && avg <= 80)
{
    Console.WriteLine("B");
}
else if (avg >= 40 && avg <= 60) 
{
    Console.WriteLine("C");
}
else
{
    Console.WriteLine("D");
}
