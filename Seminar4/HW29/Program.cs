// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
////////////////////////////////////////////////////////////////////////////////////////
int userLenght = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода!");
int userMin = GetNumberFromUser("Начальное зхначение: ", "Ошибка ввода!");
int userMax = GetNumberFromUser("Конечное значение: ", "Ошибка ввода!");
int[] array = FillArray(userLenght, userMin, userMax);

PrintArray(array);

//Console.WriteLine($"[{String.Join(",", array)}]");
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
int[] FillArray(int lenght, int min, int max)
{
    int[] array = new int[lenght];
    Random random = new Random();
    
    for(int i = 0; i < lenght; i++)
    {
       array[i] = new Random().Next(min, max+1);
    }
return array;
}

void PrintArray(int[] array)
{
  int lenght = array.Length;
    Console.Write("[");
    for(int i = 0; i < lenght; i++)
    {
      if (i < lenght-1) Console.Write($"{array[i]},");
      if (i == lenght-1) Console.Write($"{array[i]}");
    }
Console.Write($"]");   
}