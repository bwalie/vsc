
double avg;
int[] n = { -2, -3, 12, 1, 15, 10 };
int sum = 0;
    for (int i = 0; i < n.Length; i++) 
    {
        sum += n[i];
       
    }
avg = sum / n.Length;
Console.WriteLine("avarage"+ avg);
