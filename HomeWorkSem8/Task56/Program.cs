// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Заполняет матрицу
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
// Печатает матрицу
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
// Метода ввода с клавиатуры
int KeyboardInput (string comment)
{
    Console.Write(comment);
    return Convert.ToInt32(Console.ReadLine());
}
// Метода для вывода одномерного массива(использую для проверки правильности подсчета суммы)
void PrintStringArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine ($"Сумма строки {i+1} = {array[i],2}");
    }
}
// Метод подсчета суммы построчно
int[] SumToLower (int[,] array)
{   int [] summa = new int [array.GetLength(0)];
    for(int i = 0; i< array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j< array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        summa[i] = sum;
    }
    return summa;
}
// Метод сравнения суммы элементов каждой строки и вывода на экран строки с минимальной суммой
void Minimum (int [] array)
{
    int min = array[0];
    int index = -1;
    for(int i = 0; i< array.Length; i++)
    {   
        
        if(min>array[i])
        {
            min = array[i];
            index = i;
        }
        
    } 
    Console.WriteLine($"Строка с наименьшей суммой элементов - {index + 1}");
}
    
int rows = KeyboardInput("Введите колличество строк ");
int colms = KeyboardInput("Введеите колличество колонок");

int[,] array = new int [rows,colms];
FillArray(array);
PrintArray(array);
int [] sum = SumToLower(array);
PrintStringArray(sum);
Console.WriteLine();
Minimum(sum);