// Задача 24: Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Sum(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
        sum += i;
    return sum;
}

Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма всех чисел от 1 до {num} = {Sum(num)}");

