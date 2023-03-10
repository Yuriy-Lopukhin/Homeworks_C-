// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
///////////////////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
int lenght = InputNumber("Введите длину массива: ");
double[] array = GetArray(lenght);

double max = GetMax(array);
double min = GetMin(array);
double delta = GetDelta(min, max);

printResult(array, delta);


//////////////////////////////////////////////////////////////////////////////////////////////////////////
// Метод для ввода параметров
static int InputNumber(string message)
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

//Создание массива случайных вещественных чисел 
double[] GetArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
        array[i] = rand.Next(100, 1000) + rand.NextDouble();
    return array;
}

//Определение максимального элемента массива
double GetMax(double[] arr)
{
    double max = arr[0];
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

//Определение минимального элемента массива
double GetMin(double[] arr)
{
    double min = arr[0];
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

//Вычисление разницы между максимальным и минимальным элементом массива
double GetDelta(double value1, double value2)
{
    double delta = value2 - value1;
    return delta;
}

//Вывод результата на экран
void printResult(double[] arr, double value)
{
    Console.WriteLine($"[{String.Join(" ", arr)}] -> {value}");
}