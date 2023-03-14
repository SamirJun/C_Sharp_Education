// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// 45 -> 101101 
// 3  -> 11 
// 2  -> 10 

string ConvertToBin(int number)
{
    string result = Convert.ToString(number, 2);
    return result;
}

Console.WriteLine("Введите десятичное число "); 
int num = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine(ConvertToBin(num));