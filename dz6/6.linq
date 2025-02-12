<Query Kind="Statements" />

/*6
На вход программе подаётся  число N
Напиши программу, которая создаёт список, состоящий из делителей введённого числа и возвращает его
input 
17
output
экземпляр объекта List<int> заполненный 1, 17*/
int n = int.Parse(Console.ReadLine());
List<int> result = new();
for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        result.Add(i);
    }
}

foreach (var num in result)
{
    Console.Write(num + " ");
}