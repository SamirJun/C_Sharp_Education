﻿// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. 
// Если N = 5 -> 0 1 1 2 3 
// Если N = 3 -> 0 1 1 
// Если N = 7 -> 0 1 1 2 3 5 8 
 
 
Console.WriteLine("Введите число N"); 
int N = Convert.ToInt32(Console.ReadLine()); 
 
int [] array = new int[N]; 
 
void FillArray(int [] array )   
{       
    array[0] = 0; 
    array[1] = 1; 
    for (int i =2; i<N; i++)     
        array[i] = array[i-1] + array[i-2]; 
     
}    

FillArray(array); 
 
foreach (int i in array) 
{ 
    Console.Write($"{i} "); 
} 