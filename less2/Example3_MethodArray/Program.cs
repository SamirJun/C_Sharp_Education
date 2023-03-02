int[] Array = { 14, 2, 33, 24, 56, 16, 71, 89, 39 };

int n = Array.Length;

int find = 16;
int index = 0;
while (index<n)
{
    if (Array[index] ==find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}