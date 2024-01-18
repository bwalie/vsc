using System;
class program
{
    static string courseName = "C# programming Language";
    static int[] grade = { 87, 68, 94, 100, 83, 78, 55, 91, 76, 87 };
    static void Main(string[] args)
    {
        displaymessage();
        processGrade();
    }
    static void displaymessage()
    {
        Console.WriteLine("Welcome to the grade book for the" + courseName);
    }
    static void processGrade()
    {
        OutPutGrades();
        Console.WriteLine("Minium Grade is: " +GetMinimum());
        Console.WriteLine("Maxium Grade is: "+ GetMaximum());
        Console.WriteLine("Average Grade is: " + Getaverage());
    }
    static int GetMinimum()
    {
        int lowGrade = grade[0];

        foreach (int i in grade)
        {
            if (i < lowGrade)
            {
                lowGrade = i;
            }
        }
        return lowGrade; 
    }
    static int GetMaximum()
    {
        int highGrade = grade[0];
        foreach (int i in grade) 
        {
            if(i > highGrade)
            {
                highGrade = i;
            }
        }
        return highGrade;
    }
    static double Getaverage()
    {
        double total = 0;
        foreach(int i in grade) 
        {
            total+= i;
        }
        return total / grade.Length;
    }
    static void OutPutGrades()
    {
        Console.WriteLine("grades are: ");
        for(int stu=0; stu< grade.Length; stu++)
        {
            Console.WriteLine("student" + (stu + 1) + grade[stu]);
        }
    }
    
    
}