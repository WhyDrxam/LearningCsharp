<Query Kind="Statements" />

/*10- На вход число N, нарисуй рамку из звездочек длинной 19 высотой N

INPUT
4
OUTPUT
*******************
*                 *
*                 *
********************/
int n = int.Parse(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
	if(i == 1 || i == n)
	{
		Console.WriteLine(new string('*', 19));
	}
	else 
	{
		Console.WriteLine('*' + new string(' ', 17) + '*');
	}
}