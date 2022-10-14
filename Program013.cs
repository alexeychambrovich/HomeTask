// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5;    78 -> третьей цифры нет;   32679 -> 6


Console.WriteLine("введите целое число");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100)
{
   if (a > 999)
   {
    int i = 10;
    while (a / i > 1000)
    {
        i = i + 10;
    }
   Console.WriteLine("третья цифра числа = " + (a / i) % 10);
   }
   
else
{
    Console.WriteLine("третья цифра числа = " + a % 10);
}
}
else
{
    Console.WriteLine("третьей цифры нет");
}


