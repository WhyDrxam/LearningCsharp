<Query Kind="Statements" />

int[] array = new int [10];
for (int i = 0; i < array.Length; i++)
{
	array[i] = Convert.ToInt32(Console.ReadLine());
}
string flag = "ДА";

foreach (var item in array)
{
	if ( item % 2 != 0)
	{
		 flag = "НЕТ";
	}
}
	Console.WriteLine(flag);