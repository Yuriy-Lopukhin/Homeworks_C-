// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
/////////////////////////////////////////////////////////////////////////////////////////

Console.Clear();
int numA = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int numB = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода!");
int result = GetPovResult(numA, numB);
Console.WriteLine($"{numA} в {numB} степени -> {result}");


//////////////////////////////////////////////////////////////////////////////////////
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


int GetPovResult(int number1, int number2)
{
     int count = 1;
     int res = 1;
    while (count <= number2)
    {
       res = res * number1;
       count++;
    }
    return res;
}