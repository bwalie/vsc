// See https://aka.ms/new-console-template for more information
int[] n = { 1, 2, 3, 4, 5, 6, 7, 8 };
int even = 0;
for (int i = 0; i < n.Length; i++) 
{
    if (n[i] %2==0)
    {
        even++;
    }
    Console.WriteLine("even num" + even);
    Console.WriteLine("odd num" + (n.Length-even));
}