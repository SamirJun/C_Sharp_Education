// Задача 27. - HARD необязательная 
// Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4


int Index(decimal num)
{
    int count = 0;
    while ((num % 1) > 0)
    {
        num = (num * 10);
    }

    while (num > 1)
    {
        num = (num / 10);
        count = count + 1;
    }
    return count;
}





Console.Write("Введите целое или дробное число: ");
decimal num = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе = {Index(num)}");