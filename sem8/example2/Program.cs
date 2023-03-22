// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

void Convertor (int [,] array, int [,] matrix)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            matrix[j,i] = array[i,j];
        }
    }
}

int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [n,n];
int [,] matrix = new int [n,n];

FillArray(array);
PrintArray(array);
Convertor(array,matrix);
Console.WriteLine();
PrintArray(matrix);