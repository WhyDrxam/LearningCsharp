<Query Kind="Statements" />

/*13-Дана матрица размерностью N на N, на вход число N, и N строк каждая строка это N чисел разделенных пробелом. Верни кол-во элементов матрицы i-строки которые больше среднего арифметического i-строки
input
```
4
1 2 3 4
5 6 3 15
0 2 3 1
5 2 8 5
```
OUTPUT
2
1
2
1
INPUT
```
2
5 6
99 5
```
OUTPUT
1
1*/
int n = int.Parse(Console.ReadLine());
int[,] arr = new int[n,n];
int arif = 0;
int sum = 0;
int count = 0;
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		arr[i,j] = int.Parse(Console.ReadLine());
	}
}
for (int i = 0; i < n; i++)
{
	sum = 0;
	count = 0;
	for (int j = 0; j < n; j++)
	{
		sum += arr[i,j];
	}
	for(int j = 0; j < n; j++)
	{
		arif = sum/n;
		if(arr[i,j] > arif)
		{
			count++;
		}
	}
	Console.WriteLine(count);
	
}
