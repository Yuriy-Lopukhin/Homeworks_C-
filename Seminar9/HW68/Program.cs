//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
///////////////////////////////////////////////////////////////////////////////////////
Console.Clear();

int m = InputValue("Введите число M: ");

int n = InputValue("Введите число N: ");

GetAkkermanFunction(m,n);

//////////////////////////////////////////////////////////////////////////////////////////
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
// Вывод результата на экран
void GetAkkermanFunction(int m, int n)
{
    if(m < 0 || n < 0) Console.Write($"Введены отрицательные значения, вычисление невозможно!");
    else Console.Write($"Для введённых чисел {m} и {n} значение функции Аккермана равно {GetAkkermanForValues(m, n)}"); 
}

// функция Аккермана
int GetAkkermanForValues(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return GetAkkermanForValues(m - 1, 1);
    }
    else
    {
        return (GetAkkermanForValues(m - 1, GetAkkermanForValues(m, n - 1)));
    }
}
