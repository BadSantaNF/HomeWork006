//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


char[,] array = {
    { 'H', 'e', 'l', 'l', 'o', 'W', 'o', 'r', 'l', 'd' },
    { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' }
};

string chars = string.Empty;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        chars += array[i, j];
    }
}

Console.WriteLine(chars);
