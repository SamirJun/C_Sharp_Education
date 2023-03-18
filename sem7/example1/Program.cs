void FillArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-30, 30);
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




Console.WriteLine("Введите колличество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов");
int colms = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows,colms];
FillArray(array);
PrintArray(array);