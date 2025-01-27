<Query Kind="Statements" />

int a = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= a; i++)
{
	long LastDigit = ((long)Math.Pow(i,2)) % 10;
            if (LastDigit == 2 || LastDigit == 5 || LastDigit == 8)
            {
                sum +=i;
            }
}
Console.WriteLine(sum);