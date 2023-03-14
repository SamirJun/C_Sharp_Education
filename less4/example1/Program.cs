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
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}






int [,] table = new int [100,80];
// table [0,0]  table [0,1]     table [0,2]     table [0,3]     table [0,4]
// table [1,0]  table [1,1]     table [1,2]     table [1,3]     table [1,4]

FillArray(table);
PrintArray(table);