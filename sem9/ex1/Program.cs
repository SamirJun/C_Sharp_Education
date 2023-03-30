Console.WriteLine("Введите число N");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" рекурсией все натуральные числа N {NaturalChisla(num)}");

string NaturalChisla(int num)
{
    if (num==0) return "";
    return NaturalChisla(num-1) + " " + num;
}