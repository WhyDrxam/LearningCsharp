<Query Kind="Statements" />

/*1

На вход число N, Вернуть List чисел от 1 до N включительно.

input

5

output

экземпляр объекта List<int> заполненный от 1 до 5*/
int n = int.Parse(Console.ReadLine());
List<int> numbers = new List<int>();
for (int i = 1; i <= n; i++)
{
    numbers.Add(i);
}

foreach (var num in numbers)
{
    Console.WriteLine(num);
}