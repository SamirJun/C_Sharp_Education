// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int[] Sum(int[] array)
{
    int[] res = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        res[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
    {
        res[array.Length / 2] = array[array.Length / 2];
    }

    return res;

}


Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

FillArray(array);
PrintArray(array);
int[] result = Sum(array);
PrintArray(result);