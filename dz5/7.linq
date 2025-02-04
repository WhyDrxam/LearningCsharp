<Query Kind="Statements" />

/*7
На вход строка, напиши программу которая проверяет что это валидный ник на сайте
Ник начинается с символа собака @
Ник от 6 символов до 15 включая @
Ник только из букв нижнего регистра
input
@Pavel
output
invalid
input
@pavel
output
valid*/
string input = Console.ReadLine();
bool flag = false;
if (input.StartsWith('@') && (input.Length >= 6 && input.Length <= 15))
{
    foreach (var c in input)
    {
        if (char.IsUpper(c))
        {
            flag = false;
            Console.WriteLine("invalid");
            break;
        }
        else if (char.IsLower(c))
        {
            flag = true;
        }
    }

    if (flag == true)
    {
        Console.WriteLine("valid");
    }    
}    

else
Console.WriteLine("invalid");