// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
}

int Difference(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>max) max = array[i];
        else if (array[i]<min) min = array[i];
    }
    int result = max - min;
    return result;
}



Console.Write("Введите количесво элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int [] array = new int [N];

FillArray(array);
PrintArray(array);

Console.WriteLine($"Разница между максимальным и минимальным числом массива = {Difference(array)}");