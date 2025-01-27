<Query Kind="Statements" />

/*1-На вход программе подаётся одна строка. Напиши программу которая выводит буквы в столбик*/
string input = Console.ReadLine();
char[] chars = input.ToCharArray();
for (int i = 0; i < chars.Length; i++)
{
	Console.WriteLine(chars[i]);
}