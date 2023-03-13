//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/////////////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
int lenght = InputNumber("Введите длину массива: ");
int min = 100;
int max = 999;

int[] array = GetArray(lenght, min, max);
int quantity = GetEvenQuantity(array);
PrintResults(array, quantity);
//////////////////////////////////////////////////////////////////////////////////////////////////////
// Ввод длины массива
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

//Создание массива случайных трёхзначных чисел 
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

//Определение количества чётных чисел в массиве
int GetEvenQuantity(int[] arr)
{
    int count = 0;
    for (int i=0 ; i<arr.Length; i++)
    {
        if (arr[i]%2 == 0) count++;
    }
    return count;
}

//Вывод результатов на экран
void PrintResults(int[] arr, int value)
{
    Console.WriteLine("Создан массив:");
    Console.WriteLine(String.Join(" ", arr));
    Console.WriteLine($"Количество чётных чисел в созданном массиве равно {value}");
}