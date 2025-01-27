<Query Kind="Statements" />

/*3-На вход программе подаётся одна строка. Напиши программу которая выводит инициалы с большой буквы через точку

Input

Петр Иванович Иванов

Output

П.И.И.*/
string[] fio = Console.ReadLine().Split(' ');
Console.WriteLine(fio[0][0]+"."+fio[1][0]+"."+fio[2][0]);