// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
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

int Sum(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
            result+=array[i];
    }
    return result;
}


Console.Write("Введите количесво элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int [] array = new int [N];

FillArray(array);
PrintArray(array);

Console.WriteLine($"Сумма элементов массива на нечетных позициях = {Sum(array)}");