//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
///////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 100);
Console.Write("Введите индекс i: ");
int indexI = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите индекс j: ");
int indexJ = int.Parse(Console.ReadLine() ?? "");

PrintArray(array);
Console.WriteLine();
PrintPosition(array, indexI, indexJ);

//////////////////////////////////////////////////////////////////////////////////////////////
//Создание массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

//Вывод массива на экран
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Нахождение элемента массива по индексу и вывод на экран
void PrintPosition(int[,] arr, int value1, int value2)
{
    int res = 0;

    res = arr[value1, value2];

    if (res == 0) Console.WriteLine($"В массиве нет позиции с таким индексом!");

    else Console.WriteLine($"В заданном массиве элемент с индексом [{value1}, {value2}] имеет значение {res}!");
}