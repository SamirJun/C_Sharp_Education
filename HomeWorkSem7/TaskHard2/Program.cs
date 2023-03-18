// Задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , 
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. 
// Перемешать случайным образом элементы массива, 
// причем чтобы каждый элемент гарантированно и только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 999);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}  ");
        }
        Console.WriteLine();
    }
}

void Convertor(int[,] array, int[] arrayline)
{

    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayline[k] = array[i, j];
            k++;
        }
    }
}

void Mix(int[] arrayline)
{
    int [] collect = new int [arrayline.Length];
    
    for (int i = 0; i < arrayline.Length/2; i++)
    {
        int a = new Random().Next(0,arrayline.Length);
        int b = new Random().Next(0,arrayline.Length);
        for(int j = 0; j< collect.Length; j++)
        {
            
        }
    }
}

void ConvertorMatrix(int [,] array, int [] arrayline)
{
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = arrayline[k];
            k++;
        }
    }
}



Console.WriteLine("Введите четную размерность таблицы");
Console.WriteLine("Введите колличество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов");
int colms = Convert.ToInt32(Console.ReadLine());
if (rows * colms % 2 == 0)
{
    int[,] array = new int[rows, colms];
    int[] arrayline = new int[rows * colms];
    FillArray(array);
    PrintArray(array);
    Convertor(array, arrayline);
    Mix(arrayline);
    ConvertorMatrix(array,arrayline);
    Console.WriteLine();
    PrintArray(array);

}
else Console.WriteLine("Введенная размерность не четная!!!");
