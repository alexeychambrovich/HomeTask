// Задача 29: Напишите программу, которая задаёт массив произвольной длины, заполняет произвольными элементами и выводит их на экран.
// Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19];    6, 1, 33 -> [6, 1, 33]


void FillArray(int[] massiv)
{
    int length = massiv.Length;
    int index = 0;
    while (index < length)
    {
        massiv[index] = new Random().Next(1, 100);
        index++;
    }
}


void PrintArray(int[] mass)
{
    int count = mass.Length;
    int position = 0;
    while (position < count)
    {
       Console.WriteLine(mass[position]);
       position++;
    }
}

Console.Write("Введите длину массива"  );
int L = Convert.ToInt32(Console.ReadLine());

int[] array = new int[L];

FillArray(array);
PrintArray(array);



 