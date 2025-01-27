<Query Kind="Statements" />

int m = int.Parse(Console.ReadLine());

int max = int.MinValue;
int secondMax = int.MinValue;
for (int i = 0; i < m; i++)
{
	int n = int.Parse(Console.ReadLine());
	if (n > max)
	{
		secondMax = max;
		max = n;
	}
	else if (n > secondMax)
	{
		secondMax = n;
	}
}
Console.WriteLine(max);
Console.WriteLine(secondMax);
// максимум 15 а предыдущее макс=8 а на след итерации 12 