Console.Write("Введите номер дня недели: ");
int UserNumber = int.Parse(Console.ReadLine() ?? "");

if ((UserNumber > 0) && (UserNumber <= 7)) 
{
    if ((UserNumber == 6) || (UserNumber == 7))
     {
      Console.WriteLine($"Это выходной день!");
     }
    else
     {
       Console.WriteLine($"Это рабочий день!"); 
     } 
}
else
{
    Console.WriteLine($"В неделе всего семь дней! Введите корректный номер дня!");
}