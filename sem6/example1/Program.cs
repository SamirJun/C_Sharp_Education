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

void ChangeArray(int []array)
{
    // int temp = 0;
    for(int i =0; i < array.Length/2;i++)
    {
        // temp = array[i];
        // array[i] = array[array.Length-1-i];
        // array[array.Length-1-i] = temp;
        (array[i] , array[array.Length-1-i]) = (array[array.Length-1-i], array[i]);
    }
}

int[] array = new int [7];

FillArray(array);
PrintArray(array);

ChangeArray(array);
PrintArray(array);