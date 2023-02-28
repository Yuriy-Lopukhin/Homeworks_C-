int num = new Random().Next(100,1000);      //случайное трёхзначное число
int a2 = (num / 10) % 10;  // вторая цифра числа

Console.WriteLine($"{num} -> {a2}");

