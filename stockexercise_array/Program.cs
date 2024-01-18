// See https://aka.ms/new-console-template for more information
int[] num = { 1, 2, 3 };
string [] n = {"Pencil", "Book", "Eraser" };
int[] p = { 200, 300, 350 };
int []Qty = {1, 2, 3 };
int[] B = { 5, 6, 4 };
int[] amt = { 200, 1500, 750 };

Console.WriteLine("Stock No\t Stock name\t Price\t Sale Qty\t Balance\t Amount\t");
for(int i=0; i<num.Length; i++)
{
    Console.WriteLine(num[i]+"\t"+"   "+ n[i]+"\t" + "   " + p[i] + "\t" + "   " + Qty[i] + "\t" + "   " + B[i] + "\t" + "   " + amt[i]);
}