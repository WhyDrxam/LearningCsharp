<Query Kind="Statements" />

int[] arr = [1,2,3,4,5];
int i = 0;
while (i < arr.Length)
{
	Console.WriteLine(arr[i]);
	if (arr[i] == 3)
	{
		continue;
	}
	i+=2;
}