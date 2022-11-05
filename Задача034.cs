// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] massiv)
{
    int length = massiv.Length;
    int index = 0;
    while (index < length)
    {
        massiv[index] = new Random().Next(100, 999);
        index++;
    }
}
void PrintArray(int[] mass)
{
    int count = mass.Length;
    int position = 0;
    while (position < count)
    {
       Console.Write($"{mass[position]}, ");
       position++;
    }
}
Console.Write($"Введите длину массива = ");
int L = Convert.ToInt32(Console.ReadLine());
int[] array = new int[L];

void NumFind(int[] array)
{
    int sum = 0;
    for (int i = 0; i < L; i++)
    {
       if (array[i] %2 == 0 )
       {
        sum ++;
       } 
    }
    Console.WriteLine($"Количество четных чисел = {sum}");

}

FillArray(array);
PrintArray(array);
NumFind(array);

