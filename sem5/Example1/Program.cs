// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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

void Summa(int[]array)
{
    int sump =0;
    int sumn =0;
    for( int i = 0; i< array.Length; i++)
    {
        if(array[i]>0) sump+=array[i];
        else sumn+=array[i];
    }
    Console.WriteLine($"{sump}");
    Console.WriteLine($"{sumn}");

}

int[] Summa2(int [] array)
{
    int sump=0;
    int sumn=0;
    for (int i =0; i<array.Length; i++)
        if (array[i]>0) sump+=array[i];
        else sumn+=array[i];

    int[] results = {sump,sumn};
    return results;
}


int [] array = new int [17];

FillArray(array);
PrintArray(array);
Summa(array);
int [] rez = Summa2(array);

Console.WriteLine($"Сумма положительных элементов равна {rez[0]}");
Console.WriteLine($"Сумма отрицательных элементов равна {rez[1]}");