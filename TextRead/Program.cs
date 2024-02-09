using (TextReader tr = File.OpenText("C:\\Users\\Admin\\OneDrive - Petajaveden kunta,Sivistystoimi\\Desktop\\task.txt"))
{
    Console.WriteLine(tr.ReadToEnd());
    Console.WriteLine(tr.ReadLine()); 
}