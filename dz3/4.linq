<Query Kind="Statements" />

int a = int.Parse(Console.ReadLine());
string flag = "ДА";
int b = 0;
int c = 0;
while (a > 0)
{
	
	 b = a % 10;
	 a /= 10;
     c = a % 10;
	 a /= 10;
	if ( b != c)
	{
		flag = "НЕТ";
	}
}
Console.WriteLine(flag);
