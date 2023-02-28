Console.Write("Введите целое число: ");
int UserNum = int.Parse(Console.ReadLine() ?? "");    //Ввод числа
int def = UserNum;
if  (UserNum < 100) 
{
Console.WriteLine($"Во введённом числе нет третьей цифры!");
}
else
{
   while (UserNum > 999)
   {
     UserNum /= 10;
   }
int ThirdRank =  UserNum %10;
Console.WriteLine($"Введено число {def} -> Третья цифра {ThirdRank}");
}    
    

