// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
////////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
int rows = InputValue("Введите количество строк первого массива: ");
int columns = InputValue("Введите количество столбцов первого массива: ");
int minimum = InputValue("Введите минимальное значение: ");
int maximum = InputValue("Введите максимальное значение: ");

int[,] firstArr = GetArray(rows, columns, minimum, maximum);

int rows2 = InputValue("Введите количество строк второго массива: ");
int columns2 = InputValue("Введите количество столбцов второго массива: ");
int minimum2 = InputValue("Введите минимальное значение: ");
int maximum2 = InputValue("Введите максимальное значение: ");

int[,] secondArr = GetArray(rows2, columns2, minimum2, maximum2);

int[,] product = Multiplication(firstArr, secondArr);

Console.WriteLine($"Первая матрица:");
PrintArray(firstArr);
Console.WriteLine();
Console.WriteLine($"Вторая матрица:");
PrintArray(secondArr);
Console.WriteLine();
if (product[0, 0] == 0) Console.WriteLine($"Произведение матриц вычислить невозможно!:");
else
{
    Console.WriteLine($"Произведение матриц:");
    PrintArray(product);
}
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

//Вычисление произведения двух массивов
int[,] Multiplication(int[,] first, int[,] second)
{
    int rows = first.GetLength(0);
    int columns = second.GetLength(1);
    int[,] result = new int[rows, columns];
    if (rows == columns)
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < first.GetLength(1); k++)
                {
                    sum += first[i, k] * second[k, j];
                }
                result[i, j] = sum;
            }
        }
    }
    else
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = 0;
            }
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
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}
