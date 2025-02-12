<Query Kind="Statements" />

/*9
на вход программе подается число N и N чисел каждое на новой строке.
Верни список чисел в котором удалено самое маленькое и самое большое значение, если там будут дубликаты их тоже нужно удалить.
input
10
9
17
189
3
55
78
11
7
888
160
output
экземпляр объекта List<int> заполненный 9 17 189 55 78 11 7 160*/
int n = int.Parse(Console.ReadLine());
List<int> input = new();
List<int> result = new();
for (int i = 0; i < n; i++)
{
    input.Add(int.Parse(Console.ReadLine()));
}
input.Remove(input.Max());
input.Remove(input.Min());
foreach (var num in input)
{
    Console.Write(num + " ");
}