// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

void FillArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 9);
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
void Proverka (int [,] array, int[] arrayline)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            arrayline[array[i,j]] ++;
        }
    }
}

void Print (int[] arrayline)
{
    for (int i = 0; i < arrayline.Length; i++)
    {
        if(arrayline[i] != 0)
        {
            Console.WriteLine($"Элемент {i} встречается {arrayline[i]} раз");
        }
    }
}

int [,] array = new int [4,4];
int [] arrayline = new int [10];

FillArray(array);
PrintArray(array);
Proverka(array,arrayline);
Print(arrayline);