// // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] massiv)
{
    int length = massiv.Length;
    int index = 0;
    while (index < length)
    {
        massiv[index] = new Random().Next(0, 50);
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
    int max = array[0];
    int min = array[0];    
    for (int i = 0; i < L; i++)
    {
       if (array[i] > max)
       {
         max = array[i];
    
       } 
        else if (array[i] < min)
        {
           min = array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Максимальное значение массива = {max}");
    Console.WriteLine($"Минимальное значение массива = {min}");
    Console.WriteLine($"Разница между макисмальным и минимальным элементом = {max - min}");
}

FillArray(array);
PrintArray(array);
NumFind(array);
