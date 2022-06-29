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

/* Zadacha 13 */

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
        Console.WriteLine(rand.ToString()[2]);
       /* int third = 0;
        while (rand < 100)
     {
         third = rand % 10;
         rand = rand / 10;
         Console.WriteLine("Заданное число = " + rand); 
     }
     Console.WriteLine("Второе цифра данного числа = " + third); */   
    }
}
FindThirdDigit();

