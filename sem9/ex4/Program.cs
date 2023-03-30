// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write(Degree(num,A));

int Degree(int num, int A)
{
    if(A == 0) return 1;
    return num*Degree(num,A-1);
}