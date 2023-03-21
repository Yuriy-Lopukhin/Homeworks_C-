// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
/////////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
int rows = InputValue("Введите количество строк массива: ");
int columns = InputValue("Введите количество столбцов массива: ");
int minimum = InputValue("Введите минимальное значение: ");
int maximum = InputValue("Введите максимальное значение: ");

int[,] arr = GetArray(rows, columns, minimum, maximum);
Console.WriteLine($"Исходный массив: ");
PrintArray(arr);
Console.WriteLine();
GetChangedArray(arr);
Console.WriteLine($"Изменённый массив: ");
PrintArray(arr);

/////////////////////////////////////////////////////////////////////////////////////////////////
//Ввод параметров массива
static int InputValue(string message)
{
    try
    {
        Console.Write(message);
        return (int.Parse(Console.ReadLine() ?? ""));
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}

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


//Упорядочивание элементов в строках массива
void GetChangedArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int save = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = save;
                }
            }
        }
    }
}

//Вывод массива на экран
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}