<Query Kind="Statements" />

/*5-На вход программе подаётся одна строка. Напиши программу, которая определяет сколько в ней одинаковых соседних символов
input
aabbcc
output
3
input
aaa
output
2
input
abc
output
0*/
string input = Console.ReadLine();
char[] chars = input.ToCharArray();
int a = 0;
for (int i = 0; i < chars.Length -1; i++)
{
	if( chars[i] == chars[i+1])
	{
		a += 1;
	}
}
Console.WriteLine(a);