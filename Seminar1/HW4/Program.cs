Console.Write("Введите первое число: ");
int FirstUserNumber = int.Parse(Console.ReadLine() ?? "");    //Ввод первого числа
Console.Write("Введите второе число: ");
int SecondUserNumber = int.Parse(Console.ReadLine() ?? "");    //Ввод второго числа
Console.Write("Введите второе число: ");
int ThirdUserNumber = int.Parse(Console.ReadLine() ?? "");    //Ввод третьего числа

int maxNum = FirstUserNumber;
if (SecondUserNumber > maxNum)
    maxNum = SecondUserNumber;
if (ThirdUserNumber > maxNum)
    maxNum = ThirdUserNumber;
Console.WriteLine($"a = {FirstUserNumber} b = {SecondUserNumber}  c = {ThirdUserNumber} -> max = {maxNum}");

