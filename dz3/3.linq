<Query Kind="Statements" />

int a = int.Parse(Console.ReadLine());
int sum = 0;
int count = 0;
int proiz = 1;
double mid = 0;
int firstNumber = 0;
int sumFL = 0;
int b = 0;
int c = a % 10;
while (a > 0)
{
	b = a % 10;
	a = a / 10;
	sum += b;
	count++;
	proiz *= b;
	mid += b;
}
sumFL = c + b;
firstNumber = b;
mid /= count;
Console.WriteLine(sum);
Console.WriteLine(count);
Console.WriteLine(proiz);
Console.WriteLine(mid);
Console.WriteLine(firstNumber);
Console.WriteLine(sumFL);
	