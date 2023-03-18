// Задача 51: Задайте двумерный массив. Найдите дву суммы элементов, находящихся на главной диагонали и обратной диагонали.
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1+9+2 = 12
// сумма элементов обратной диагонали 8+9+7 = 24

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

int Diagonal (int [,] array)
{
    int sum = 0;
    for(int i = 0; i< array.GetLength(0); i++)
    { 
        sum+=array[i,i];
    }
    return sum;
}

int InvertDiagonal( int[,] array)
{
    int sum = 0;
    for(int i = 0; i< array.GetLength(0); i++)
    {
        sum+=array[i,array.GetLength(0)-i-1];
    }
    return sum;
}

int [,] array = new int [4,4];

FillArray(array);
PrintArray(array);
Console.WriteLine(Diagonal(array));
Console.WriteLine(InvertDiagonal(array));