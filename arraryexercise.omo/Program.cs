int[] num = new int[5];
string[]stu_name = new string[5];
int[]sub1 = new int[5];
int[]sub2= new int[5];

num[0] = 1;
num[1] = 2;
num[2] = 3;
num[3] = 4;
num[4] = 5;

stu_name[0] = "Aye Aye";
stu_name[1] = "Aung Aung";
stu_name[2] = "Win Aung";
stu_name[3] = "Zaw Zaw";
stu_name[4] = "Mg Mg";

sub1[0] = 59;
sub1[1] = 33;
sub1[2] = 52;
sub1[3] = 33;
sub1[4] = 48;

sub2[0] = 68;
sub2[1] = 36;
sub2[2] = 60;
sub2[3] = 24;
sub2[4] = 56;

Console.WriteLine("student no   student name   subject1   subject2");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(num[i]+"\t"+"     "+ stu_name[i] +"\t"+"    " + sub1[i]+ "\t" + "    "+ "    " + sub2[i]);
}
