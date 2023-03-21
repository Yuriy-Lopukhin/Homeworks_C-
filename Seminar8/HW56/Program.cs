// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
////////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
int rows = InputValue("Введите количество строк массива: ");
int columns = InputValue("Введите количество столбцов массива: ");
int minimum = InputValue("Введите минимальное значение: ");
int maximum = InputValue("Введите максимальное значение: ");

int[,] arr = GetArray(rows, columns, minimum, maximum);

Console.WriteLine($"Заданный массив: ");
PrintArray(arr);

int minLineIndex = 0;
int minLineSum = GetElementsSum(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
  int save = GetElementsSum(arr, i);
  if (minLineSum > save)
  {
    minLineSum = save;
    minLineIndex = i;
  }
}


Console.Write($"Наименьшая сумма элементов ");
Console.WriteLine($"найдена в строке №{minLineIndex + 1} и равна {minLineSum}!");

///////////////////////////////////////////////////////////////////////////////////////////////
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

//Вычисление суммы элементов в строке массива
int GetElementsSum(int[,] array, int index)
{
    int sumLine = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumLine += array[index, j];
    }
    return sumLine;
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
        Console.WriteLine();
    }
}


