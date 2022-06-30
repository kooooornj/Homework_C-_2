 /*Zadacha 10
void FindSecondDigit()
{
    Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 | number >= 1000 )
{
    Console.WriteLine("Число не является трехзначным");
}
else 
{
int des = number / 10;
int two = des % 10;
Console.WriteLine("Второе цифра данного числа = " + two);
}
}
FindSecondDigit();
*/ 

 /*Zadacha 13 
 First way 

void FindThirdDigit()
{
    
    int rand = new Random().Next();
    Console.WriteLine("Заданное число = " + rand);
    if (rand < 100)
    {
        Console.WriteLine("У числа нет третьей цифры");
    }
    else
    {    
        int third = 0;
        while (rand > 99)
     {
         third = rand % 10;
         rand = rand / 10;
     
     }
     Console.WriteLine("Третья цифра данного числа = " + third);    
    }
}
FindThirdDigit(); */
/*
Second way

void FindThirdDigit()
{
    
    int rand = new Random().Next();
    Console.WriteLine("Заданное число = " + rand);
    if (rand < 100)
    {
        Console.WriteLine("У числа нет третьей цифры");
    }
    else
    {
        Console.WriteLine("Третья цифра данного числа = " + rand.ToString()[2]);  
    }
}
FindThirdDigit(); */

/* Zadacha 15 
void Determiningtheday()
{
    Console.Write("Введите число");
 int number = Convert.ToInt32(Console.ReadLine());
    if (number < 1 | number > 7)
    {
        Console.WriteLine("Неверно введено число, повторите попытку");
    }
     if (number >= 1 && number <= 5)
    {
      Console.WriteLine("Данный день недели не является выходным");
    }
     if (number >= 6 && number <= 7)
    {
      Console.WriteLine("Данный день недели является выходным");
    }
}
Determiningtheday();
*/