// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11;   82 -> 10;   9012 -> 12;

Console.WriteLine("Введите положительное целое число");
string n = Console.ReadLine();
int length = n.Length;
int sum = 0;

for (int i = 0; i < length; i++)
{
          sum = sum + Convert.ToInt32(Convert.ToString(n[i]));
}
Console.WriteLine($"Сумма = {sum}");
