// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int KeyboardInput(string comment)
{
    Console.Write(comment);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}


int rows = KeyboardInput("Введите колличество строк ");
int colms = KeyboardInput("Введеите колличество колонок");

int[,] firstmatrix = new int[rows, colms];
int[,] secondmatrix = new int[rows, colms];
int[,] resultmatrix = new int[rows, colms];

if (firstmatrix.GetLength(0) != secondmatrix.GetLength(1))
{
    Console.WriteLine("Матрицы нельзя перемножить!!!");
    return;
}

FillArray(firstmatrix);
FillArray(secondmatrix);
PrintArray(secondmatrix);
Console.WriteLine();
PrintArray(firstmatrix);

for (int i = 0; i < firstmatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondmatrix.GetLength(1); j++)
    {
        for (int k = 0; k < firstmatrix.GetLength(1); k++)
        {
            resultmatrix[i, j] += firstmatrix[i, k] * secondmatrix[k, j];
        }
    }
}

Console.WriteLine();
PrintArray(resultmatrix);