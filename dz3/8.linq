<Query Kind="Statements" />

/*8-На вход  подается два числа n и m, напиши программу которая находит все простые числа от n до m
Простое число то которое делится на 1 и на само себя
INPUT
2
15
OUTPUT
2
3
5
7
11
13*/
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
bool flag = true;
for (int i = n; i <= m; i++)
{
	flag = true;
	for (int j = n; j < i; j++)
	{
		if(i % j == 0)
		{
			flag = false;
		}
	}
	if(flag)
	{
		Console.WriteLine(i);
	}
	
}