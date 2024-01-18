// See https://aka.ms/new-console-template for more information
int even = 0;
int odd = 0;
for (int i=0; i<=10; i++)
{
    if (i%2==0)
    {
        even += i;
    }
    else
    {
        odd += i;
    }
}
Console.WriteLine("even sum" + even);
Console.WriteLine("odd sum" + odd);
