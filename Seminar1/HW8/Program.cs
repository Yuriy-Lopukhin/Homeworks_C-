Console.Write("Введите целое число: ");
int UserNumber = int.Parse(Console.ReadLine() ?? "");    //Ввод первого числа
int i = 1;
Console.Write($"{UserNumber} -> ");
while (i < UserNumber)
{
    i = i + 1;
    if (i % 2 == 0)
    {
        Console.Write($" {i}, ");
        i = i + 1;
    }
    else
    {
        i = i + 1;
    }

}

