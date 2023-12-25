// Задача 3:
// Задайте произвольную строку. Выясните, является ли она палиндромом.
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да


bool flag = true;
System.Console.WriteLine("Задайте произвольную строку : ");
string inputString = System.Console.ReadLine();

for (int i = 0; i < inputString.Length / 2; i++)
{
    if (inputString[i] != inputString[inputString.Length - i - 1]) 
    {
        flag = false;
        break; 
    }
}
if (flag) System.Console.WriteLine($"Строка <{inputString}> является палиндромом");
else System.Console.WriteLine($"Строка <{inputString}> НЕ является палиндромом");