Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());

Sqrt(N);

void Sqrt(int N)
{
    int i = 1;

    while (i <= N)
    {
        Console.Write(i * i + " ");
        i++;
    }
}
