// Задача 4*(не обязательная):
// Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.
// “Hello my world” => “world my Hello”

System.Console.WriteLine(@"Задайте произвольную строку, состоящую из слов, разделенных пробелами, \n
строка не должна начинаться с пробела или заканчиваться пробелом: ");
string inputString = (string)System.Console.ReadLine();
int wordsCount = 0;
if (inputString.Length != 0)
{
    // Считаем слова:
    wordsCount++;
    for (int i = 0; i < inputString.Length; i++)
    {
        if (inputString[i] == ' ')
        {
            wordsCount++;
        }
    }
}
else 
{
    System.Console.WriteLine("Ошибка: пустая строка.");
    return;
}
//System.Console.WriteLine($"В строке слов : {wordsCount}");
// Создаем одномерный массив строк размером == количеству слов

string[] wordsArr = new string[wordsCount];

int count = 0;
for (int i = 0; i < inputString.Length; i++)
{
    if (inputString[i] != ' ')
    {
        wordsArr[count] += (char)inputString[i];
    }
    else
    {
        count++;
    }
}

string outputString = System.String.Empty;

// Записываем в массив слова в обратном порядке
for (count = wordsCount - 1; count >= 0; count--)
{
    outputString += wordsArr[count];
    if (count != 0) outputString += ' ';
}
System.Console.WriteLine(outputString);
//