void CheckCord(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("Четверть №1");
    else if (x > 0 && y < 0)
        Console.WriteLine("Четверть №4");
    else if (x < 0 && y < 0)
        Console.WriteLine("Четверть №3");
    else if (x < 0 && y > 0)
        Console.WriteLine("Четверть №2");
    else if (x == 0 | y == 0)
        Console.WriteLine("x, y равно 0");
}

int CheckCord2(int x, int y)
{
    int res = 0;
    if (x > 0 && y > 0)
        res =1;
    else if (x > 0 && y < 0)
        res = 4;
    else if (x < 0 && y < 0)
        res = 3;
    else if (x < 0 && y > 0)
        res = 2;
    
    return res;
}



Console.WriteLine("Введите координату X ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Координаты находятся в четверти № {CheckCord2(x,y)}");



