// See https://aka.ms/new-console-template for more information
string[] n = new string[3];
string[]property = new string[3];
int[]price= new int[3];

for (int i = 0; i < n.Length; i++)
{
    Console.WriteLine("Enter item name");
    string nm = Console.ReadLine();
    n[i] = nm;
}

for (int j = 0;j < n.Length; j++)
{
    Console.WriteLine("Enter property name");
    string prp = Console.ReadLine();
    property[j] = prp;
}

for (int k = 0; k < n.Length; k++)
{
    Console.WriteLine("Enter price");
    int p = Convert.ToInt32(Console.ReadLine());
    price[k] = p;
}

Console.WriteLine("Item name\t Property\t Price");
for (int l=0; l < n.Length; l++)
{
    Console.WriteLine(n[l]+"\t\t"+"    "+ property[l]+"\t\t"+"  "+ price[l]);
}