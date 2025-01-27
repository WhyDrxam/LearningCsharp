<Query Kind="Statements" />

int a = int.Parse(Console.ReadLine());
int min = int.MaxValue;
int max = int.MinValue;
int lastDigit = 0;
 do
 {
 	lastDigit = a % 10;
	if (lastDigit > max)
	{
		max = lastDigit;
	}
	else if ( lastDigit < min)
	{
		min = lastDigit;
	}
	a /= 10;
}
	while (a != 0);
	Console.WriteLine(min);
	Console.WriteLine(max);