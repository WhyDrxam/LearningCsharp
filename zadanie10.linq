<Query Kind="Statements" />

int a = int.Parse(Console.ReadLine());
int sum = 0;
for ( int i = 1; i < a; i++)
{
	if (i % 2 == 0)
	{
		sum += i;
	}
	
}
Console.WriteLine(sum);