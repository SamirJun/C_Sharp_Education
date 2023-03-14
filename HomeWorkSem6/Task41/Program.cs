// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray (int [] array)
{
    Console.WriteLine("Введите числа (после каждого числа нажимайте Enter)");
    for(int i =0; i<array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int PositiveNumber (int[] array)
{
    int result = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i] > 0)
            result++;
    }
    return result;
}


Console.Write("Введите колличество чисел которое вы ходите ввести: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] numbercollection = new int [count];

FillArray(numbercollection);

Console.WriteLine($"Колличество чисел больше 0 = {PositiveNumber(numbercollection)}");