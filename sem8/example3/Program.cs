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

void Convertor (int [,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = i; j< array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
}

int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [n,n];

FillArray(array);
PrintArray(array);
Convertor(array);
Console.WriteLine();
PrintArray(array);