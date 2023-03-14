// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше 

Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int num3 = Convert.ToInt32(Console.ReadLine());

bool Check(int num1, int num2, int num3)
{
    bool prov = false;
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
        prov = true;
    return prov;
}

Console.WriteLine(Check(num1, num2, num3));