// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



Console.Write("Введите число: ");
long num = Convert.ToInt64(Console.ReadLine());


int res = Convert.ToInt32(Math.Log10(num));
Console.WriteLine(res);