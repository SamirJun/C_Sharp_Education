// Задача HARD SORT необязательная. Считается за три обязательных 
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10


void FillArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
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



void Convert (int [,] array, int [] arrayline)
{
    int a = 0;
    foreach (int i in array)
    {
        arrayline[a] = i;
        a++;
    }
}

void Sort (int [] arrayline)
{
    for (int j =0; j <arrayline.Length; j++)
        for(int i =j; i< arrayline.Length; i++)
        {
            // (arrayline[i],arrayline[arrayline.Length-1-i]) = (arrayline[arrayline.Length-1-i],arrayline[i]);
            
            int n = 0;
            if (arrayline[i]<arrayline[i+1])
            {
                n = arrayline[i+1];
                arrayline[i+1] = arrayline[i];
                arrayline[i] = n;
            }
        }
}

Console.WriteLine("Введите колличество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов");
int colms = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows,colms];
int [] arrayline = new int [rows*colms];
FillArray(array);
PrintArray(array);
Sort(array);
Console.WriteLine();
PrintArray(array);

