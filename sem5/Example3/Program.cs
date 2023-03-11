// // Задача 33: Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// 4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,10);
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

bool Proverka (int [] array, int arg)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(Math.Abs(array[i]) == Math.Abs(arg))
            return true; 
    }
    return false;
}




Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());


int [] array = new int [5];

FillArray(array);
PrintArray(array);
Console.WriteLine(Proverka(array,N));