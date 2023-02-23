Console.Write("Введите целое число: ");
int UserNumber = int.Parse(Console.ReadLine() ?? "");

if (UserNumber % 2 == 0)
    Console.WriteLine($"{UserNumber} -> Да!");
else
    Console.WriteLine($"{UserNumber} -> Нет!");

