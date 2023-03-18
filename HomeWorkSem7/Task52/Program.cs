// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j],3}  ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean (int [,] matrix, double [] array)
{
    for(int i = 0; i< matrix.GetLength(1); i++)
    {   
        int sum = 0;
        double arifmean = 0;
        for (int j = 0; j< matrix.GetLength(0); j++)
        {
            sum += matrix[j,i];
        }
        
        arifmean = Convert.ToDouble(sum) /2;
        array[i] = arifmean;
    }
}

void PrintResult (double [] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i],3}  ");
    }
}

int [,] table = new int [4,4];
double [] array = new double [4];
FillArray(table);
PrintArray(table);
ArithmeticMean(table,array);
Console.WriteLine();
PrintResult(array);