Console.Write("Введите целое число: ");
int UserNum = int.Parse(Console.ReadLine() ?? "");
int i = 1;
Console.Write($"{UserNum} -> ");

while (i < UserNum) 
{
    int Number = i*i*i;
    Console.Write($"{Number} ");
    i = i+1;
}