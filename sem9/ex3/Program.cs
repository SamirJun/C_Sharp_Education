// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumRec(num));

int SumRec(int num)
{
    if(num == 0) return 0;
    return num%10 + SumRec(num/10);
}