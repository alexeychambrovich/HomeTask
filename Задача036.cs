// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19            [-4, -6, 89, 6] -> 0

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
       if (i %2 != 0)
       {
        sum = sum + array[i];
       } 
    }
    Console.WriteLine($"Сумма значений нечётных индексов массива = {sum}");
    
}

FillArray(array);
PrintArray(array);
NumFind(array);

