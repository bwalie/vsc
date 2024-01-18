int[] n = new int[10];
int positive = 0;
int neg = 0;
int odd = 0;
int even = 0;
int zero = 0;

for (int i = 0; i < n.Length; i++)
{
    Console.WriteLine("Enter integer " + (i+1)+":");

    int num= Convert.ToInt32(Console.ReadLine());
    n[i] = num;

    if (n[i] > 0)
    {
        positive++;
    }
    else if (n[i] < 0)
    {
        neg++;
    }
    else
    {
        zero++;
    }
    if (n[i]%2==0)
    {
        even++;
    }
    else
    {
        odd++;
    }
}
Console.WriteLine("Positive: "+positive);
Console.WriteLine("negative: " + neg);
Console.WriteLine("odd: " + odd);
Console.WriteLine("even: " + even);
Console.WriteLine("zero: " + zero);




