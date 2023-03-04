void CheckCord(int xy)
{
   
    if (xy == 1)
        Console.WriteLine("Точки находятся в диапазоне x>0 & y>0");
    else if (xy == 2)
        Console.WriteLine("Точки находятся в диапазоне x<0 & y>0");
    else if (xy == 3)
        Console.WriteLine("Точки находятся в диапазоне x<0 & y<0");
    else if (xy==4)
        Console.WriteLine("Точки находятся в диапазоне x>0 & y<0");
    else 
        Console.WriteLine("Вы ввели число не в диапазоне от 1 до 4");
}

string  CheckCord2(int arg)
{

    string res ="Ошибка";
    if (arg == 1)
        res ="Точки находятся в диапазоне x>0 & y>0";
    else if (arg == 2)
        res = "Точки находятся в диапазоне x<0 & y>0";
    else if (arg == 3)
        res = "Точки находятся в диапазоне x<0 & y<0";
    else if (arg == 4)
        res = "Точки находятся в диапазоне x>0 & y<0";
    
    return res;
}



Console.WriteLine("Введите № четверти ");
int xy = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());

CheckCord(xy);

Console.WriteLine("");
Console.WriteLine(CheckCord2(xy));
