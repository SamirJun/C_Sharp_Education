// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 23 == 0 && num % 7 == 0)
   Console.WriteLine("Число кратно 7 и 23");
else Console.WriteLine("Числа не кратны 7 и 23");