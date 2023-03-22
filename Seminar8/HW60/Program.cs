// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/////////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
int A = InputValue("Введите величеиу первого измерения массива: ");
int B= InputValue("Введите величеиу второго измерения массива: ");
int C = InputValue("Введите величеиу третьего измерения массива: ");

int[,,] array = new int[A, B, C];
CreateArray(array);
PrintArray(array);

////////////////////////////////////////////////////////////////////////////////////////////////
//Ввод параметров массива
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
//Создание трёхмерного массива
void CreateArray(int[,,] arr)
{
  int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
  int  element;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    element = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          element = temp[i];
        }
          element = temp[i];
      }
    }
  }
  int count = 0; 
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        arr[i, j, k] = temp[count];
        count++;
      }
    }
  }
}

//Вывод элементов массива на экран
void PrintArray (int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write($"Arr[{i}, {j}, {k}] = {arr[i,j,k]};\t ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
