// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(int arg)
{
    if (arg >= 10000 && arg < 100000)
    {
        int div1 = arg / 10000;
        int rem1 = arg % 10;
        if (div1 == rem1)
        {
            int num = arg / 10;
            int div2 = (num / 100) % 10;
            int rem2 = num % 10;
            if (div2 == rem2)
                Console.WriteLine($"Число {arg} является палиндромом");
            else Console.WriteLine($"Число {arg} не является палиндромом");
        }
        else Console.WriteLine($"Число {arg} не является палиндромом");

    }
    else Console.WriteLine($"Число {arg} не является пятизначным");
}


Console.Clear();
Console.WriteLine("Wellcome Palindrom");
string stop = "go";
while (stop.ToLower() != "break")
{
    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Palindrom(number);
    Console.WriteLine("Если вы желаете выйти из программы введите слово break");
    stop = Console.ReadLine();
    Console.WriteLine("");
}
