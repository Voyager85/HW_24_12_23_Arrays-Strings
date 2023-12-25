// Задача 1:
// Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

char[,] charArr = {
    {'a','b','c','d'},
    {'e','f','g','h'}
};
//int sLength = charArr.GetLength[0]+charArr.GetLength[1];
int sLength = charArr.Length;
string str = System.String.Empty;

for (int i = 0; i < charArr.GetLength(0); i++)
{
    for (int j = 0; j < charArr.GetLength(1); j++)
    {
        str += charArr[i,j];
    }
}
System.Console.WriteLine(str);