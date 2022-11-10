// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Main(string[] args){
    double[,] a = new double[5,5];
    double[] b = new double[5];

    for (int i = 0; i < 5; i++){
       for (int j = 0; j < 5; j++){
        a[i,j] = i*j+1;
        Console.Write(a[i,j] + "  ");
       } 
       Console.WriteLine();
    }

    for (int i = 0, k = 0; i < 5; i++){
        double sum = 0;
        for (int j = 0; j < 5; j++)
        {
            sum += a[i,j];
        }
        b[k] = sum/5;
        // Console.WriteLine("Среднее арифметическое столбца "+(i)+"  равно: "+b[k]);   
        Console.WriteLine("Среднее арифметическое столбца "+(i+1)+"  равно: "+b[k]);
        k++;
    }
        Console.WriteLine();

}
Main(args);

