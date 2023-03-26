//Задача 66: Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.
/////////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
int m = InputValue("Введите число M: ");
int n = InputValue("Введите число N: ");

GetSumMToN(m, n);
////////////////////////////////////////////////////////////////////////////////////////////////
//Ввод значений от пользователя
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

// фНахождение суммы чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

// Вывод результата на экран
void GetSumMToN(int m, int n)
{
    Console.Write($"Сумма чисел от {m} до {n} равна {SumMN(m - 1, n)}");
}