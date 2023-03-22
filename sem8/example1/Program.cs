// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void Sort (int [,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        (array[0,i ], array[array.GetLength(0)-1,i])= (array[array.GetLength(0)-1,i], array[0,i ]);
    }
}

int[,] array = new int [3,4];
FillArray(array);
PrintArray(array);
Sort(array);
Console.WriteLine();
PrintArray(array);
