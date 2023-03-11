// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

void FillArray(int[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
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

void Negativ(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i]* -1;
        Console.Write($"{array[i]} ");
    }
    }
    




int [] array = new int [4];
FillArray(array);
PrintArray(array);

Negativ(array);