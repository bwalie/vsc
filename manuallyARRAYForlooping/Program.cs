int[]  age = new int[5];
for(int i=0; i<age.Length; i++)
{
    Console.WriteLine("enter array element");
    int num = Convert.ToInt32(Console.ReadLine());
    age[i] = num;
}
for(int j=0; j<age.Length; j++)
{
    Console.WriteLine(age[j]);
}