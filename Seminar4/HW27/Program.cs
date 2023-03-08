// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. 
//////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int res = GetSumResult(num);

Console.WriteLine($"Сумма всех цифр в числе {num} -> {res}");

////////////////////////////////////////////////////////////////////////////////////////
int GetNumberFromUser(string message, string errorMessage)  //Ввод числа пользователем 
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

int GetSumResult(int number)    //Вычисление суммы всех цифр числа
{
    int res = 0;
    while (number > 0)
    {
       res += number % 10;
       number = number / 10;
    }
    return res;
}