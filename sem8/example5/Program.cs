// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 9);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}  ");
        }
        Console.WriteLine();
    }
}

int[] Minimum(int[,] array)
{
    int min = 10;
    int[] index = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}

void FillNewArray(int[,] array, int[,] newarray, int[] index)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i >= 0 && i< index[0] && j >= 0 && j < index[1] | 
               i>index[0] && i < array.GetLength(0) && j >= 0 && j < index[1] |
               i >= 0 && i< index[0] && j > index[1] && j < array.GetLength(1) |
               i>index[0] && i < array.GetLength(0) && j > index[1] && j < array.GetLength(1) )
            {
                newarray[i,j] = array[i,j];
            }
        }

    }

}

int[,] array = new int[4, 4];
int[,] newarray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
FillArray(array);
PrintArray(array);
int[] index = Minimum(array);
FillNewArray(array, newarray, index);
Console.WriteLine();
PrintArray(newarray);
