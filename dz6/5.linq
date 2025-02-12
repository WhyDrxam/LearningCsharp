<Query Kind="Statements" />

/*5
На вход число N, нужно вернуть список строк типа a bb ccc dddd eeeee
input
5
output
экземпляр объекта List<string> заполненный a bb ccc dddd eeeee*/
List<string> result = new();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
  int ascii = 'a' + i;
  result.Add(new string((char)ascii, i +1));
  
}

foreach (var s in result)
{
  Console.WriteLine(s);
}