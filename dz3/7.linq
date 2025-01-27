<Query Kind="Statements" />

/*7- Напишите программу, которая печатает  треугольник из чисел с высотой, равной N.
На вход число N

INPUT

5

OUTPUT
1 

121

12321

1234321

123454321*/
int height = int.Parse(Console.ReadLine());
for(int i = 1; i <= height; i++)
{
	for (int j = 1; j <= height; j++)
	{
		Console.WriteLine(" ");
	}
	for (int k = 1; k <= i; k++)
	{
		Console.WriteLine(k + " ");
	}
	Console.WriteLine();
}
