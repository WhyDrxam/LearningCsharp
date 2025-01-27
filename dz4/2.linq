<Query Kind="Statements" />

/*2-На вход программе подаётся одна строка. Напиши программу которая выводит буквы в столбик в обратном порядке.*/
string input = Console.ReadLine();
char[] chars = input.ToCharArray();
for (int i = chars.Length -1; i >= 0; i--)
{
	Console.WriteLine(chars[i]);
}