// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0
//////////////////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
int lenght = InputNumber("Введите длину массива: ");
int min = InputNumber("Введите минимальное значение: ");;
int max = InputNumber("Введите максимальное значение: ");;

int[] array = GetArray(lenght, min, max);
int notEvenSum = GetNotEvenPositionsSum(array);

printResult(array, notEvenSum);

/////////////////////////////////////////////////////////////////////////////////////////////////////////
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

//Создание массива случайных чисел 
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


//Определение суммы элементов массива, стоящих на нечётных позициях
int GetNotEvenPositionsSum(int[] arr)
{
    int sum = 0;
    for (int i=0 ; i<arr.Length; i++)
    {
        if (i % 2 == 0) sum = sum + arr[i];
    }
    return sum;
}

//Вывод результата на экран
void printResult(int[] arr, int value)
{
   Console.WriteLine($"[{String.Join(",", arr)}] -> {value}"); 
}
