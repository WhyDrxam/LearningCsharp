<Query Kind="Statements" />

int d = int.Parse(Console.ReadLine());
int sum = d;
for ( int i = 1; i < d; i++)
{
	if (d % i == 0)
	{
		sum += i;
	}
}
Console.WriteLine(sum);