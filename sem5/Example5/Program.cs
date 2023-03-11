// Задача 35: Задайте одномерный массив из 12 случайных чисел от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5,
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray(int[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
}

void PrintArray(int[] array)
{
    foreach(int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
}

int Proverka (int[] array)
{
    int count = 0;
    for( int i = 0; i< array.Length; i++)
    {
        if(array[i]>=10 && array[i]<=99)
            count ++;
    }
    return count;
}





int [] array = new int [12];

FillArray(array);
PrintArray(array);
Console.WriteLine(Proverka(array));