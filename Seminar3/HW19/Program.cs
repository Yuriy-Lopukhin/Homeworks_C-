int num = new Random().Next(10000, 100000);
int a1 = num/10000;
int a2 = (num/1000)%10;
int a3 = (num/100)%10;
int a4 = (num/10)%10;
int a5 = num%10;

if((a1 == a5) && (a2 == a4)) 
{
    Console.WriteLine($"Введено число {num}, это палиндром!");
}
else
{
  Console.WriteLine($"Введено число {num}, это не палиндром!");  
}