<Query Kind="Statements" />

/*7-На вход программе подаётся число. Напиши программу, которая переводит число в двоичную систему исчесления

input

5

output

101

input

1025

output

10000000001*/
int number = int.Parse(Console.ReadLine());
string binary = Convert.ToString(number , 2);
Console.WriteLine(binary);
