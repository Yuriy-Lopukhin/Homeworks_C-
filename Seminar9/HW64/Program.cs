/// Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
////////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
int number = InputValue("Введите число: ");
int count = 1;
NaturalValues(number, count);


////////////////////////////////////////////////////////////////////////////////////////////////
//Ввод числа
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
void NaturalValues(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else if (count == 0)
    {
        Console.Write(count); 
    }
    else
    {
        NaturalValues(n, count + 1);
        Console.Write(count + " ");
    }
}
