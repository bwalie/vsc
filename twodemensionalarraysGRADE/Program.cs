string[,] n = {
                        {"1\t\t", "Aye Aye\t", "12000\t\t", "1000\t\t", "13000"},
                        {"2\t\t","Aung Aung\t","15000\t\t", "2000\t\t", "17000"},
                        {"3\t\t","Wint Aung\t", "20000\t\t","3000\t\t", "23000"},
                        {"4\t\t","Zaw Zaw\t", "25000\t\t", "4000\t\t", "29000"},
                        {"5\t\t", "Mg Mg\t\t", "30000\t\t", "5000\t\t", "35000" },

                        };
Console.WriteLine("Staff No \t Staff Name \t Basic Pay \t Increment \t Net Pay");
for(int i = 0; i < 5; i++)
{
    for(int j = 0; j< 5; j++)
    {
        Console.Write(n[i, j] + " ");
    }
    Console.WriteLine();

}
Console.WriteLine("\t\t\t\t\t\t total \t\t 117000");
