<Query Kind="Statements" />

/*4-На вход программе подаётся одна строка состоящая из цифр через разделенных пробелом. Напиши программу которая выводит сумму всех цифр из строки
input
“1 2 3 4 5”
output
15*/
string numbers = Console.ReadLine();
int sum = 0;
int[] arr = new int[5];
int counter = 0;
foreach (var num in numbers.Split())
{
	arr[counter] = int.Parse(num);
	++counter;
}
for (int i = 0; i < arr.Length; i++)
{
	sum += arr[i];
}
Console.WriteLine(sum);