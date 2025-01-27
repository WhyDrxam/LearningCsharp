<Query Kind="Statements" />

/*12-Дана матрица размерностью N на N, на вход число N, и N строк каждая строка это N чисел разделенных пробелом.
Нужно найти сумму главной диагонали матрицы
INPUT
4
1 0 0 0
0 1 0 0
0 0 1 0
0 0 0 1
OUTPUT
4
INPUT
3
1 2 3
4 5 6
7 8 9
OUTPUT
15*/
int n = int.Parse(Console.ReadLine());
int[,] arr = new int[n,n];
int sum = 0;
for(int i = 0; i < n; i++)
{
	string[] a = Console.ReadLine().Split();
	for(int j = 0; j < a.Length; j++)
	{
		arr[i,j] = int.Parse(a[j]);
	}
	
}
for(int i = 0; i < n; i ++)
{
	for(int j = 0; j < n; j ++)
	{
		if(j == i)
		{
			sum +=arr[i,j];
		}
	}
}
Console.WriteLine(sum);