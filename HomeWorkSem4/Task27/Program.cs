// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int arg1,int count)
{
    int i = 1;
    int result = 0;
    while (i <= count)
    {
        result = result + arg1%10;
        arg1 = arg1/10;
        i++;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int number = Convert .ToInt32(Console.ReadLine());

int count = (int)Math.Log10(number)+1;

Console.WriteLine(Sum(number,count));
