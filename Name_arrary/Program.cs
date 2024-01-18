using System.Security.Cryptography.X509Certificates;

int[] num = new int[5];
string[] studentname = new string[5];
int[] sub1  = new int[5];
num[0] = 1;
num[1] = 2;
num[2] = 3;
num[3] = 4;
num[4] = 5;

studentname[0] = "Aye Aye";
studentname[1] = "Aung Aung";
studentname[2] = "Win Aung";
studentname[3] = "Zaw Zaw";
studentname[4] = "Mg Mg";

sub1[0] = 59;
sub1[1] = 33;
sub1[2] = 52;
sub1[3] = 33;
sub1[4] = 48;

Console.WriteLine("student no\t student name\t sub1");
for (int i = 0; i < 5; i++) 
{
    Console.WriteLine(num[i] + studentname[i] + sub1[i]);

}




