// Метод заполнения массива
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 15);
        index++;
    }
}

// Метод вывода на экран элементов массива
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

// Метод сравнения элемента массива с заданным
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
        
    }
    return position;
}

// Создаем новый масив при помощи *new int [i]*
int[] Array = new int[20];

// Заполняем наш массив при помощи метода FillArray
FillArray(Array);
// Выводим на экран значения нашего массива при помощи метода PrintArray
PrintArray(Array);
// Добавляем пустую строку
Console.WriteLine();
// Включаем в работу метод IndexOf
int pos = IndexOf(Array, 6);
Console.WriteLine(pos);