Console.Write("Введите первое число: ");
int FirstUserNumber = int.Parse(Console.ReadLine() ?? "");    //Ввод первого числа
Console.Write("Введите первое число: ");
int SecondUserNumber = int.Parse(Console.ReadLine() ?? "");    //Ввод первого числа

if (FirstUserNumber > SecondUserNumber)  // Определяем, какое число больше и выводим результат
    Console.WriteLine($"a = {FirstUserNumber} b = {SecondUserNumber} -> max = {FirstUserNumber}");
else if (FirstUserNumber < SecondUserNumber)
    Console.WriteLine($"a = {FirstUserNumber} b = {SecondUserNumber} -> max = {SecondUserNumber}");
else
    Console.WriteLine($"a = {FirstUserNumber} b = {SecondUserNumber} -> Оба числа равны!");
