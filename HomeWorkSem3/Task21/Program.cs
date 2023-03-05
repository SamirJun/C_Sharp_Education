// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки X1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки X2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1)+(z2-z1)*(z2-z1));
Console.WriteLine(res);