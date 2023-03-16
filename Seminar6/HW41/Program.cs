//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
////////////////////////////////////////////////////////////////////////////////////////////////
int M = InputNumber("Введите количество чисел в массиве: ");
int[] UserArray = GetUserArray(M);
int PositiveSum = GetPositiveSum(UserArray);
Console.WriteLine($"[{String.Join(",", UserArray)}] -> {PositiveSum}");
///////////////////////////////////////////////////////////////////////////////////////////////
//Ввод данных от пользователя
static int InputNumber(string message)
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

//Создание массива из чисел, вводимых пользователем
int[] GetUserArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        //В сообщении указывается не индекс, а порядковый номер числа
        res[i] = InputNumber($"Введите {i+1} число: "); 
    }
    return res;
}

//Подсчёт количества положительных элементов в массиве
int GetPositiveSum(int[] arr)
{
   int result = 0;
   for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>=0) result++;
    }
    return result; 
}


