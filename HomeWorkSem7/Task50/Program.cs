// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-30, 30);
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

string Search (int [,] array, int argument)
{
    
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == argument)
            {
                return $"Элемент '{argument}' находится в строке {i+1}, столбце {j+1}";
            }
        }
    }
    return $"Элемента '{argument}' нет в таблице";
}


int [,] array = new int [4,4];
FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите элемент который желаете найти в таблице");
int sort = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Search(array, sort));