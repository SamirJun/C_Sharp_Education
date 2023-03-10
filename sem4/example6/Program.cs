// Console.Write("Введите число: ");
// double num = Convert.ToDouble(Console.ReadLine());

// for()
// Console.WriteLine(res);

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

Console.WriteLine("Введите число");
decimal num = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine(Index(num));