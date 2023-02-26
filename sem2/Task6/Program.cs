Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digitsCount = (int)Math.Log10(number) + 1; 
int multiplier = (int)Math.Pow(10, digitsCount - 2); 
int result = number % multiplier + number / multiplier / 10 * multiplier; // все что справа от разряда + все что слева, делённое на 10
Console.WriteLine(result); 