<Query Kind="Statements" />

int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int  count = 0;
for ( int i = n; i <= m; i++)
{
	long cubeLastDigit = (long)Math.Pow(i, 3) % 10;
            if (cubeLastDigit == 4 || cubeLastDigit == 9)
            {
                count++;
            }
}
Console.WriteLine(count);