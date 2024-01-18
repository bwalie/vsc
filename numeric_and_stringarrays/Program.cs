// See https://aka.ms/new-console-template for more information
int[] years = { 1900, 1800, 2000, 2022, 2023 };
string[] n = { "C#", "python", "java", "php", "ruby" };


Console.WriteLine("Original numeric array:" + String.Concat(years));
Array.Sort(years);

Console.WriteLine("sorted numeric array:" + String.Concat(years));

Console.WriteLine("Original string array:" + String.Concat(n));
Array.Sort(n);

Console.WriteLine("sorted string array:" + String.Concat(n));
