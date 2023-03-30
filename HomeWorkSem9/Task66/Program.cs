// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел = {SummaRec(num1, num2)}");


int SummaRec(int num1, int num2)
{
    if (num1>num2) return 0; 
    return num2 + SummaRec(num1,num2-1);  
}