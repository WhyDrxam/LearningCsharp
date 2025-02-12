<Query Kind="Statements" />

/*10
На вход программе подаются натуральное число N, а затем N строк.
Верни список строк без дубликатов отсортированный по длинне строки.
input

5
first
second
first
third
second

output
экземпляр объекта List<string> заполненный first third second*/

using System.ComponentModel.DataAnnotations;

int n = int.Parse(Console.ReadLine());
List<string> input = new();
for (int i = 0; i < n; i++)
{
    input.Add(Console.ReadLine());
}

var result1 = input.OrderBy(input => input.Length).ToList();
var result2 = result1.Distinct().ToList();

foreach (var a in result2)
{
    Console.Write(a + " ");
}