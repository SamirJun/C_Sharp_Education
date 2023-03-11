// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

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

int MaxPosition(int [] array)
{
    int max = array[0];
    int indexmax = 0;
    for (int i =1 ; i < array.Length; i++)    
    {
        if(array[i]> max)
        {
            max = array[i];
            indexmax = i;
        }
    }
    return indexmax;
}

int MinPosition(int [] array)
{
    int min = array[0];
    int indexmin = 0;
    for (int i =1 ; i < array.Length; i++)    
    {
        if(array[i]< min)
        {
            min = array[i];
            indexmin = i;
        }
    }
    return indexmin;
}

int ArithmeticMean(int[] array)
{
    int res = 0;
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum += array[i];
    res = sum/2;
    return res;
}

void Sort(int [] array)
{
    for(int i = 0; i< array.Length; i++)
        {
            for(int j = 0; j < array.Length-1; j++)
            {
                if (array[j+1]<array[j])
                {
                    int n = array[j];
                    array[j] = array[j+1];
                    array[j+1] = n;
                }
            }
        }
}

double Mediana(int[] array)
{
    if(array.Length%2 == 0)
    {
        int center = array.Length/2;
        int n = array[center - 1] + array[center];
        double result = Convert.ToDouble(n) / 2;
        return result;
    }
    else
    {
        int center = array.Length/2;
        double result = array[center];
        return result;
    }
}



Console.Write("Введите количесво элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int [] array = new int [N];

FillArray(array);
PrintArray(array);

int [] collection = new int [3];

collection[0] = MaxPosition(array);
collection[1] = MinPosition(array);
collection[2] = ArithmeticMean(array);
Console.WriteLine($"Индекс максимального значения массива = {collection[0]} \nИндекс миниммального значения масива = {collection[1]} \nСреднее арифметическое значения массива = {collection[2]}");

Sort(array);
PrintArray(array);
Console.WriteLine($"Медиана данного массива = {Mediana(array)}");