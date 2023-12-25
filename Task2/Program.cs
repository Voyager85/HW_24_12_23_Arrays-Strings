// Задача 2:
// Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
// “aBcD1ef!-” => “abcd1ef!-”

string str = "aBcD1ef!-";
char [] chArr = new char[str.Length];

System.Console.WriteLine("Задана строка: " + str);
for (int i = 0; i < str.Length; i++)
{
    if (str[i] > 64 && str[i] < 91)
    {
        chArr[i] = (char)(str[i] + 32);
    }
    else chArr[i] = str[i];
}
string newstr = new string(chArr);
System.Console.WriteLine("Новая  строка: " + newstr);

