﻿int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 3;
int b1 = 5;
int c1 = 9;
int a2 = 56;
int b2 = 65;
int c2 = 321;
int a3 = 34;
int b3 = 5454;
int c3 = 33;

int max = Max(Max(a1,b1,c1), Max(a2,b2,c2),Max(a3,b3,c3));
Console.WriteLine(max);