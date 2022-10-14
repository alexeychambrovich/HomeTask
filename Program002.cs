// задача 2 Напишите программу, которая на вход  принимает  два числа и выдает, какое число большее, а какое меньшее
//a = 5; b = 7 -> max = 7; a = 2; b = 10 -> max = 10; a = -9; b = -3 -> max = 10;

// Console.Clear;
Console.WriteLine("введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе  число");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine(" число "   + a   + "больше числа"   + b);
}
else
{
    Console.WriteLine(" число "   + b   + "больше числа"   + a);
}