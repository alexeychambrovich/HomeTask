// напишите пНапишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27;   5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Введите N: ");

bool correct = true;
while (correct)
{
    try
    {
        int N = Convert.ToInt32(Console.ReadLine());
        List<int> array = new List<int>();

        if (N > 0)
        {
            for (double i = 1; i <= N; i++)
            {
                array.Add(Convert.ToInt32(Math.Pow(i, 3)));
            }
        }
        Console.Write(String.Join(", ", array));
    }
    catch (System.Exception)
    {
        
        Console.WriteLine("Введено неверное значение");
    }
}
