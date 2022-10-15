// НАпишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 12821 -> да; 23432 -> да

Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
int original = n;
int reversed = 0;

while (n != 0)
{
    int remaider = n % 10;
    reversed = reversed * 10 + remaider;
    n /= 10;
}

if (original == reversed)
{
    Console.WriteLine($"{original} - палиндром"); 
}
else
{
    Console.WriteLine($"{original} - не палиндром"); 
}