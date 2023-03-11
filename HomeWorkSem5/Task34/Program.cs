// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int EvenNum (int [] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if(el % 2 == 0) count++;
    }
    return count;
}



Console.Write("Введите количесво элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int [] array = new int [N];

FillArray(array);
PrintArray(array);
Console.WriteLine($"Колличество четных чесел в массиве = {EvenNum(array)}");